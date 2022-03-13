using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.IO;
using System.Windows.Forms;
using lab3;

namespace lab3
{
  

    abstract public class DocumentsAccounting : IComparable
    {
        abstract public DateTime getDateStart();
        abstract public DateTime getDateEnd();

        public int Id { get; set; } = 0;
        public bool isDeleted { get; }
        public byte type_record { get; }
        public string Name { get; }
        public DateTime DateAdd { get; }
        public DateTime DateClose { get; }
        public string Description { get; }

        abstract public int getCount();

        public int Count;
        public int CompareTo(object o)
        {
            if (this.DateAdd == (((DocumentsAccounting)o).DateAdd))
                return this.Name.CompareTo(((DocumentsAccounting)o).Name);
            else return DateTime.Compare(this.DateAdd, (((DocumentsAccounting)o).DateAdd));
        }


        public DocumentsAccounting(int Id, bool isDeleted, byte type_record, string Name, DateTime DateAdd, DateTime DateClose, string Description, int count)
        {
            this.Id = Id;
            this.isDeleted = isDeleted;
            this.type_record = type_record;
            this.Name = Name;
            this.DateAdd = DateAdd;
            this.DateClose = DateClose;
            this.Description = Description;
            this.Count = count;
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {DateAdd} {DateClose} {Description}";
        }
    }

    /// <summary>
    /// Недвижимость
    /// </summary>
    public class Realty : DocumentsAccounting
    {
        public double area;
        public Realty(int Id, bool isDeleted, byte type_record, string Name, DateTime DateAdd, DateTime DateClose, string Description, double area, int count)
            : base(Id, isDeleted, type_record, Name, DateAdd, DateClose, Description, count)
        {
            this.area = area;
        }
        override public int getCount() { return this.Count; }
        public double getArea() { return this.area; }

        override public DateTime getDateStart() { return this.DateAdd; }
        override public DateTime getDateEnd() { return this.DateClose; }
        public override string ToString()
        {
            return $" Id={Id}\n" +
                   $" Название={Name}\n" +
                   $" Дата добавления={DateAdd}\n" +
                   $" Дата завершения={DateClose}\n" +
                   $" Описание={Description}\n" +
                   $" Площадь={area}\n";
        }
    }

    /// <summary>
    /// Автотранспорт
    /// </summary>
    public class Auto : DocumentsAccounting
    {
        public string model;
        public Auto(int Id, bool isDeleted, byte type_record, string Name, DateTime DateAdd, DateTime DateClose, string Description, string model, int count)
            : base(Id, isDeleted, type_record, Name, DateAdd, DateClose, Description, count)
        {
            this.model = model;

        }
        override public int getCount() { return this.Count; }
        public string getModel() { return this.model; }

        override public DateTime getDateStart() { return this.DateAdd; }
        override public DateTime getDateEnd() { return this.DateClose; }
        public override string ToString()
        {
            return $" Id={Id}\n" +
                   $" Название={Name}\n" +
                   $" Дата добавления={DateAdd}\n" +
                   $" Дата завершения={DateClose}\n" +
                   $" Описание={Description}\n" +
                   $" Модель={model}\n";
        }
    }

    public interface IDataSource
    {
        DocumentsAccounting Save(DocumentsAccounting document);

        DocumentsAccounting Get(int id);

        bool Delete(int id);

        List<DocumentsAccounting> GetAll();
    }

    public class FileDataSource : IDataSource
    {
        public int counterRealty = 0;
        public int counterAuto = 0;
        public List<DocumentsAccounting> documents = new List<DocumentsAccounting>();
        string path = @"C:/Users/ThinkBook/source/repos/Labb2/Report.bin";


        const string my_surname = "Volkov";
        const string my_name = "Artem";
        const string my_ot = "Evgenevich";

        private byte[] calcucateSignature(string surname, string name, string ot)
        {
            byte[] signature = new byte[24];
            for (int i = 0; i < 8; i++)
                if (surname.Length > i) signature[i] = (byte)surname[i];
            for (int i = 0; i < 8; i++)
                if (name.Length > i) signature[i + 8] = (byte)name[i];
            for (int i = 0; i < 8; i++)
                if (ot.Length > i) signature[i + 16] = (byte)ot[i];
                else { signature[i + 16] = 00000000; }
            return signature;
        }
        public FileDataSource(string path)
        {
            byte[] signature = calcucateSignature(my_surname, my_name, my_ot);
            if (!(File.Exists(path)))
            { // Создание файла
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    writer.Write(signature);
                }
            }
            else // Чтение файла
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    for (int i = 0; i < 24; i++)
                    {
                        if (reader.ReadByte() != signature[i]) throw new Exception("Данная сигнатура является ложной!");
                    }
                    while (reader.PeekChar() > -1)
                    {
                        bool isDeleted = reader.ReadBoolean();
                        byte type_record = reader.ReadByte();
                        int id = reader.ReadInt32();
                        string name = reader.ReadString();
                        DateTime dateAdd = new DateTime(reader.ReadInt64());
                        DateTime dateClose = new DateTime(reader.ReadInt64());
                        string description = reader.ReadString();
                        int count = reader.ReadInt32(); Console.WriteLine(count);
                        if (type_record == 0)
                        {
                            double area = reader.ReadDouble();

                            documents.Add(new Realty(id, isDeleted, type_record, name, dateAdd, dateClose, description, area, count));
                        }
                        else
                        {
                            string model = reader.ReadString();
                            documents.Add(new Auto(id, isDeleted, type_record, name, dateAdd, dateClose, description, model, count));
                        }
                    }
                }
            }

        }
        public DocumentsAccounting Get(int id)
        {
            foreach (DocumentsAccounting record in documents)
                if (record.Id == id) return record;
            throw new Exception("Такого документа нет в списке");
        }
        public DocumentsAccounting Save(DocumentsAccounting record)
        {
            if (record.Id == 0)
            {
                record.Id = documents.Count + 1;

                this.documents.Add(record);
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Append)))
                {
                    writer.Write(record.isDeleted); // bool
                    writer.Write(record.type_record); // byte 
                    writer.Write(record.Id);
                    writer.Write(record.Name);
                    writer.Write(record.getDateStart().Ticks);
                    writer.Write(record.getDateEnd().Ticks);
                    writer.Write(record.Description);
                    if (record.type_record == 0)
                    {
                        writer.Write(counterRealty++); // int
                        writer.Write(((Realty)record).getArea());
                    }
                    else
                    {
                        writer.Write(counterAuto++); // int
                        writer.Write(((Auto)record).getModel());
                    }

                }
            }
            else { 
                for (int i = 0; i < documents.Count; i++)
                    {
                        // Обновление записи
                        if (documents[i].Id == record.Id)
                        {
                            documents[i] = record;
                            return record;
                        }
                    }
            }
            //throw new Exception("Такой записи не найдено");

            return record;
        }
        public bool Delete(int id)
        {
            for (int i = 0; i < documents.Count; i++)
            {
                if (documents[i].Id == id)
                {
                    documents.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public List<DocumentsAccounting> GetAll()
        {
            DocumentsAccounting[] arr = documents.ToArray();
            Array.Sort(arr);
            return new List<DocumentsAccounting>(arr);
        }
    }

    public class BusinessLogic
    {
        private IDataSource dataSource;

        public BusinessLogic(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public List<DocumentsAccounting> GetList()
        {
            List<DocumentsAccounting> list = dataSource.GetAll();

            var sortedList = list.OrderBy(x => x.DateAdd).ThenBy(x => x.Name).ToList();

            return sortedList;
        }
        public DocumentsAccounting AddRecord(DocumentsAccounting document)
        {
            int comp = document.DateAdd.CompareTo(document.DateClose);
            if (comp <= 0)
            {
                dataSource.Save(document);
            }
            else throw new ArgumentException("Дата завершения меньше или равна дате начала ");
            return document;
        }
        public DocumentsAccounting ChangeRecord(DocumentsAccounting document)
        {
            int comp = document.DateAdd.CompareTo(document.DateClose);
            if (comp <= 0)
            {
                dataSource.Save(document);
            }
            else throw new ArgumentException("Дата завершения меньше или равна дате начала ");
            return document;
        }
        public DocumentsAccounting Save(DocumentsAccounting record)
        {
            dataSource.Save(record);
            return record;
        }
        public DocumentsAccounting Get(int id)
        {
            return dataSource.Get(id);
        }
        public bool DeleteRecord(int id)
        {
            return dataSource.Delete(id);
        }
        public void GenerateReport(string path, int date_start, int date_end)
        {
            List<DocumentsAccounting> all_records = dataSource.GetAll(); DocumentsAccounting ord;
            List<DocumentsAccounting> records = new List<DocumentsAccounting>();
            for (int i = 0; i < all_records.Count; i++)
            {
                ord = all_records[i];
                if (date_end - date_start >= Convert.ToInt32((ord.getDateEnd() - ord.getDateStart()).Days)) records.Add(ord);
            }
            // Генерация отчета
            using (StreamWriter sw = new StreamWriter($"{path}", false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Отчет\n Длительность: " + date_start + " - " + date_end + " = " + (date_end - date_start) + "дней");

                sw.WriteLine("Общее количество документов по каждой\n" +
                    " из длительности из указанного диапазона: " + records.Count);
            }
        }

    }

    static class Program
    {

        public static BusinessLogic logic = new BusinessLogic(new FileDataSource("C:/Users/ThinkBook/source/repos/Labb2/Report.bin"));
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        DocumentsAccounting document;
        public Form2()
        {
            InitializeComponent();

        }

        public Form2(int index)
        {
            InitializeComponent();
            document = Program.logic.GetList()[index];
            Data_Name.Text = document.Name;
            Data_date_from.Value = document.getDateStart();
            Data_date_to.Value = document.getDateEnd();
            Description.Text = document.Description.ToString();
            if (radioButton1.Checked = true && document.type_record == 0)
            {
                radioButton2.Checked = false;
                Data_Area.Text = ((Realty)document).getArea().ToString();
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
                Data_Model.Text = ((Auto)document).getModel().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            string name = Data_Name.Text;
            DateTime date_from = Data_date_from.Value;
            DateTime date_to = Data_date_to.Value;
            if (date_to < date_from)
            {
                MessageBox.Show("Вы указали неправильную дату!");
                return;
            }
            string description;
            try { description = Description.Text; }
            catch
            {
                MessageBox.Show("Недопустимые символы в поле описания!");
                return;
            }
            Double.TryParse(Data_Area.Text, out double Area);
            string Model = Data_Model.Text;
            if (Data_Area.Enabled)
            {
                if (name == "" || Area == 0)
                {
                    MessageBox.Show("Вы не заполнили одно или несколько полей!");
                    return;
                }
            }
            else
            {
                if (name == "" || Model == "")
                {
                    MessageBox.Show("Вы не заполнили одно или несколько полей!");
                    return;
                }
            }
            if (document==null)
            {
                if (Data_Area.Enabled)
                {
                    DocumentsAccounting new_record = new Realty(0, false, 0, name, date_from, date_to, description, Area, 1);
                    Program.logic.Save(new_record);
                }
                else
                {
                    Program.logic.Save(new Auto(0, false, 1, name, date_from, date_to, description, Model, 1));
                }
            }
            else { 
                // Обновление записи
                if (Data_Area.Enabled)
                {
                    DocumentsAccounting new_record = new Realty(document.Id, false, 0, name, date_from, date_to, description, Area, 1);
                    Program.logic.Save(new_record);
                }
                else
                {
                    Program.logic.Save(new Auto(document.Id, false, 1, name, date_from, date_to, description, Model, 1));
                }
            }

            MessageBox.Show("Запись добавлена!");
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Data_Area.Enabled = true;
            Data_Model.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Data_Area.Enabled = false;
            Data_Model.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Data_date_from_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Data_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Data_date_to_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

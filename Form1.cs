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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            up_orders();
            Delete_btn.Enabled = false;
            Change_btn.Enabled = false;
        }

        private void up_orders()
        {
            Documents.SelectedIndex = -1;
            Delete_btn.Enabled = false;
            Change_btn.Enabled = false;
            Documents.Items.Clear();
            List<string> items = new List<string>();
            foreach (DocumentsAccounting ord in Program.logic.GetList())
            {
                items.Add(ord.Name + ", " + ord.getDateStart() + " - " + ord.getDateEnd() + ", " + ord.getCount());
            }
            Documents.Items.AddRange(items.ToArray());
        }
        private void Orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delete_btn.Enabled = true;
            Change_btn.Enabled = true;
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            Form2 AddChangeForm = new Form2();
            AddChangeForm.ShowDialog();
            up_orders();
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            int index = Documents.SelectedIndex;
            Form2 AddChangeForm = new Form2(index);
            AddChangeForm.ShowDialog();
            up_orders();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            int index = Documents.SelectedIndex;
            DocumentsAccounting acc = Program.logic.GetList()[index];
            DialogResult res = MessageBox.Show(
                "Вы точно хотите удалить данную запись?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Program.logic.DeleteRecord(acc.Id);
                MessageBox.Show("Запись успешна удалена!");
            }
            up_orders();
        }

        private void Generate_btn_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (svd.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = svd.FileName;
            // сохраняем текст в файл
            Program.logic.GenerateReport(filename, int.Parse(durationFrom.Text) , int.Parse(durationTo.Text));
            MessageBox.Show("Отчет сохранен");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void durationFrom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

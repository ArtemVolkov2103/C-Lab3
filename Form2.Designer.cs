
namespace lab3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Data_Name = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Data_Area = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Data_Model = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Data_date_to = new System.Windows.Forms.DateTimePicker();
            this.Data_date_from = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип документа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(146, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название документа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(146, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата начала";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(149, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата завершения";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(146, 495);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Описание";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1062, 212);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(160, 29);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Недвижимость";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(777, 214);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(161, 29);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Автотранспорт";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(774, 593);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Модель транспортного средства";
            // 
            // Data_Name
            // 
            this.Data_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Data_Name.Location = new System.Drawing.Point(657, 286);
            this.Data_Name.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Data_Name.Name = "Data_Name";
            this.Data_Name.Size = new System.Drawing.Size(552, 35);
            this.Data_Name.TabIndex = 9;
            this.Data_Name.TextChanged += new System.EventHandler(this.Data_Name_TextChanged);
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Description.Location = new System.Drawing.Point(657, 495);
            this.Description.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(549, 35);
            this.Description.TabIndex = 12;
            // 
            // Data_Area
            // 
            this.Data_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Data_Area.Location = new System.Drawing.Point(143, 658);
            this.Data_Area.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Data_Area.Name = "Data_Area";
            this.Data_Area.Size = new System.Drawing.Size(432, 35);
            this.Data_Area.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(774, 864);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 76);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(358, 864);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 76);
            this.button2.TabIndex = 16;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(146, 593);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Площадь помещения";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Data_Model
            // 
            this.Data_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Data_Model.Location = new System.Drawing.Point(774, 658);
            this.Data_Model.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Data_Model.Name = "Data_Model";
            this.Data_Model.Size = new System.Drawing.Size(432, 35);
            this.Data_Model.TabIndex = 18;
            this.Data_Model.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Count.Location = new System.Drawing.Point(777, 770);
            this.Count.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(432, 35);
            this.Count.TabIndex = 19;
            this.Count.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(146, 776);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(358, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Количество копий документа";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(444, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 37);
            this.label9.TabIndex = 21;
            this.label9.Text = "Заполнение данных ";
            // 
            // Data_date_to
            // 
            this.Data_date_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Data_date_to.Location = new System.Drawing.Point(660, 413);
            this.Data_date_to.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Data_date_to.Name = "Data_date_to";
            this.Data_date_to.Size = new System.Drawing.Size(549, 35);
            this.Data_date_to.TabIndex = 11;
            this.Data_date_to.ValueChanged += new System.EventHandler(this.Data_date_to_ValueChanged);
            // 
            // Data_date_from
            // 
            this.Data_date_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Data_date_from.Location = new System.Drawing.Point(657, 345);
            this.Data_date_from.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Data_date_from.Name = "Data_date_from";
            this.Data_date_from.Size = new System.Drawing.Size(549, 35);
            this.Data_date_from.TabIndex = 10;
            this.Data_date_from.ValueChanged += new System.EventHandler(this.Data_date_from_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1578, 1050);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Data_Model);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Data_Area);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Data_date_to);
            this.Controls.Add(this.Data_date_from);
            this.Controls.Add(this.Data_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.MinimumSize = new System.Drawing.Size(1600, 1018);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;//заполнение данных
        private System.Windows.Forms.Label label1;//тип документа
        private System.Windows.Forms.Label label2;//Название документа
        private System.Windows.Forms.Label label3;//дата начала
        private System.Windows.Forms.Label label4;//дата завершения
        private System.Windows.Forms.Label label5;//описание
        private System.Windows.Forms.RadioButton radioButton1;//недвижимость
        private System.Windows.Forms.RadioButton radioButton2;//Автотранспорт
        private System.Windows.Forms.TextBox Data_Name;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Data_Area;
        private System.Windows.Forms.Label label6;//Площадь помещения
        private System.Windows.Forms.Label label7;//Модель транспортного средства
        private System.Windows.Forms.TextBox Data_Model;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Label label8;//Количество копий документа
        private System.Windows.Forms.Button button1;//сохранить
        private System.Windows.Forms.Button button2;//отмена
        private System.Windows.Forms.DateTimePicker Data_date_to;
        private System.Windows.Forms.DateTimePicker Data_date_from;
    }
}

namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Documents = new System.Windows.Forms.ListBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Change_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Generate_btn = new System.Windows.Forms.Button();
            this.durationFrom = new System.Windows.Forms.TextBox();
            this.durationTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Documents
            // 
            this.Documents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Documents.FormattingEnabled = true;
            this.Documents.ItemHeight = 28;
            this.Documents.Location = new System.Drawing.Point(336, 102);
            this.Documents.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Documents.Name = "Documents";
            this.Documents.Size = new System.Drawing.Size(638, 200);
            this.Documents.TabIndex = 0;
            this.Documents.SelectedIndexChanged += new System.EventHandler(this.Orders_SelectedIndexChanged);
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_btn.Location = new System.Drawing.Point(1030, 374);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(273, 54);
            this.Add_btn.TabIndex = 1;
            this.Add_btn.Text = "Добавить";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Change_btn
            // 
            this.Change_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Change_btn.Location = new System.Drawing.Point(547, 374);
            this.Change_btn.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.Size = new System.Drawing.Size(270, 54);
            this.Change_btn.TabIndex = 2;
            this.Change_btn.Text = "Изменить";
            this.Change_btn.UseVisualStyleBackColor = true;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete_btn.Location = new System.Drawing.Point(94, 374);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(197, 54);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "Удалить";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(639, 524);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Отчет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 589);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Длительность от";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(94, 653);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Длительность до";
            // 
            // Generate_btn
            // 
            this.Generate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Generate_btn.Location = new System.Drawing.Point(483, 746);
            this.Generate_btn.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Generate_btn.Name = "Generate_btn";
            this.Generate_btn.Size = new System.Drawing.Size(400, 58);
            this.Generate_btn.TabIndex = 9;
            this.Generate_btn.Text = "Генерировать отчет";
            this.Generate_btn.UseVisualStyleBackColor = true;
            this.Generate_btn.Click += new System.EventHandler(this.Generate_btn_Click);
            // 
            // durationFrom
            // 
            this.durationFrom.Location = new System.Drawing.Point(560, 589);
            this.durationFrom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.durationFrom.Name = "durationFrom";
            this.durationFrom.Size = new System.Drawing.Size(681, 31);
            this.durationFrom.TabIndex = 10;
            this.durationFrom.TextChanged += new System.EventHandler(this.durationFrom_TextChanged);
            // 
            // durationTo
            // 
            this.durationTo.Location = new System.Drawing.Point(560, 650);
            this.durationTo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.durationTo.Name = "durationTo";
            this.durationTo.Size = new System.Drawing.Size(681, 31);
            this.durationTo.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1578, 1050);
            this.Controls.Add(this.durationTo);
            this.Controls.Add(this.durationFrom);
            this.Controls.Add(this.Generate_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Change_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Documents);
            this.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.MinimumSize = new System.Drawing.Size(1300, 1018);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет документов ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Documents;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Change_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Generate_btn;
        private System.Windows.Forms.TextBox durationFrom;
        private System.Windows.Forms.TextBox durationTo;
    }
}


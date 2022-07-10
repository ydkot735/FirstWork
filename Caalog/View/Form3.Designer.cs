namespace Caalog.View
{
    partial class Form3
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.start_prog = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Catalog_Label = new System.Windows.Forms.Label();
            this.MIn_Max_Label = new System.Windows.Forms.Label();
            this.RAMLIST_Label = new System.Windows.Forms.Label();
            this.back_label_form3 = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenDlg = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(282, 518);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // start_prog
            // 
            this.start_prog.AutoSize = true;
            this.start_prog.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.start_prog.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_prog.ForeColor = System.Drawing.Color.Black;
            this.start_prog.Location = new System.Drawing.Point(858, 367);
            this.start_prog.Name = "start_prog";
            this.start_prog.Size = new System.Drawing.Size(93, 39);
            this.start_prog.TabIndex = 1;
            this.start_prog.Text = "Пуск";
            this.start_prog.Click += new System.EventHandler(this.start_prog_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(606, 31);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(366, 237);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(300, 31);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(300, 518);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            // 
            // Catalog_Label
            // 
            this.Catalog_Label.AutoSize = true;
            this.Catalog_Label.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Catalog_Label.ForeColor = System.Drawing.Color.Black;
            this.Catalog_Label.Location = new System.Drawing.Point(107, 9);
            this.Catalog_Label.Name = "Catalog_Label";
            this.Catalog_Label.Size = new System.Drawing.Size(60, 15);
            this.Catalog_Label.TabIndex = 4;
            this.Catalog_Label.Text = "Каталог";
            // 
            // MIn_Max_Label
            // 
            this.MIn_Max_Label.AutoSize = true;
            this.MIn_Max_Label.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MIn_Max_Label.Location = new System.Drawing.Point(666, 13);
            this.MIn_Max_Label.Name = "MIn_Max_Label";
            this.MIn_Max_Label.Size = new System.Drawing.Size(260, 15);
            this.MIn_Max_Label.TabIndex = 5;
            this.MIn_Max_Label.Text = "Самая дорогая и самая дешевая модель";
            this.MIn_Max_Label.UseMnemonic = false;
            // 
            // RAMLIST_Label
            // 
            this.RAMLIST_Label.AutoSize = true;
            this.RAMLIST_Label.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAMLIST_Label.ForeColor = System.Drawing.Color.Black;
            this.RAMLIST_Label.Location = new System.Drawing.Point(347, 13);
            this.RAMLIST_Label.Name = "RAMLIST_Label";
            this.RAMLIST_Label.Size = new System.Drawing.Size(194, 15);
            this.RAMLIST_Label.TabIndex = 6;
            this.RAMLIST_Label.Text = "Каталог по увеличению ОЗУ";
            // 
            // back_label_form3
            // 
            this.back_label_form3.AutoSize = true;
            this.back_label_form3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.back_label_form3.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_label_form3.ForeColor = System.Drawing.Color.Black;
            this.back_label_form3.Location = new System.Drawing.Point(675, 465);
            this.back_label_form3.Name = "back_label_form3";
            this.back_label_form3.Size = new System.Drawing.Size(276, 39);
            this.back_label_form3.TabIndex = 7;
            this.back_label_form3.Text = "Вернуться назад";
            this.back_label_form3.Click += new System.EventHandler(this.back_label_form3_Click);
            // 
            // Save_button
            // 
            this.Save_button.AutoSize = true;
            this.Save_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Save_button.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.ForeColor = System.Drawing.Color.Black;
            this.Save_button.Location = new System.Drawing.Point(766, 416);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(185, 39);
            this.Save_button.TabIndex = 8;
            this.Save_button.Text = "Сохранить";
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 275);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(366, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Открыть файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenDlg
            // 
            this.OpenDlg.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.back_label_form3);
            this.Controls.Add(this.RAMLIST_Label);
            this.Controls.Add(this.MIn_Max_Label);
            this.Controls.Add(this.Catalog_Label);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.start_prog);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form3";
            this.Text = "Каталог";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label start_prog;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label Catalog_Label;
        private System.Windows.Forms.Label MIn_Max_Label;
        private System.Windows.Forms.Label RAMLIST_Label;
        private System.Windows.Forms.Label back_label_form3;
        private System.Windows.Forms.Label Save_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog OpenDlg;
    }
}
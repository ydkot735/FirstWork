namespace Caalog.View
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
            this.Info1 = new System.Windows.Forms.Label();
            this.Info2 = new System.Windows.Forms.Label();
            this.Info3 = new System.Windows.Forms.Label();
            this.Back_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.BackColor = System.Drawing.Color.Black;
            this.Info1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Info1.Location = new System.Drawing.Point(279, 247);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(446, 19);
            this.Info1.TabIndex = 0;
            this.Info1.Text = "Курсовая работа по дисциплине \"Программирование\"";
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.BackColor = System.Drawing.Color.Black;
            this.Info2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Info2.Location = new System.Drawing.Point(279, 266);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(527, 19);
            this.Info2.TabIndex = 1;
            this.Info2.Text = "Разработка приложения с графическим интерфейсом \"Каталог\"";
            // 
            // Info3
            // 
            this.Info3.AutoSize = true;
            this.Info3.BackColor = System.Drawing.Color.Black;
            this.Info3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Info3.Location = new System.Drawing.Point(279, 285);
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(388, 19);
            this.Info3.TabIndex = 2;
            this.Info3.Text = "Автор: студент группы БИТ 20-11 Котыбаев Е. С.";
            // 
            // Back_Label
            // 
            this.Back_Label.AutoSize = true;
            this.Back_Label.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Back_Label.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Label.ForeColor = System.Drawing.Color.Black;
            this.Back_Label.Location = new System.Drawing.Point(359, 474);
            this.Back_Label.Name = "Back_Label";
            this.Back_Label.Size = new System.Drawing.Size(276, 39);
            this.Back_Label.TabIndex = 3;
            this.Back_Label.Text = "Вернуться назад";
            this.Back_Label.Click += new System.EventHandler(this.Back_Label_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Back_Label);
            this.Controls.Add(this.Info3);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Info1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.Label Info3;
        private System.Windows.Forms.Label Back_Label;
    }
}
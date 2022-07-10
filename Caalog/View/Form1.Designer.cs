namespace Caalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Welcome_Label = new System.Windows.Forms.Label();
            this.Start_Label = new System.Windows.Forms.Label();
            this.Exit_Label = new System.Windows.Forms.Label();
            this.Info_Label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_university = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome_Label
            // 
            this.Welcome_Label.AutoSize = true;
            this.Welcome_Label.Font = new System.Drawing.Font("Constantia", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcome_Label.Location = new System.Drawing.Point(385, 21);
            this.Welcome_Label.Name = "Welcome_Label";
            this.Welcome_Label.Size = new System.Drawing.Size(202, 55);
            this.Welcome_Label.TabIndex = 0;
            this.Welcome_Label.Text = "Каталог";
            // 
            // Start_Label
            // 
            this.Start_Label.AutoSize = true;
            this.Start_Label.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_Label.Location = new System.Drawing.Point(146, 32);
            this.Start_Label.Name = "Start_Label";
            this.Start_Label.Size = new System.Drawing.Size(105, 33);
            this.Start_Label.TabIndex = 1;
            this.Start_Label.Text = "Запуск";
            this.Start_Label.Click += new System.EventHandler(this.Start_Label_Click);
            this.Start_Label.MouseLeave += new System.EventHandler(this.Start_Label_MouseLeave);
            this.Start_Label.MouseHover += new System.EventHandler(this.Start_Label_MouseHover);
            // 
            // Exit_Label
            // 
            this.Exit_Label.AutoSize = true;
            this.Exit_Label.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Label.Location = new System.Drawing.Point(734, 32);
            this.Exit_Label.Name = "Exit_Label";
            this.Exit_Label.Size = new System.Drawing.Size(98, 33);
            this.Exit_Label.TabIndex = 2;
            this.Exit_Label.Text = "Выход";
            this.Exit_Label.Click += new System.EventHandler(this.Exit_Label_Click);
            this.Exit_Label.MouseHover += new System.EventHandler(this.Exit_Label_MouseHover);
            // 
            // Info_Label
            // 
            this.Info_Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Info_Label.AutoSize = true;
            this.Info_Label.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Info_Label.Location = new System.Drawing.Point(387, 32);
            this.Info_Label.Name = "Info_Label";
            this.Info_Label.Size = new System.Drawing.Size(194, 33);
            this.Info_Label.TabIndex = 3;
            this.Info_Label.Text = "Информация";
            this.Info_Label.Click += new System.EventHandler(this.Info_Label_Click);
            this.Info_Label.MouseHover += new System.EventHandler(this.Info_Label_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.Start_Label);
            this.panel1.Controls.Add(this.Info_Label);
            this.panel1.Controls.Add(this.Exit_Label);
            this.panel1.Location = new System.Drawing.Point(2, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 88);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 299);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Location = new System.Drawing.Point(56, 496);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(540, 13);
            this.label_university.TabIndex = 6;
            this.label_university.Text = "ФГБОУ ВО «Сибирский государственный университет имени М.Ф. Решетнева» Лесосибирск" +
    "ий филиал";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Welcome_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Стартовое окно";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.Label Start_Label;
        private System.Windows.Forms.Label Exit_Label;
        private System.Windows.Forms.Label Info_Label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_university;
    }
}


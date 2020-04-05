namespace DeadLineApp
{
    partial class FormAdd
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
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelAdvice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(106, 77);
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(218, 46);
            this.textBoxDate.TabIndex = 0;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelAdvice
            // 
            this.labelAdvice.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdvice.Location = new System.Drawing.Point(103, 36);
            this.labelAdvice.Name = "labelAdvice";
            this.labelAdvice.Size = new System.Drawing.Size(221, 38);
            this.labelAdvice.TabIndex = 3;
            this.labelAdvice.Text = "Впишите дату Дедлайна ! Пример: \"10 03 2020\" ";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Время Дедлайна:";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(217, 134);
            this.textBoxHours.Multiline = true;
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(41, 23);
            this.textBoxHours.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(285, 134);
            this.textBoxMinutes.Multiline = true;
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(39, 23);
            this.textBoxMinutes.TabIndex = 7;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 199);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAdvice);
            this.Controls.Add(this.textBoxDate);
            this.Name = "FormAdd";
            this.Text = "Добавление Этапа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAdvice;
        public System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxHours;
        public System.Windows.Forms.TextBox textBoxMinutes;
    }
}
namespace DeadLineApp
{
    partial class FormDeadLine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeadLine));
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxDeadLine = new System.Windows.Forms.ListBox();
            this.buttonWindowAdd = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timerDeadLine = new System.Windows.Forms.Timer(this.components);
            this.labelTIme = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelInfo.Location = new System.Drawing.Point(529, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(187, 26);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Этапы дедлайна.";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(539, 466);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(172, 28);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить Этап ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxDeadLine
            // 
            this.listBoxDeadLine.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDeadLine.FormattingEnabled = true;
            this.listBoxDeadLine.ItemHeight = 23;
            this.listBoxDeadLine.Location = new System.Drawing.Point(534, 42);
            this.listBoxDeadLine.Name = "listBoxDeadLine";
            this.listBoxDeadLine.Size = new System.Drawing.Size(177, 418);
            this.listBoxDeadLine.TabIndex = 4;
            this.listBoxDeadLine.SelectedIndexChanged += new System.EventHandler(this.listBoxDeadLine_SelectedIndexChanged);
            // 
            // buttonWindowAdd
            // 
            this.buttonWindowAdd.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWindowAdd.Location = new System.Drawing.Point(539, 500);
            this.buttonWindowAdd.Name = "buttonWindowAdd";
            this.buttonWindowAdd.Size = new System.Drawing.Size(172, 40);
            this.buttonWindowAdd.TabIndex = 5;
            this.buttonWindowAdd.Text = "Открыть Окно Добавления";
            this.buttonWindowAdd.UseVisualStyleBackColor = true;
            this.buttonWindowAdd.Click += new System.EventHandler(this.buttonWindowAdd_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(0, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // timerDeadLine
            // 
            this.timerDeadLine.Tick += new System.EventHandler(this.timerDeadLine_Tick);
            // 
            // labelTIme
            // 
            this.labelTIme.AutoSize = true;
            this.labelTIme.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTIme.Location = new System.Drawing.Point(-4, 478);
            this.labelTIme.Name = "labelTIme";
            this.labelTIme.Size = new System.Drawing.Size(0, 23);
            this.labelTIme.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(887, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 72);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDeadLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTIme);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonWindowAdd);
            this.Controls.Add(this.listBoxDeadLine);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormDeadLine";
            this.Text = "DeadLine Calender";
            this.Load += new System.EventHandler(this.FormDeadLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInfo;
        public System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.ListBox listBoxDeadLine;
        private System.Windows.Forms.Button buttonWindowAdd;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timerDeadLine;
        private System.Windows.Forms.Label labelTIme;
        private System.Windows.Forms.Button button1;
    }
}


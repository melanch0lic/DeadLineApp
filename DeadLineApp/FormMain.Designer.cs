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
            this.monthCalendarDeadLine = new System.Windows.Forms.MonthCalendar();
            this.timerDeadLine = new System.Windows.Forms.Timer(this.components);
            this.labelTIme = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBoxNameEdit = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelInfoStep = new System.Windows.Forms.Label();
            this.textBoxDateEdit = new System.Windows.Forms.TextBox();
            this.textBoxHoursEdit = new System.Windows.Forms.TextBox();
            this.textBoxMinutesEdit = new System.Windows.Forms.TextBox();
            this.labelEd = new System.Windows.Forms.Label();
            this.labelNameEdit = new System.Windows.Forms.Label();
            this.labelDateEdit = new System.Windows.Forms.Label();
            this.labelTimeEdit = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.listBoxDeadLine.BackColor = System.Drawing.Color.Azure;
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
            // monthCalendarDeadLine
            // 
            this.monthCalendarDeadLine.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendarDeadLine.Location = new System.Drawing.Point(0, 9);
            this.monthCalendarDeadLine.Name = "monthCalendarDeadLine";
            this.monthCalendarDeadLine.TabIndex = 6;
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
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp.BackgroundImage")));
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHelp.Location = new System.Drawing.Point(870, 9);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(97, 86);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNameEdit
            // 
            this.textBoxNameEdit.Enabled = false;
            this.textBoxNameEdit.Location = new System.Drawing.Point(837, 318);
            this.textBoxNameEdit.Multiline = true;
            this.textBoxNameEdit.Name = "textBoxNameEdit";
            this.textBoxNameEdit.Size = new System.Drawing.Size(107, 27);
            this.textBoxNameEdit.TabIndex = 9;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(722, 416);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(222, 32);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "РЕДАКТИРОВАТЬ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelInfoStep
            // 
            this.labelInfoStep.BackColor = System.Drawing.Color.Transparent;
            this.labelInfoStep.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoStep.ForeColor = System.Drawing.Color.Snow;
            this.labelInfoStep.Location = new System.Drawing.Point(717, 287);
            this.labelInfoStep.Name = "labelInfoStep";
            this.labelInfoStep.Size = new System.Drawing.Size(264, 28);
            this.labelInfoStep.TabIndex = 11;
            this.labelInfoStep.Text = "Информация об Этапе.";
            // 
            // textBoxDateEdit
            // 
            this.textBoxDateEdit.Location = new System.Drawing.Point(837, 351);
            this.textBoxDateEdit.Multiline = true;
            this.textBoxDateEdit.Name = "textBoxDateEdit";
            this.textBoxDateEdit.Size = new System.Drawing.Size(107, 27);
            this.textBoxDateEdit.TabIndex = 12;
            // 
            // textBoxHoursEdit
            // 
            this.textBoxHoursEdit.Location = new System.Drawing.Point(837, 384);
            this.textBoxHoursEdit.Multiline = true;
            this.textBoxHoursEdit.Name = "textBoxHoursEdit";
            this.textBoxHoursEdit.Size = new System.Drawing.Size(39, 26);
            this.textBoxHoursEdit.TabIndex = 13;
            // 
            // textBoxMinutesEdit
            // 
            this.textBoxMinutesEdit.Location = new System.Drawing.Point(906, 384);
            this.textBoxMinutesEdit.Multiline = true;
            this.textBoxMinutesEdit.Name = "textBoxMinutesEdit";
            this.textBoxMinutesEdit.Size = new System.Drawing.Size(38, 26);
            this.textBoxMinutesEdit.TabIndex = 14;
            // 
            // labelEd
            // 
            this.labelEd.AutoSize = true;
            this.labelEd.BackColor = System.Drawing.Color.Transparent;
            this.labelEd.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEd.Location = new System.Drawing.Point(882, 384);
            this.labelEd.Name = "labelEd";
            this.labelEd.Size = new System.Drawing.Size(18, 26);
            this.labelEd.TabIndex = 15;
            this.labelEd.Text = ":";
            // 
            // labelNameEdit
            // 
            this.labelNameEdit.BackColor = System.Drawing.Color.Transparent;
            this.labelNameEdit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameEdit.ForeColor = System.Drawing.Color.Snow;
            this.labelNameEdit.Location = new System.Drawing.Point(718, 321);
            this.labelNameEdit.Name = "labelNameEdit";
            this.labelNameEdit.Size = new System.Drawing.Size(113, 24);
            this.labelNameEdit.TabIndex = 16;
            this.labelNameEdit.Text = "НАЗВАНИЕ:";
            // 
            // labelDateEdit
            // 
            this.labelDateEdit.BackColor = System.Drawing.Color.Transparent;
            this.labelDateEdit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateEdit.ForeColor = System.Drawing.Color.Snow;
            this.labelDateEdit.Location = new System.Drawing.Point(768, 354);
            this.labelDateEdit.Name = "labelDateEdit";
            this.labelDateEdit.Size = new System.Drawing.Size(63, 24);
            this.labelDateEdit.TabIndex = 17;
            this.labelDateEdit.Text = "ДАТА:";
            // 
            // labelTimeEdit
            // 
            this.labelTimeEdit.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeEdit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeEdit.ForeColor = System.Drawing.Color.Snow;
            this.labelTimeEdit.Location = new System.Drawing.Point(754, 384);
            this.labelTimeEdit.Name = "labelTimeEdit";
            this.labelTimeEdit.Size = new System.Drawing.Size(77, 26);
            this.labelTimeEdit.TabIndex = 18;
            this.labelTimeEdit.Text = "ВРЕМЯ:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(722, 454);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(222, 40);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить Этап";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormDeadLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(979, 546);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelTimeEdit);
            this.Controls.Add(this.labelDateEdit);
            this.Controls.Add(this.labelNameEdit);
            this.Controls.Add(this.labelEd);
            this.Controls.Add(this.textBoxMinutesEdit);
            this.Controls.Add(this.textBoxHoursEdit);
            this.Controls.Add(this.textBoxDateEdit);
            this.Controls.Add(this.labelInfoStep);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxNameEdit);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelTIme);
            this.Controls.Add(this.monthCalendarDeadLine);
            this.Controls.Add(this.buttonWindowAdd);
            this.Controls.Add(this.listBoxDeadLine);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelInfo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.MonthCalendar monthCalendarDeadLine;
        private System.Windows.Forms.Timer timerDeadLine;
        private System.Windows.Forms.Label labelTIme;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBoxNameEdit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelInfoStep;
        private System.Windows.Forms.TextBox textBoxDateEdit;
        private System.Windows.Forms.TextBox textBoxHoursEdit;
        private System.Windows.Forms.TextBox textBoxMinutesEdit;
        private System.Windows.Forms.Label labelEd;
        private System.Windows.Forms.Label labelNameEdit;
        private System.Windows.Forms.Label labelDateEdit;
        private System.Windows.Forms.Label labelTimeEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}


namespace Calendar.FormForCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerStart = new System.Windows.Forms.DateTimePicker();
            this.chkBoxEveryYear = new System.Windows.Forms.CheckBox();
            this.chkBoxAllDay = new System.Windows.Forms.CheckBox();
            this.groupBoxReminder = new System.Windows.Forms.GroupBox();
            this.dtPickerReminder = new System.Windows.Forms.DateTimePicker();
            this.chkBoxRemind = new System.Windows.Forms.CheckBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxReminder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название:";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(91, 34);
            this.txtBoxTitle.MaxLength = 20;
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(163, 20);
            this.txtBoxTitle.TabIndex = 2;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.dtPickerEnd);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Controls.Add(this.dtPickerStart);
            this.groupBoxInfo.Controls.Add(this.chkBoxEveryYear);
            this.groupBoxInfo.Controls.Add(this.chkBoxAllDay);
            this.groupBoxInfo.Controls.Add(this.txtBoxTitle);
            this.groupBoxInfo.Controls.Add(this.lblTitle);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(260, 224);
            this.groupBoxInfo.TabIndex = 3;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация о событии:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата и время конца:";
            // 
            // dtPickerEnd
            // 
            this.dtPickerEnd.CustomFormat = " HH:mm   (dd.MM.yy)";
            this.dtPickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerEnd.Location = new System.Drawing.Point(126, 125);
            this.dtPickerEnd.Name = "dtPickerEnd";
            this.dtPickerEnd.Size = new System.Drawing.Size(128, 20);
            this.dtPickerEnd.TabIndex = 8;
            this.dtPickerEnd.ValueChanged += new System.EventHandler(this.DtPickerTimeStartOrEnd_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата и время начала:";
            // 
            // dtPickerStart
            // 
            this.dtPickerStart.CustomFormat = " HH:mm   (dd.MM.yy)";
            this.dtPickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerStart.Location = new System.Drawing.Point(126, 99);
            this.dtPickerStart.Name = "dtPickerStart";
            this.dtPickerStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtPickerStart.Size = new System.Drawing.Size(128, 20);
            this.dtPickerStart.TabIndex = 6;
            this.dtPickerStart.Value = new System.DateTime(2023, 5, 28, 17, 18, 0, 0);
            this.dtPickerStart.ValueChanged += new System.EventHandler(this.DtPickerTimeStartOrEnd_ValueChanged);
            // 
            // chkBoxEveryYear
            // 
            this.chkBoxEveryYear.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxEveryYear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxEveryYear.Location = new System.Drawing.Point(57, 182);
            this.chkBoxEveryYear.Name = "chkBoxEveryYear";
            this.chkBoxEveryYear.Size = new System.Drawing.Size(140, 36);
            this.chkBoxEveryYear.TabIndex = 5;
            this.chkBoxEveryYear.Text = "Повторять ежегодно";
            this.chkBoxEveryYear.UseVisualStyleBackColor = true;
            // 
            // chkBoxAllDay
            // 
            this.chkBoxAllDay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxAllDay.Location = new System.Drawing.Point(57, 67);
            this.chkBoxAllDay.Name = "chkBoxAllDay";
            this.chkBoxAllDay.Size = new System.Drawing.Size(140, 26);
            this.chkBoxAllDay.TabIndex = 4;
            this.chkBoxAllDay.Text = "Весь день";
            this.chkBoxAllDay.UseVisualStyleBackColor = true;
            this.chkBoxAllDay.CheckedChanged += new System.EventHandler(this.ChkBoxAllDay_CheckedChanged);
            // 
            // groupBoxReminder
            // 
            this.groupBoxReminder.Controls.Add(this.dtPickerReminder);
            this.groupBoxReminder.Controls.Add(this.chkBoxRemind);
            this.groupBoxReminder.Location = new System.Drawing.Point(12, 242);
            this.groupBoxReminder.Name = "groupBoxReminder";
            this.groupBoxReminder.Size = new System.Drawing.Size(260, 72);
            this.groupBoxReminder.TabIndex = 4;
            this.groupBoxReminder.TabStop = false;
            this.groupBoxReminder.Text = "Напоминание:";
            // 
            // dtPickerReminder
            // 
            this.dtPickerReminder.CustomFormat = " HH:mm   (dd.MM.yy)";
            this.dtPickerReminder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerReminder.Location = new System.Drawing.Point(126, 32);
            this.dtPickerReminder.Name = "dtPickerReminder";
            this.dtPickerReminder.Size = new System.Drawing.Size(128, 20);
            this.dtPickerReminder.TabIndex = 1;
            // 
            // chkBoxRemind
            // 
            this.chkBoxRemind.Location = new System.Drawing.Point(6, 32);
            this.chkBoxRemind.Name = "chkBoxRemind";
            this.chkBoxRemind.Size = new System.Drawing.Size(113, 22);
            this.chkBoxRemind.TabIndex = 0;
            this.chkBoxRemind.Text = "Напомнить";
            this.chkBoxRemind.UseVisualStyleBackColor = true;
            this.chkBoxRemind.CheckedChanged += new System.EventHandler(this.ChkBoxRemind_CheckedChanged);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(13, 321);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(259, 28);
            this.btnAction.TabIndex = 5;
            this.btnAction.Text = "Кнопка действия";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.groupBoxReminder);
            this.Controls.Add(this.groupBoxInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма для событий";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxReminder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.CheckBox chkBoxEveryYear;
        private System.Windows.Forms.CheckBox chkBoxAllDay;
        private System.Windows.Forms.DateTimePicker dtPickerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPickerEnd;
        private System.Windows.Forms.GroupBox groupBoxReminder;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.DateTimePicker dtPickerReminder;
        private System.Windows.Forms.CheckBox chkBoxRemind;
    }
}
namespace Calendar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.yearChooser = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnToToday = new System.Windows.Forms.Button();
            this.btnToChoose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEvents = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.chkBoxSearch = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.todayStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showhideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.yearChooser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxEvents.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar.Location = new System.Drawing.Point(10, 47);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(100);
            this.monthCalendar.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // yearChooser
            // 
            this.yearChooser.Location = new System.Drawing.Point(208, 17);
            this.yearChooser.Name = "yearChooser";
            this.yearChooser.Size = new System.Drawing.Size(56, 20);
            this.yearChooser.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnToToday);
            this.groupBox1.Controls.Add(this.btnToChoose);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.yearChooser);
            this.groupBox1.Controls.Add(this.monthCalendar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 520);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Календарь";
            // 
            // btnToToday
            // 
            this.btnToToday.Location = new System.Drawing.Point(485, 17);
            this.btnToToday.Name = "btnToToday";
            this.btnToToday.Size = new System.Drawing.Size(193, 20);
            this.btnToToday.TabIndex = 5;
            this.btnToToday.Text = "Вернуться к сегодняшнему дню";
            this.btnToToday.UseVisualStyleBackColor = true;
            this.btnToToday.Click += new System.EventHandler(this.BtnToToday_Click);
            // 
            // btnToChoose
            // 
            this.btnToChoose.Location = new System.Drawing.Point(270, 17);
            this.btnToChoose.Name = "btnToChoose";
            this.btnToChoose.Size = new System.Drawing.Size(75, 20);
            this.btnToChoose.TabIndex = 4;
            this.btnToChoose.Text = "ОК";
            this.btnToChoose.UseVisualStyleBackColor = true;
            this.btnToChoose.Click += new System.EventHandler(this.BtnToChoose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите год:";
            // 
            // groupBoxEvents
            // 
            this.groupBoxEvents.Controls.Add(this.buttonSearch);
            this.groupBoxEvents.Controls.Add(this.txtBoxSearch);
            this.groupBoxEvents.Controls.Add(this.chkBoxSearch);
            this.groupBoxEvents.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxEvents.Location = new System.Drawing.Point(710, 12);
            this.groupBoxEvents.Name = "groupBoxEvents";
            this.groupBoxEvents.Size = new System.Drawing.Size(236, 474);
            this.groupBoxEvents.TabIndex = 4;
            this.groupBoxEvents.TabStop = false;
            this.groupBoxEvents.Text = "События:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(153, 41);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(77, 20);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(6, 41);
            this.txtBoxSearch.MaxLength = 20;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(141, 20);
            this.txtBoxSearch.TabIndex = 2;
            // 
            // chkBoxSearch
            // 
            this.chkBoxSearch.AutoSize = true;
            this.chkBoxSearch.Location = new System.Drawing.Point(7, 19);
            this.chkBoxSearch.Name = "chkBoxSearch";
            this.chkBoxSearch.Size = new System.Drawing.Size(111, 17);
            this.chkBoxSearch.TabIndex = 1;
            this.chkBoxSearch.Text = "Поиск по имени:";
            this.chkBoxSearch.UseVisualStyleBackColor = true;
            this.chkBoxSearch.CheckedChanged += new System.EventHandler(this.ChkBoxSearch_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(710, 492);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(236, 40);
            this.btnAddEvent.TabIndex = 6;
            this.btnAddEvent.Text = "Добавить событие";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.BtnAddEvent_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Календарь активен";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todayStripMenuItem,
            this.toolStripSeparator1,
            this.showhideToolStripMenuItem,
            this.closetoolStripMenuItem});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // todayStripMenuItem
            // 
            this.todayStripMenuItem.Name = "todayStripMenuItem";
            this.todayStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.todayStripMenuItem.Text = "Сегодня";
            this.todayStripMenuItem.Click += new System.EventHandler(this.TodayStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // showhideToolStripMenuItem
            // 
            this.showhideToolStripMenuItem.Name = "showhideToolStripMenuItem";
            this.showhideToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.showhideToolStripMenuItem.Text = "Показать/скрыть";
            this.showhideToolStripMenuItem.Click += new System.EventHandler(this.ShowHideToolStripMenuItem_Click);
            // 
            // closetoolStripMenuItem
            // 
            this.closetoolStripMenuItem.Name = "closetoolStripMenuItem";
            this.closetoolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.closetoolStripMenuItem.Text = "Отключить календарь";
            this.closetoolStripMenuItem.Click += new System.EventHandler(this.ClosetoolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 544);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.groupBoxEvents);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(974, 583);
            this.MinimumSize = new System.Drawing.Size(974, 583);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Календарь с событиями";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.yearChooser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxEvents.ResumeLayout(false);
            this.groupBoxEvents.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.NumericUpDown yearChooser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToChoose;
        private System.Windows.Forms.Button btnToToday;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showhideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem todayStripMenuItem;
        private System.Windows.Forms.CheckBox chkBoxSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}


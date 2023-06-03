using Calendar.HelpfulElements;

namespace Calendar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            monthCalendar = new MonthCalendar();
            yearChooser = new NumericUpDown();
            groupBoxCalendar = new GroupBox();
            btnToToday = new Button();
            btnToChoose = new Button();
            labelYear = new Label();
            groupBoxEvents = new GroupBox();
            tableLayoutPanel = new FlowLayoutPanel();
            buttonSearch = new Button();
            txtBoxSearch = new TextBox();
            chkBoxSearch = new CheckBox();
            btnAddEvent = new Button();
            notifyIcon = new NotifyIcon(components);
            ctxMenuForNotifyIcon = new ContextMenuStrip(components);
            todayStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            showhideToolStripMenuItem = new ToolStripMenuItem();
            closetoolStripMenuItem = new ToolStripMenuItem();
            ctxMenuForEvents = new ContextMenuStrip(components);
            удалитьСобытиеToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)yearChooser).BeginInit();
            groupBoxCalendar.SuspendLayout();
            groupBoxEvents.SuspendLayout();
            ctxMenuForNotifyIcon.SuspendLayout();
            ctxMenuForEvents.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.CalendarDimensions = new Size(4, 3);
            monthCalendar.FirstDayOfWeek = Day.Monday;
            monthCalendar.Font = new Font("Impact", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar.Location = new Point(12, 54);
            monthCalendar.Margin = new Padding(117, 115, 117, 115);
            monthCalendar.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.ShowToday = false;
            monthCalendar.TabIndex = 1;
            monthCalendar.DateChanged += Calendar_DateChanged;
            // 
            // yearChooser
            // 
            yearChooser.Location = new Point(243, 20);
            yearChooser.Margin = new Padding(4, 3, 4, 3);
            yearChooser.Name = "yearChooser";
            yearChooser.Size = new Size(65, 23);
            yearChooser.TabIndex = 2;
            // 
            // groupBoxCalendar
            // 
            groupBoxCalendar.Controls.Add(btnToToday);
            groupBoxCalendar.Controls.Add(btnToChoose);
            groupBoxCalendar.Controls.Add(labelYear);
            groupBoxCalendar.Controls.Add(yearChooser);
            groupBoxCalendar.Controls.Add(monthCalendar);
            groupBoxCalendar.Location = new Point(14, 14);
            groupBoxCalendar.Margin = new Padding(4, 3, 4, 3);
            groupBoxCalendar.Name = "groupBoxCalendar";
            groupBoxCalendar.Padding = new Padding(4, 3, 4, 3);
            groupBoxCalendar.Size = new Size(692, 527);
            groupBoxCalendar.TabIndex = 3;
            groupBoxCalendar.TabStop = false;
            groupBoxCalendar.Text = "Календарь";
            // 
            // btnToToday
            // 
            btnToToday.Location = new Point(455, 20);
            btnToToday.Margin = new Padding(4, 3, 4, 3);
            btnToToday.Name = "btnToToday";
            btnToToday.Size = new Size(225, 23);
            btnToToday.TabIndex = 5;
            btnToToday.Text = "Вернуться к сегодняшнему дню";
            btnToToday.UseVisualStyleBackColor = true;
            btnToToday.Click += BtnToToday_Click;
            // 
            // btnToChoose
            // 
            btnToChoose.Location = new Point(315, 20);
            btnToChoose.Margin = new Padding(4, 3, 4, 3);
            btnToChoose.Name = "btnToChoose";
            btnToChoose.Size = new Size(88, 23);
            btnToChoose.TabIndex = 4;
            btnToChoose.Text = "ОК";
            btnToChoose.UseVisualStyleBackColor = true;
            btnToChoose.Click += BtnToChoose_Click;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(142, 22);
            labelYear.Margin = new Padding(4, 0, 4, 0);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(85, 15);
            labelYear.TabIndex = 3;
            labelYear.Text = "Выберите год:";
            // 
            // groupBoxEvents
            // 
            groupBoxEvents.Controls.Add(tableLayoutPanel);
            groupBoxEvents.Controls.Add(buttonSearch);
            groupBoxEvents.Controls.Add(txtBoxSearch);
            groupBoxEvents.Controls.Add(chkBoxSearch);
            groupBoxEvents.Location = new Point(714, 14);
            groupBoxEvents.Margin = new Padding(4, 3, 4, 3);
            groupBoxEvents.Name = "groupBoxEvents";
            groupBoxEvents.Padding = new Padding(4, 3, 4, 3);
            groupBoxEvents.Size = new Size(275, 475);
            groupBoxEvents.TabIndex = 4;
            groupBoxEvents.TabStop = false;
            groupBoxEvents.Text = "События:";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Location = new Point(8, 76);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Size = new Size(260, 393);
            tableLayoutPanel.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(178, 47);
            buttonSearch.Margin = new Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(90, 23);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += BtnSearch_Click;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(7, 47);
            txtBoxSearch.Margin = new Padding(4, 3, 4, 3);
            txtBoxSearch.MaxLength = 20;
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(164, 23);
            txtBoxSearch.TabIndex = 2;
            // 
            // chkBoxSearch
            // 
            chkBoxSearch.AutoSize = true;
            chkBoxSearch.Location = new Point(8, 22);
            chkBoxSearch.Margin = new Padding(4, 3, 4, 3);
            chkBoxSearch.Name = "chkBoxSearch";
            chkBoxSearch.Size = new Size(120, 19);
            chkBoxSearch.TabIndex = 1;
            chkBoxSearch.Text = "Поиск по имени:";
            chkBoxSearch.UseVisualStyleBackColor = true;
            chkBoxSearch.CheckedChanged += ChkBoxSearch_CheckedChanged;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(714, 495);
            btnAddEvent.Margin = new Padding(4, 3, 4, 3);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(275, 46);
            btnAddEvent.TabIndex = 6;
            btnAddEvent.Text = "Добавить событие";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += BtnAddEvent_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.ContextMenuStrip = ctxMenuForNotifyIcon;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Календарь активен";
            notifyIcon.Visible = true;
            notifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
            // 
            // ctxMenuForNotifyIcon
            // 
            ctxMenuForNotifyIcon.Items.AddRange(new ToolStripItem[] { todayStripMenuItem, toolStripSeparator, showhideToolStripMenuItem, closetoolStripMenuItem });
            ctxMenuForNotifyIcon.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            ctxMenuForNotifyIcon.Name = "contextMenuStrip1";
            ctxMenuForNotifyIcon.RenderMode = ToolStripRenderMode.Professional;
            ctxMenuForNotifyIcon.ShowImageMargin = false;
            ctxMenuForNotifyIcon.Size = new Size(172, 76);
            ctxMenuForNotifyIcon.Opening += ContextMenuStrip1_Opening;
            // 
            // todayStripMenuItem
            // 
            todayStripMenuItem.Name = "todayStripMenuItem";
            todayStripMenuItem.Size = new Size(171, 22);
            todayStripMenuItem.Text = "Сегодня";
            todayStripMenuItem.Click += TodayStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(168, 6);
            // 
            // showhideToolStripMenuItem
            // 
            showhideToolStripMenuItem.Name = "showhideToolStripMenuItem";
            showhideToolStripMenuItem.Size = new Size(171, 22);
            showhideToolStripMenuItem.Text = "Показать/скрыть";
            showhideToolStripMenuItem.Click += ShowHideToolStripMenuItem_Click;
            // 
            // closetoolStripMenuItem
            // 
            closetoolStripMenuItem.Name = "closetoolStripMenuItem";
            closetoolStripMenuItem.Size = new Size(171, 22);
            closetoolStripMenuItem.Text = "Отключить календарь";
            closetoolStripMenuItem.Click += ClosetoolStripMenuItem_Click;
            // 
            // ctxMenuForEvents
            // 
            ctxMenuForEvents.Items.AddRange(new ToolStripItem[] { удалитьСобытиеToolStripMenuItem });
            ctxMenuForEvents.Name = "contextMenuForEvents";
            ctxMenuForEvents.ShowImageMargin = false;
            ctxMenuForEvents.Size = new Size(156, 48);
            // 
            // удалитьСобытиеToolStripMenuItem
            // 
            удалитьСобытиеToolStripMenuItem.Name = "удалитьСобытиеToolStripMenuItem";
            удалитьСобытиеToolStripMenuItem.Size = new Size(155, 22);
            удалитьСобытиеToolStripMenuItem.Text = "Удалить событие";
            удалитьСобытиеToolStripMenuItem.Click += removeEventToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 561);
            Controls.Add(groupBoxEvents);
            Controls.Add(btnAddEvent);
            Controls.Add(groupBoxCalendar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 5, 2, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1020, 600);
            MinimumSize = new Size(1020, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Календарь с событиями";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)yearChooser).EndInit();
            groupBoxCalendar.ResumeLayout(false);
            groupBoxCalendar.PerformLayout();
            groupBoxEvents.ResumeLayout(false);
            groupBoxEvents.PerformLayout();
            ctxMenuForNotifyIcon.ResumeLayout(false);
            ctxMenuForEvents.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar;
        private NumericUpDown yearChooser;
        private GroupBox groupBoxCalendar;
        private GroupBox groupBoxEvents;
        private Label labelYear;
        private Button btnToChoose;
        private Button btnToToday;
        private Button btnAddEvent;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip ctxMenuForNotifyIcon;
        private ToolStripMenuItem closetoolStripMenuItem;
        private ToolStripMenuItem showhideToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem todayStripMenuItem;
        private CheckBox chkBoxSearch;
        private TextBox txtBoxSearch;
        private Button buttonSearch;
        private FlowLayoutPanel tableLayoutPanel;
        private ContextMenuStrip ctxMenuForEvents;
        private ToolStripMenuItem удалитьСобытиеToolStripMenuItem;
    }
}
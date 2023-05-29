using Calendar.FormForCRUD;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        private DateTime Today => DateTime.Today;

        // ctor and main settings
        public Form1()
        {
            InitializeComponent();
            Prepare();
        }

        private void Prepare()
        {
            // Calendar
            monthCalendar.CalendarDimensions = new Size(4, 3);
            monthCalendar.ScrollChange = 12;
            monthCalendar.MaxSelectionCount = 1;

            monthCalendar.FirstDayOfWeek = 0;

            monthCalendar.MinDate = new DateTime(Today.Year, 1, 1);
            monthCalendar.MaxDate = new DateTime(Today.Year, 12, 31);

            monthCalendar.SetDate(monthCalendar.MinDate);
            monthCalendar.SetDate(Today);

            // Chooser date
            yearChooser.Minimum = 2000;
            yearChooser.Maximum = 3000;

            yearChooser.Value = Today.Year;

            // searcher
            chkBoxSearch.Checked = txtBoxSearch.Enabled = buttonSearch.Enabled = false;
        }


        // Change year in numeric changer
        private void BtnToChoose_Click(object sender, EventArgs e)
        {
            int newYear = (int)yearChooser.Value;

            ChangeYear(newYear);
        }

        private void ChangeYear(int newYear) {
            if (newYear == monthCalendar.MinDate.Year)
                return;

            if (newYear > monthCalendar.MinDate.Year)
            {
                monthCalendar.MaxDate = new DateTime(newYear, 12, 31);
                monthCalendar.MinDate = new DateTime(newYear, 1, 1);
            }

            if (newYear < monthCalendar.MinDate.Year)
            {
                monthCalendar.MinDate = new DateTime(newYear, 1, 1);
                monthCalendar.MaxDate = new DateTime(newYear, 12, 31);
            }

            monthCalendar.SetDate(monthCalendar.MinDate);


            /*
            // add bolds to calendar
            if (everyYear)
                monthCalendar.AddAnnuallyBoldedDate(dateStart);
            else
                monthCalendar.AddBoldedDate(dateStart);
            monthCalendar.UpdateBoldedDates();
            */
        }

        private void BtnToToday_Click(object sender, EventArgs e)
        {
            yearChooser.Value = Today.Year;
            btnToChoose.PerformClick();
            monthCalendar.SetDate(Today);
        }

        // Search
        private void ChkBoxSearch_CheckedChanged(object sender, EventArgs e)
        {
            bool search = chkBoxSearch.Checked;
            txtBoxSearch.Enabled = buttonSearch.Enabled = search;
            btnAddEvent.Enabled = !search;

            if (!search)
            {
                txtBoxSearch.Text = "";
                ShowEvents(monthCalendar.SelectionStart);
            }
            else
                groupBoxEvents.Text = "События по результатам поиска...";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //
            /*
             * 
             * 
             * 
             */
            //
        }


        // Change date in calendar
        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (chkBoxSearch.Checked)
                chkBoxSearch.Checked = false;

            MonthCalendar calendar = (MonthCalendar)sender;
            DateTime dateTime = calendar.SelectionStart;

            ShowEvents(dateTime);
        }

        private void ShowEvents(DateTime dateTime)
        {
            DataTable dt = new DataTable();
            int count = 0;
            // получение данных из БД
            /*
            dt = SELECT * FROM ... WHERE date = @dateTime
            count = COUNT(*) FROM ... WHERE date = @dateTime
            */


            // test - start

            dt.Columns.Add("Name");
            for (int i = 0; i < 5; i++)
            {
                dt.Rows.Add($"{i}");
            }

            count = dt.Rows.Count;

            // test - end

            groupBoxEvents.Text = $"События на {dateTime.ToShortDateString()} ({count})";

            tableLayoutPanel1.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                Button btn = new Button();

                btn.Size = new Size(tableLayoutPanel1.Width - 20, 50);

                btn.Text = $"{row[0]}\n {dateTime} {"7 days"}";

                btn.Click += BtnEditEvent_Click;


                tableLayoutPanel1.Controls.Add(btn);
            }


            /*
            // add changes to calendar
            if (everyYear)
                monthCalendar.AddAnnuallyBoldedDate(dateStart);
            else
                monthCalendar.AddBoldedDate(dateStart);
            monthCalendar.UpdateBoldedDates();
            */
        }

        // CRUD with events
        private void BtnAddEvent_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(monthCalendar.SelectionStart);
            addForm.Owner = this;
            addForm.ShowDialog();

            ShowEvents(monthCalendar.SelectionStart);
        }

        private void BtnEditEvent_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRemoveEvent_Click(object sender, EventArgs e)
        {

        }

        // indicator
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = !Visible;
        }

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            todayStripMenuItem.Text = "Сегодня: " + Today.ToShortDateString();
        }

        private void TodayStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Visible)
                Visible = true;
            btnToToday.PerformClick();
        }

        private void ShowHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
        }

        private bool NoClose { get; set; } = true;

        private void ClosetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoClose = false;
            Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NoClose)
            {
                Hide();
                e.Cancel = true;
            }
        }

        // BLACK ICE - START
        // 
        // BLACK ICE - END
    }
}

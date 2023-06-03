using Calendar.Database;
using Calendar.HelpfulElements;
using Calendar.HelpfulForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Calendar
{

    public partial class Form1 : Form
    {
        private static DateTime Today => DateTime.Today;

        internal CalendarDbContext CDBC { get; init; }

        // ctor and main settings
        public Form1()
        {
            InitializeComponent();

            // DB
            CDBC = new CalendarDbContext();
            bool created = CDBC.Database.EnsureCreated();
            if (created)
                MessageBox.Show("База данных не была найдена, поэтому автоматически создана");

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

            // To bolds date
            BoldDate();

            // Chooser date
            yearChooser.Minimum = 2000;
            yearChooser.Maximum = 3000;

            yearChooser.Value = Today.Year;

            // searcher
            chkBoxSearch.Checked = txtBoxSearch.Enabled = buttonSearch.Enabled = false;

            // tablePanel
            tableLayoutPanel.HorizontalScroll.Enabled = false;
            tableLayoutPanel.HorizontalScroll.Visible = false;
            tableLayoutPanel.AutoScroll = true;
        }

        // Bolds dates to calendar
        private void BoldDate()
        {
            monthCalendar.RemoveAllBoldedDates();
            monthCalendar.RemoveAllAnnuallyBoldedDates();

            foreach (Event ae in CDBC.Events.AsNoTracking().Where(x => x.EveryYear))
                monthCalendar.AddAnnuallyBoldedDate(ae.DateStart);
            foreach (Event oe in CDBC.Events.AsNoTracking().Where(x => !x.EveryYear))
                for (DateTime dt = oe.DateStart.Date; dt <= oe.DateEnd.Date; dt = dt.AddDays(1))
                    monthCalendar.AddBoldedDate(dt);

            monthCalendar.UpdateBoldedDates();
        }

        // Change year in numeric changer
        private void BtnToChoose_Click(object sender, EventArgs e)
        {
            int newYear = (int)yearChooser.Value;

            ChangeYear(newYear);
        }

        private void ChangeYear(int newYear)
        {
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
            {
                groupBoxEvents.Text = "События по результатам поиска...";
                tableLayoutPanel.Controls.Clear();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtBoxSearch.Text;

            List<Event> aEvents = CDBC.Events.AsNoTracking()
                .Where(
                        ae => ae.EveryYear && ae.Title.Contains(searchText))
                .OrderBy(oe => oe.Title)
                .ToList();

            List<Event> oEvents = CDBC.Events.AsNoTracking()
                .Where(
                    oe => !oe.EveryYear && oe.Title.Contains(searchText))
                .OrderBy(oe => oe.DateStart)
                .ToList();

            oEvents.Reverse();
            aEvents.Reverse();

            tableLayoutPanel.Controls.Clear();

            foreach (Event ev in aEvents.Concat(oEvents))
            {
                MemoryButton btn = new(ev)
                {
                    Size = new Size(tableLayoutPanel.Width - 25, 50),
                    ContextMenuStrip = ctxMenuForEvents,
                };

                btn.Click += BtnEditEvent_Click;

                tableLayoutPanel.Controls.Add(btn);
            }
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
            List<Event> aEvents = CDBC.Events.AsNoTracking()
                .Where(
                    ae => ae.EveryYear && ae.DateStart.Month == dateTime.Month && ae.DateStart.Day == dateTime.Day)
                .OrderBy(ae => ae.DateStart)
                .ToList();

            List<Event> oEvents = CDBC.Events.AsNoTracking()
                .Where(
                    oe => !oe.EveryYear && (oe.DateStart.Date <= dateTime.Date && dateTime.Date <= oe.DateEnd.Date))
                .OrderBy(oe => oe.Title)
                .ToList();

            oEvents.Reverse();
            aEvents.Reverse();

            groupBoxEvents.Text = $"События на {dateTime.ToShortDateString()} ({oEvents.Count + aEvents.Count})";

            tableLayoutPanel.Controls.Clear();

            foreach (Event ev in aEvents.Concat(oEvents))
            {
                MemoryButton btn = new(ev)
                {
                    Size = new Size(tableLayoutPanel.Width - 25, 50),
                    ContextMenuStrip = ctxMenuForEvents,
                };

                btn.Click += BtnEditEvent_Click;

                tableLayoutPanel.Controls.Add(btn);
            }
        }

        // CRUD with events
        internal bool AddEvent(Event newEvent)
        {
            try
            {
                if (newEvent.Title.IsNullOrEmpty())
                    throw new Exception("Название события не может быть пустым");

                // если ежегодное событие - добавляем, у него нет ограничения несовместимости
                if (newEvent.EveryYear)
                    CDBC.Events.Add(newEvent);
                // если не ежегодное событие - проверяем, что совместимо
                else
                {
                    if (CDBC.Events.AsNoTracking().
                        Where(oe => !oe.EveryYear)
                        .All(oe => oe.DateEnd < newEvent.DateStart || newEvent.DateEnd < oe.DateStart))
                        CDBC.Events.Add(newEvent);
                    else
                        throw new Exception("Одно событие не может пересекаться с другим(и)! (Кроме ежегодных)");
                }
                CDBC.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
                return false;
            }

            BoldDate();
            ShowEvents(monthCalendar.SelectionStart);
            return true;
        }

        internal bool EditEvent(Event editEvent, Event newEvent)
        {
            try
            {
                if (newEvent.Title.IsNullOrEmpty())
                    throw new Exception("Название события не может быть пустым");

                // если не ежегодное событие - проверяем, что совместимо
                if (!CDBC.Events.AsNoTracking().
                    Where(oe => !oe.EveryYear && oe.ID != editEvent.ID)
                    .All(oe => oe.DateEnd < newEvent.DateStart || newEvent.DateEnd < oe.DateStart))
                    throw new Exception("Одно событие не может пересекаться с другим(и)! (Кроме ежегодных)");

                var old = CDBC.Events.Find(editEvent.ID);
                if (old == null)
                    throw new Exception("Critical error. Create issue!");

                old.Title = newEvent.Title;
                old.DateStart = newEvent.DateStart;
                old.DateEnd = newEvent.DateEnd;
                old.AllDay = newEvent.AllDay;
                old.EveryYear = newEvent.EveryYear;
                old.DateRemind = newEvent.DateRemind;


                CDBC.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
                return false;
            }

            BoldDate();
            ShowEvents(monthCalendar.SelectionStart);
            return true;
        }

        private void BtnAddEvent_Click(object sender, EventArgs e)
        {
            AddForm addForm = new(monthCalendar.SelectionStart);
            addForm.Owner = this;
            addForm.ShowDialog();
        }

        private void BtnEditEvent_Click(object sender, EventArgs e)
        {
            MemoryButton mb = (MemoryButton)sender;

            EditForm ef = new(mb.Ev);
            ef.Owner = this;
            ef.ShowDialog();
        }

        private void removeEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryButton button = ctxMenuForEvents.SourceControl as MemoryButton;

            DialogResult res = MessageBox.Show($"Вы уверены, что хотите удалить событие:\n '{button.Ev.Title}'?",
                "Удаление события",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                var eventToDelete = CDBC.Find<Event>(button.Ev.ID); // Найти объект по идентификатору

                if (eventToDelete != null)
                {
                    CDBC.Remove(eventToDelete); // Удалить объект из контекста данных
                    CDBC.SaveChanges(); // Сохранить изменения в базе данных
                }

                BoldDate();
                ShowEvents(monthCalendar.SelectionStart);
            }
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
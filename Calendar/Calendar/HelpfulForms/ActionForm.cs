using Calendar.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar.HelpfulForms
{
    public partial class ActionForm : Form
    {
        private protected DateTime DateSt { get; }

        public ActionForm()
        {
            InitializeComponent();
        }

        public ActionForm(DateTime dateTime)
        {
            InitializeComponent();

            DateSt = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
            Prepare();
        }


        private void Prepare()
        {
            dtPickerStart.CustomFormat = dtPickerEnd.CustomFormat = dtPickerReminder.CustomFormat = " HH:mm   (dd.MM.yy)";

            chkBoxEveryYear.Enabled = false;

            dtPickerStart.MinDate = dtPickerStart.Value = DateSt;
            dtPickerStart.MaxDate = DateSt.AddDays(+1).AddMinutes(-1);

            dtPickerEnd.MinDate = dtPickerEnd.Value = DateSt.AddMinutes(5);
            dtPickerEnd.MaxDate = DateSt.AddDays(7);

            chkBoxRemind.Checked = true;
            dtPickerReminder.MinDate = DateSt.AddDays(-1);
            dtPickerReminder.MaxDate = DateSt.AddDays(+1);
            dtPickerReminder.Value = DateSt;
        }

        private void ChkBoxAllDay_CheckedChanged(object sender, EventArgs e)
        {
            bool allDay = chkBoxAllDay.Checked;
            if (allDay)
            {
                dtPickerStart.Value = DateSt;
                dtPickerEnd.Value = DateSt.AddDays(1).AddMinutes(-1);
            }
            else
                chkBoxEveryYear.Checked = false;

            chkBoxEveryYear.Enabled = allDay;
            dtPickerStart.Enabled = dtPickerEnd.Enabled = !allDay;
        }

        private void DtPickerTimeStartOrEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtPickerStart.Value.AddMinutes(5) > dtPickerEnd.Value)
            {
                if (sender == dtPickerStart)
                    dtPickerEnd.Value = dtPickerStart.Value.AddMinutes(5);
                else
                    dtPickerStart.Value = dtPickerEnd.Value.AddMinutes(-5);
            }
        }

        private void ChkBoxRemind_CheckedChanged(object sender, EventArgs e)
        {
            dtPickerReminder.Enabled = chkBoxRemind.Checked;
        }

        private protected void BtnAction_Click(object sender, EventArgs e)
        {
            string title = txtBoxTitle.Text;
            DateTime dateStart = dtPickerStart.Value;
            DateTime dateEnd = dtPickerEnd.Value;
            bool allDay = chkBoxAllDay.Checked;
            bool everyYear = chkBoxEveryYear.Checked;
            DateTime? dateRemind = chkBoxRemind.Checked ? dtPickerReminder.Value : null;

            Event newEvent = new Event()
            {
                Title = title,
                DateStart = dateStart,
                DateEnd = dateEnd,
                AllDay = allDay,
                EveryYear = everyYear,
                DateRemind = dateRemind,
            };

            bool res = Action(newEvent);

            if (res)
                Close();
        }

        private protected virtual bool Action(Event actEvent)
        {
            return false;
        }
    }
}

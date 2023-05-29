using System;
using System.Windows.Forms;

namespace Calendar.FormForCRUD
{
    public partial class Form2 : Form
    {
        private protected DateTime DateStart { get; }
        private protected string BtnActionChangeText(string newText) => btnAction.Text = newText;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(DateTime dateTime)
        {
            InitializeComponent();
            
            DateStart = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
            Prepare();
        }
        
        
        private void Prepare()
        {
            dtPickerStart.CustomFormat = dtPickerEnd.CustomFormat = dtPickerReminder.CustomFormat = " HH:mm   (dd.MM.yy)";

            chkBoxEveryYear.Enabled = false;

            dtPickerStart.MinDate = dtPickerStart.Value = DateStart;
            dtPickerStart.MaxDate = DateStart.AddDays(+1).AddMinutes(-1);

            dtPickerEnd.MinDate = dtPickerEnd.Value = DateStart.AddMinutes(5);
            dtPickerEnd.MaxDate = DateStart.AddDays(7);

            chkBoxRemind.Checked = true;
            dtPickerReminder.MinDate = DateStart.AddDays(-1);
            dtPickerReminder.MaxDate = DateStart.AddDays(+1);
            dtPickerReminder.Value = DateStart;
        }

        private void ChkBoxAllDay_CheckedChanged(object sender, EventArgs e)
        {
            bool allDay = chkBoxAllDay.Checked;
            if (allDay)
            {
                dtPickerStart.Value = DateStart;
                dtPickerEnd.Value = DateStart.AddDays(1).AddMinutes(-1);
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

        private protected virtual void BtnAction_Click(object sender, EventArgs e)
        {
            // other actions by implements
        }
    }
}

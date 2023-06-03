using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.Database;
using Calendar.HelpfulElements;

namespace Calendar.HelpfulForms
{
    public partial class EditForm : ActionForm
    {
        private Event EditEvent { get; init; }
        
        public EditForm(Event editEvent) : base(editEvent.DateStart)
        {
            EditEvent = editEvent;

            dtPickerStart.Value = editEvent.DateStart;
            txtBoxTitle.Text = editEvent.Title;
            dtPickerEnd.Value = editEvent.DateEnd;
            chkBoxAllDay.Checked = editEvent.AllDay;
            chkBoxEveryYear.Checked = editEvent.EveryYear;
            if (editEvent.DateRemind == null)
                chkBoxRemind.Checked = false;

            Prepare();
        }
        
        private void Prepare()
        {
            Text = "Редактирование события";
            btnAction.Text = "Изменить событие";
        }

        private protected override bool Action(Event actEvent)
        {
            return (Owner as Form1).EditEvent(EditEvent, actEvent);
        }
    }
}

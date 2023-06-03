using Calendar.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.HelpfulForms
{
    public partial class AddForm : ActionForm
    {
        public AddForm(DateTime dateTime) : base(dateTime)
        {
            Prepare();
        }

        private void Prepare()
        {
            Text = "Новое событие";
            btnAction.Text = "Создать событие";
        }

        private protected override bool Action(Event actEvent)
        {
            return (Owner as Form1).AddEvent(actEvent);
        }
    }
}


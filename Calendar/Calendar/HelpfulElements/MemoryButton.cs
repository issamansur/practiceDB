using Calendar.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.HelpfulElements
{
    public partial class MemoryButton : Button
    {
        public Event Ev { get; init; }

        public MemoryButton(Event Event) : base()
        {
            Ev = Event;

            if (Ev.EveryYear)
                Text = $"{Ev.Title}\nЕжегодное событие";
            else
                Text = $"{Ev.Title}\n{Ev.DateStart.ToString("dd.MM HH:mm")} - {Ev.DateEnd.ToString("dd.MM HH:mm")}";
        }
    }
}

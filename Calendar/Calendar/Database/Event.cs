using System;
using System.Collections.Generic;

namespace Calendar.Database;
public class Event
{
    public int ID { get; set; }
    public string Title { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public bool AllDay { get; set; }
    public bool EveryYear { get; set; }
    public DateTime? DateRemind { get; set; }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDAShell.Calendar
{
    class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool AllDay { get; set; }
    }
}

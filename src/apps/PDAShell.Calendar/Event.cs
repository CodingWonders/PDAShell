using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDAShell.Calendar
{
    class Event
    {
        /// <summary>
        /// The name of the event. This is required
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date of the event. This is also required
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The description of the event. This is optional
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Determines whether the event should last all day. If it is, start and end times become 0:00
        /// </summary>
        public bool AllDay { get; set; }

        /// <summary>
        /// The start time of the event. This is required if the event doesn't last all day
        /// </summary>
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// The end time of the event. This is required if the event doesn't last all day. By default, it is 1 hour ahead of the start time
        /// </summary>
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// Determines whether the event should be on a schedule (it should repeat)
        /// </summary>
        public bool Schedule { get; set; }

        /// <summary>
        /// The schedule mode of an event (or when it needs to repeat)
        /// </summary>
        public int ScheduleMode { get; set; }

        /// <summary>
        /// Determines whether an event is scheduled
        /// </summary>
        public bool Scheduled { get; set; }
    }
}

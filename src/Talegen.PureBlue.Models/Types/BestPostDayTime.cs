namespace Talegen.PureBlue.Models.Types
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class represents a best practice time to post for a channel.
    /// </summary>
    public class BestPostDayTime
    {
        /// <summary>
        /// All days
        /// </summary>
        public static DayOfWeek AllDays = DayOfWeek.Monday | DayOfWeek.Tuesday | DayOfWeek.Wednesday | DayOfWeek.Thursday | DayOfWeek.Friday | DayOfWeek.Saturday | DayOfWeek.Sunday;

        /// <summary>
        /// Gets or sets the day of week.
        /// </summary>
        /// <value>The day of week.</value>
        public DayOfWeek DayOfWeek { get; set; } = AllDays;

        /// <summary>
        /// The time ranges
        /// </summary>
        public List<DateTimeRange> TimeRanges = new List<DateTimeRange>();
    }
}
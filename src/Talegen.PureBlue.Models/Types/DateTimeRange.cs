namespace Talegen.PureBlue.Models.Types
{
    using System;

    /// <summary>
    /// This class represents a date range of a start date time and end date time.
    /// </summary>
    /// <seealso cref="IRange{DateTime}" />
    public class DateTimeRange : IRange<DateTime>
    {
        /// <summary>
        /// Gets the start.
        /// </summary>
        /// <value>The start.</value>
        public DateTime Start { get; set; }

        /// <summary>
        /// Gets the end.
        /// </summary>
        /// <value>The end.</value>
        public DateTime End { get; set; }

        /// <summary>
        /// Includeses the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool Includes(DateTime value)
        {
            return (this.Start <= value) && (value <= this.End);
        }

        /// <summary>
        /// Includeses the specified range.
        /// </summary>
        /// <param name="range">The range.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool Includes(IRange<DateTime> range)
        {
            return (this.Start <= range.Start) && (range.End <= this.End);
        }
    }
}
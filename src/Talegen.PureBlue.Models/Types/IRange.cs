namespace Talegen.PureBlue.Models.Types
{
    /// <summary>
    /// This interface class is used to implement a range class.
    /// </summary>
    /// <typeparam name="T">Contains the type of data for the range.</typeparam>
    public interface IRange<T>
    {
        /// <summary>
        /// Gets the start.
        /// </summary>
        /// <value>The start.</value>
        T Start { get; }

        /// <summary>
        /// Gets the end.
        /// </summary>
        /// <value>The end.</value>
        T End { get; }

        /// <summary>
        /// Includeses the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        bool Includes(T value);

        /// <summary>
        /// Includeses the specified range.
        /// </summary>
        /// <param name="range">The range.</param>
        /// <returns></returns>
        bool Includes(IRange<T> range);
    }
}
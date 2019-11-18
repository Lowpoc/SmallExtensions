using System.Collections.Generic;
using System.Linq;

namespace SmallExtensions.Api.Models
{
    /// <summary>
    /// The main class Word.
    /// </summary>
    public class Word
    {
        /// <summary>
        /// The value of string.
        /// </summary>
        /// <value></value>
        public string Value { get; set; }

        /// <summary>
        /// Where was the word found.
        /// </summary>
        /// <value></value>
        public ICollection<Location> Locations { get; set; }

        /// <summary>
        /// Count of <see cref="Location"/>.
        /// </summary>
        /// <returns></returns>
        public int Occurrences => Locations.Count();
    }
}
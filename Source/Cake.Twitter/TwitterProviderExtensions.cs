using System;
using System.Collections.Generic;
using System.Linq;

namespace Cake.Twitter
{
    /// <summary>
    /// A collection of Extensions for the <see cref="TwitterProvider"/> class.
    /// </summary>
    public static class TwitterProviderExtensions
    {
        /// <summary>
        /// A simple Join method for IEnumerable.
        /// </summary>
        /// <typeparam name="T">The generic type to Join on.</typeparam>
        /// <param name="items">The items that need to be joined.</param>
        /// <param name="separator">The separator to be used when joining the items.</param>
        /// <returns>A string with all the joined items.</returns>
        public static string Join<T>(this IEnumerable<T> items, string separator)
        {
            return string.Join(separator, items.ToArray());
        }

        /// <summary>
        /// A simple Concat method for IEnumerable.
        /// </summary>
        /// <typeparam name="T">The generic type to concatentate on.</typeparam>
        /// <param name="items">The items that need to be concatenated.</param>
        /// <param name="value">The value that is to be concatenated into the items.</param>
        /// <returns>An IEnumerable with the items concatenated to it.</returns>
        public static IEnumerable<T> Concat<T>(this IEnumerable<T> items, T value)
        {
            return items.Concat(new[] { value });
        }

        /// <summary>
        /// A method to encode the data string ready for sending.
        /// </summary>
        /// <param name="value">The string to be encoded.</param>
        /// <returns>The encoded string.</returns>
        public static string EncodeDataString(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            return Uri.EscapeDataString(value);
        }
    }
}

using System;

namespace Organoids.Guard
{
    public static class StringGuardExtensions
    {
        /// <summary>
        /// Ensures that a given string is not empty or whitespace. <c>null</c> is considered a valid value.
        /// An <see cref="ArgumentException"/> is thrown if condition is not met.
        /// </summary>
        /// <param name="_"></param>
        /// <param name="argValue">The value of the argument to verify.</param>
        /// <param name="argName">The name of the argument being considered.</param>
        public static void NotEmptyOrWhiteSpace(this IStringGuard _, string argValue, string argName)
        {
            if (argValue is null) return;

            if (string.IsNullOrWhiteSpace(argValue))
                throw new ArgumentException($"Argument '{argName}' may not be empty or white-space, though it may be null.", argName);
        }

        /// <summary>
        /// Ensures that a string argument's length is below a maximum allowed threshold.
        /// </summary>
        /// <param name="_"></param>
        /// <param name="argValue">The value of the argument to verify.</param>
        /// <param name="maxLength">The maximum allowable length for the <paramref name="argValue"/>; its length must be less than or equal  to this value.</param>
        /// <param name="argName">The name of the argument being considered.</param>
        public static void MaxLength(this IStringGuard _, string argValue, int maxLength, string argName)
        {
            if (argValue != null && argValue.Length > maxLength)
                throw new ArgumentOutOfRangeException(argName, $"Argument '{argName}' cannot exceed {maxLength} characters.");
        }
    }
}

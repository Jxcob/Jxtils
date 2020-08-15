using System;

namespace Jxtils
{
    /// <summary>
    /// For all fundamental wrappers.
    /// </summary>
    public static class Essentials
    {
        /// <summary>
        /// Displays a console message and gets the user's response.
        /// </summary>
        /// <param name="message">The message being displayed by the console.</param>
        /// <returns>The user's response.</returns>
        public static string GetInput(string message)
        {
            Console.Write(message);

            return Console.ReadLine();
        }
    }
}

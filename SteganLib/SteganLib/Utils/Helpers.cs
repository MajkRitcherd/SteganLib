/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

namespace SteganLib.Utils
{
    /// <summary>
    /// Class containing helper methods.
    /// </summary>
    internal class Helpers
    {
        /// <summary>
        /// Checks whether or not file exists and returns FileStream of a file.
        /// </summary>
        /// <param name="path">Path to the file.</param>
        /// <param name="mode">File mode.</param>
        /// <param name="access">File access.</param>
        /// <returns>File stream.</returns>
        /// <exception cref="ArgumentNullException">Thrown, if path is null or empty.</exception>
        /// <exception cref="FileNotFoundException">Thrown, if file is not found due to that it does not exists or path is invalid.</exception>
        internal static FileStream CheckedOpenFile(string path, FileMode mode, FileAccess access)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("Path to file cannot be null or empty!");

            if (!File.Exists(path))
                throw new FileNotFoundException($"File does not exists! Given path: '{path}'");

            return File.Open(path, FileMode.Open, FileAccess.ReadWrite);
        }
    }
}

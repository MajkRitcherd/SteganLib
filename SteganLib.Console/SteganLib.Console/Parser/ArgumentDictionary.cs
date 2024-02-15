/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

namespace SteganLib.Console.Parser
{
    /// <summary>
    /// Argument dictionary (Works with long or short version of argument keys).
    /// </summary>
    public class ArgumentDictionary : Dictionary<string, string>
    {
        /// <summary>
        /// Gets value for a given string
        /// (If key is not contained in the collection, string.Empty is returned, otherwise value is returned). <br/>
        /// Given argument key is a long version and the method searches also for a short argument key.
        /// </summary>
        /// <param name="key">Argument key.</param>
        /// <returns>Value, if key is in the collection, otherwise empty string.</returns>
        public new string this[string key]
        {
            get
            {
                if (this.TryGetValue(key, out string? value))
                    return value;

                if (this.TryGetValue(key[..3], out string? valueShort))
                    return valueShort;

                return string.Empty;
            }
            set
            {
                base[key] = value;
            }
        }
    }
}
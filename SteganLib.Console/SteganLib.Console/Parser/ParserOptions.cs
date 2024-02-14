/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

using SteganLib.Console.Helpers;
using CAK = SteganLib.Console.Constants.ParserOptions.ArgumentKeys;
using CO = SteganLib.Console.Constants.ParserOptions.Operations;

namespace SteganLib.Console.Parser
{
    /// <summary>
    /// Parser's options.
    /// </summary>
    public class ParserOptions
    {
        /// <summary>
        /// Gets the all possible operations for parser.
        /// </summary>
        protected readonly List<string> Operations =
        [
            CO.Decode,  // decSteg
            CO.Encode,  // enSteg
        ];

        /// <summary>
        /// Gets all possible argument keys for parser (IMPORTANT: Extended in constructor).
        /// </summary>
        protected ArgumentList ArgumentKeys { get; private set; } =
        [
            CAK.Help,           // --help
            CAK.Help[..3],      // --h

            CAK.Image,          // --image
            CAK.Image[..3],     // --i

            CAK.Message,        // --message
            CAK.Message[..3],   // --m

            CAK.Operation,      // --operation
            CAK.Operation[..3], // --o

            CAK.Password,       // --password
            CAK.Password[..3],  // --p

            CAK.SafeMode,       // --safe
            CAK.SafeMode[..3],  // --s
        ];

        /// <summary>
        /// Determines whether or not the given argument key is allowed.
        /// </summary>
        /// <param name="argKey">Argument key to check.</param>
        /// <returns>True, if argument key is allowed, otherwise false.</returns>
        protected bool ContainsArgumentKey(string argKey)
        {
            return this.ArgumentKeys.Contains(argKey, StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Determines whether or not the given operation is allowed.
        /// </summary>
        /// <param name="operation">Operation to check.</param>
        /// <returns>True, if operation is allowed, otherwise false.</returns>
        protected bool ContainsOperation(string operation)
        {
            return this.Operations.Contains(operation, StringComparer.OrdinalIgnoreCase);
        }
    }
}
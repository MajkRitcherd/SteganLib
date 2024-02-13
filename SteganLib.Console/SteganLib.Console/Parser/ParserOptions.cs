/**********************************************
 * 
 *          Created by Majk Ritcherd
 * 
 *********************************************/

using CO = SteganLib.Console.Constants.ParserOptions.Operations;
using CAK = SteganLib.Console.Constants.ParserOptions.ArgumentKeys;

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
            CO.Encode,  // enSteg
            CO.Decode,  // decSteg
        ];

        /// <summary>
        /// Gets all possible argument keys for parser (IMPORTANT: Extended in constructor).
        /// </summary>
        protected List<string> ArgumentKeys { get; private set; } =
        [
            CAK.Help,           // --help
            CAK.Help[..3],      // --h

            CAK.SafeMode,       // --safe
            CAK.SafeMode[..3],  // --s

            CAK.Message,        // --message
            CAK.Message[..3],   // --m

            CAK.Image,          // --image
            CAK.Image[..3],     // --i

            CAK.Password,       // --password
            CAK.Password[..3],  // --p
        ];
    }
}
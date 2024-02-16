/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

namespace SteganLib.Steganography
{
    /// <summary>
    /// Abstract implementation of steganography encode/decode methods.
    /// </summary>
    internal abstract class AbstractSteganMethods
    {
        /// <summary>
        /// Depending on Singletion (either EncodeMethods or DecodeMethods) <br />
        /// encodes/decodes using LHB (Lower Half Byte, e.g. 0000 xxxx, 'x' will be encoded/decoded).
        /// </summary>
        internal abstract void LHB(string pathToImage, string? message = null, string? password = null);

        /// <summary>
        /// Depending on Singletion (either EncodeMethods or DecodeMethods) <br />
        /// encodes/decodes using LSB (Least Significand Bit).
        /// </summary>
        internal abstract void LSB(string pathToImage, string? message = null, string? password = null);

        /// <summary>
        /// Depending on Singletion (either EncodeMethods or DecodeMethods) <br />
        /// encodes/decodes using MSB (Most Significand Bit).
        /// </summary>
        internal abstract void MSB(string pathToImage, string? message = null, string? password = null);

        /// <summary>
        /// Depending on Singletion (either EncodeMethods or DecodeMethods) <br />
        /// encodes/decodes using password.
        /// </summary>
        internal abstract void Password(string pathToImage, string? message = null, string? password = null);

        /// <summary>
        /// Depending on Singletion (either EncodeMethods or DecodeMethods) <br />
        /// encodes/decodes using UHB (Upper Half Byte, e.g. xxxx 0000, 'x' will be encoded/decoded).
        /// </summary>
        internal abstract void UHB(string pathToImage, string? message = null, string? password = null);
    }
}
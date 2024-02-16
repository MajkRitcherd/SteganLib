/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

namespace SteganLib.SteganCoder
{
    /// <summary>
    /// All possible modes of encoding/decoding.
    /// </summary>
    public enum SteganMode
    {
        /// <summary>
        /// Encodes/decodes using LSB (Least Significand Bit).
        /// </summary>
        LSB,

        /// <summary>
        /// Encodes/decodes using MSB (Most Significand Bit).
        /// </summary>
        MSB,

        /// <summary>
        /// Encodes/decodes using LHB (Lower Half Byte, e.g. 0000 xxxx, 'x' will be encoded/decoded).
        /// </summary>
        LHB,

        /// <summary>
        /// Encodes/decodes using UHB (Upper Half Byte, e.g. xxxx 0000, 'x' will be encoded/decoded).
        /// </summary>
        UHB,

        /// <summary>
        /// Encodes/decodes using password.
        /// </summary>
        Password,
    }
}

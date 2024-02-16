/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

namespace SteganLib.SteganCoder
{
    /// <summary>
    ///
    /// </summary>
    public class SteganCoder(SteganMode steganMode)
    {
        /// <summary>
        /// Gets a value indicating whether or not to use password when encoding/decoding.
        /// </summary>
        public SteganMode CurrentSteganMode { get; private set; } = steganMode;

        /// <summary>
        ///
        /// </summary>
        public void Decode(string message, string? password)
        {
            Steganography.Decode(CurrentSteganMode, message, password);
        }

        /// <summary>
        /// Encodes message to the image
        /// </summary>
        public void Encode(string message, string pathToImage, string? password)
        {
            if (CurrentSteganMode == SteganMode.Password && string.IsNullOrEmpty(password))
                throw new Exception($"When using SteganMode.{CurrentSteganMode}, password cannot be empty or null!");

            Steganography.Encode(CurrentSteganMode, message, pathToImage, password);
        }
    }
}
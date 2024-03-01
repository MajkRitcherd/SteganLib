/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

namespace SteganLib.API
{
    /// <summary>
    /// Represents steganography coder.
    /// </summary>
    public class SteganCoder(SteganMode steganMode)
    {
        /// <summary>
        /// Gets a value indicating whether or not to use password when encoding/decoding.
        /// </summary>
        public SteganMode CurrentSteganMode { get; private set; } = steganMode;

        /// <summary>
        /// Decodes message from image.
        /// </summary>
        /// <param name="pathToImage">Path to the image.</param>
        /// <param name="password">Password used when encoding the message.</param>
        public void Decode(string pathToImage, string? password)
        {
            Steganography.Decode(CurrentSteganMode, pathToImage, password);
        }

        /// <summary>
        /// Encodes message to the image.
        /// </summary>
        /// <param name="message">Message to encode.</param>
        /// <param name="pathToImage">Path to the image.</param>
        /// <param name="password">Password to use.</param>
        /// <exception cref="Exception">Thrown, if mode = Password, but no password is given.</exception>
        public void Encode(string message, string pathToImage, string? password)
        {
            if (CurrentSteganMode == SteganMode.Password && string.IsNullOrEmpty(password))
                throw new Exception($"When using SteganMode.{CurrentSteganMode}, password cannot be empty or null!");

            Steganography.Encode(CurrentSteganMode, pathToImage, message, password);
        }
    }
}
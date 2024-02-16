/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

using SteganLib.Steganography;

namespace SteganLib.SteganCoder
{
    /// <summary>
    /// Performs encoding/decoding message into the image using password.
    /// </summary>
    internal static class Steganography
    {
        /// <summary>
        /// Decodes image using given SteganMode and password (in case of SteganMode.Password).
        /// </summary>
        /// <param name="pathToImage">Path to the image.</param>
        /// <param name="password">Password to use with mode SteganMode.Password.</param>
        internal static void Decode(SteganMode steganMode, string pathToImage, string? password = null)
        {
            Code(DecodeMethods.Instance, steganMode, pathToImage, null, password);
        }

        /// <summary>
        /// Encodes message into the image using given SteganMode and password (in case of SteganMode.Password).
        /// </summary>
        /// <param name="pathToImage">Path to the image.</param>
        /// <param name="message">Message to encode into the image.</param>
        /// <param name="password">Password to use with mode SteganMode.Password.</param>
        internal static void Encode(SteganMode steganMode, string pathToImage, string? message = null, string? password = null)
        {
            Code(EncodeMethods.Instance, steganMode, pathToImage, message, password);
        }

        /// <summary>
        /// Performs encoding or decoding of a massage in image.
        /// </summary>
        /// <typeparam name="T">Either EncodeMethods or DecodeMethods.</typeparam>
        /// <param name="instance">Instance of the T.</param>
        /// <param name="steganMode">Steganogprahy mode.</param>
        /// <param name="pathToImage">Path to the image.</param>
        /// <param name="message">Message to encode.</param>
        /// <param name="password">Password to use with mode SteganMode.Password.</param>
        /// <exception cref="Exception">Thrown</exception>
        private static void Code<T>(T instance, SteganMode steganMode, string pathToImage, string? message = null, string? password = null) where T : AbstractSteganMethods
        {
            if (typeof(T) != typeof(EncodeMethods) || typeof(T) != typeof(DecodeMethods) || instance == null)
                throw new Exception($"Passed instance '{instance}' is not either EncodeMethods or DecodeMethods!");

            switch (steganMode)
            {
                case SteganMode.LSB:
                    if (instance is DecodeMethods)
                        instance.LSB(pathToImage);
                    else
                        instance.LSB(pathToImage, message);
                    break;

                case SteganMode.MSB:
                    if (instance is DecodeMethods)
                        instance.MSB(pathToImage);
                    else
                        instance.MSB(pathToImage, message);
                    break;

                case SteganMode.LHB:
                    if (instance is DecodeMethods)
                        instance.LHB(pathToImage);
                    else
                        instance.LHB(pathToImage, message);
                    break;

                case SteganMode.UHB:
                    if (instance is DecodeMethods)
                        instance.UHB(pathToImage);
                    else
                        instance.UHB(pathToImage, message);
                    break;

                case SteganMode.Password:
                    if (instance is DecodeMethods)
                        instance.Password(pathToImage, password: password);
                    else
                        instance.Password(pathToImage, message, password);
                    break;

                default:
                    throw new Exception($"'{steganMode}' is not valid for encoding!");
            }
        }
    }
}
/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

namespace SteganLib.Steganography
{
    /// <summary>
    /// Singleton containing steganography decode methods.
    /// </summary>
    internal class DecodeMethods() : AbstractSteganMethods
    {
        private static readonly Lazy<DecodeMethods> lazy = new(() => new DecodeMethods());

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static DecodeMethods Instance => lazy.Value;

        /// <inheritdoc/>
        internal override void LHB(string pathToImage, string? message, string? password)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        internal override void LSB(string pathToImage, string? message, string? password)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        internal override void MSB(string pathToImage, string? message, string? password)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        internal override void Password(string pathToImage, string? message, string? password)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        internal override void UHB(string pathToImage, string? message, string? password)
        {
            throw new NotImplementedException();
        }
    }
}
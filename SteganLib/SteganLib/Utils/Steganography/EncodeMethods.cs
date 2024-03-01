/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

namespace SteganLib.Utils.Steganography
{
    /// <summary>
    /// Singleton containing steganography encode methods.
    /// </summary>
    internal class EncodeMethods() : AbstractSteganMethods
    {
        private static readonly Lazy<EncodeMethods> lazy = new(() => new EncodeMethods());

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static EncodeMethods Instance => lazy.Value;

        /// <inheritdoc/>
        internal override void LHB(string pathToImage, string? message, string? password)
        {
            var imageStream = Helpers.CheckedOpenFile(pathToImage, FileMode.Open, FileAccess.ReadWrite);

            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        internal override void LSB(string pathToImage, string? message, string? password)
        {
            var imageStream = Helpers.CheckedOpenFile(pathToImage, FileMode.Open, FileAccess.ReadWrite);

            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        internal override void MSB(string pathToImage, string? message, string? password)
        {
            var imageStream = Helpers.CheckedOpenFile(pathToImage, FileMode.Open, FileAccess.ReadWrite);

            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        internal override void Password(string pathToImage, string? message, string? password)
        {
            var imageStream = Helpers.CheckedOpenFile(pathToImage, FileMode.Open, FileAccess.ReadWrite);

            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        internal override void UHB(string pathToImage, string? message, string? password)
        {
            var imageStream = Helpers.CheckedOpenFile(pathToImage, FileMode.Open, FileAccess.ReadWrite);

            throw new NotImplementedException();
        }
    }
}
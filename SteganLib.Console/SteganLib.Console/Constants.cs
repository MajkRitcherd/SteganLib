/**********************************************
 * 
 *          Created by Majk Ritcherd
 * 
 *********************************************/

namespace SteganLib.Console
{
    /// <summary>
    /// SteganLib.Console constants.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Constants related to the <see cref="ParserOptions"/> class.
        /// </summary>
        public static class ParserOptions
        {
            /// <summary>
            /// Constants related to the possible operations.
            /// </summary>
            public static class Operations
            {
                /// <summary>
                /// Encode operation.
                /// </summary>
                public const string Encode = "enSteg";

                /// <summary>
                /// Decode operation.
                /// </summary>
                public const string Decode = "decSteg";
            }

            /// <summary>
            /// Constants related to the possible argument keys.
            /// </summary>
            public static class ArgumentKeys
            {
                /// <summary>
                /// Help key.
                /// </summary>
                public const string Help = "--help";

                /// <summary>
                /// Safe mode key.
                /// </summary>
                public const string SafeMode = "--safe";

                /// <summary>
                /// Message key.
                /// </summary>
                public const string Message = "--message";

                /// <summary>
                /// Image key.
                /// </summary>
                public const string Image = "--image";

                /// <summary>
                /// Password key.
                /// </summary>
                public const string Password = "--password";
            }
        }

    }
}

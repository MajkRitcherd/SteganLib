/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

using CAK = SteganLib.Console.Constants.ParserOptions.ArgumentKeys;

namespace SteganLib.Console.Parser
{
    /// <summary>
    /// Parses command line aargument (keys with values)
    /// </summary>
    /// <param name="args"></param>
    public class CommandLineParser(string[] args) : ArgumentParser(args)
    {
        /// <summary>
        /// Gets help value from command line.
        /// </summary>
        public string Help => this.Arguments[CAK.Help];

        /// <summary>
        /// Gets image value from command line.
        /// </summary>
        public string Image => this.Arguments[CAK.Image];

        /// <summary>
        /// Gets message value from command line.
        /// </summary>
        public string Message => this.Arguments[CAK.Message];

        /// <summary>
        /// Gets operation value from command line.
        /// </summary>
        public string Operation => this.Arguments[CAK.Operation];

        /// <summary>
        /// Gets password value from command line.
        /// </summary>
        public string Password => this.Arguments[CAK.Password];

        /// <summary>
        /// Gets safe mode value from command line.
        /// </summary>
        public string SafeMode => this.Arguments[CAK.SafeMode];
    }
}
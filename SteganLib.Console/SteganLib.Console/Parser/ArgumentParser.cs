/**********************************************
 *
 *          Created by Majk Ritcherd
 *
 *********************************************/

using CAK = SteganLib.Console.Constants.ParserOptions.ArgumentKeys;

namespace SteganLib.Console.Parser
{
    /// <summary>
    /// Parses arguments from command line.
    /// </summary>
    public class ArgumentParser : ParserOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentParser"/> class.
        /// </summary>
        /// <param name="args">Arguments.</param>
        public ArgumentParser(string[] args)
        {
            if (args.Length == 0)
                throw new Exception("No arguments were given!");

            ParseArguments(args);
        }

        /// <summary>
        /// Gets or sets arguments.
        /// </summary>
        public Dictionary<string, string> Arguments { get; set; } = [];

        /// <summary>
        /// Writes help to the command line.
        /// </summary>
        public void WriteHelp()
        {
        }

        /// <summary>
        /// Checks whether first argument is valid and whether or not it is help argument key.
        /// </summary>
        /// <param name="arg">First argument to check.</param>
        /// <exception cref="Exception"></exception>
        private void CheckFirstArgument(string arg)
        {
            // First argument must be type of operation
            if (IsFirstArgumentInvalid(arg))
                throw new Exception("First argument must be the type of operation you want to do!");

            // If not operation, then it is help
            if (!IsOperation(arg))
                this.WriteHelp();
        }

        /// <summary>
        /// Determines whether or not given argument key is known.
        /// </summary>
        /// <param name="argKey">Argument key.</param>
        /// <returns>True, if it is argument key, otherwise false.</returns>
        private bool IsArgumentKey(string argKey)
        {
            return this.ContainsArgumentKey(argKey);
        }

        /// <summary>
        /// Determines whether or not the first given argument is invalid or valid.
        /// </summary>
        /// <param name="arg">Argument to check.</param>
        /// <returns>True, if it is invalid, otherwise false.</returns>
        private bool IsFirstArgumentInvalid(string arg)
        {
            return !IsOperation(arg)
                || arg.Equals(CAK.Help, StringComparison.OrdinalIgnoreCase)
                || arg.Equals(CAK.Help[..3], StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Determines, whether or not given key is operation.
        /// </summary>
        /// <param name="operation">Operation.</param>
        /// <returns>True, if it is operation, otherwise false.</returns>
        private bool IsOperation(string operation)
        {
            return this.ContainsOperation(operation);
        }

        /// <summary>
        /// Parses arguments into dictionary of keys and values.
        /// </summary>
        /// <param name="args">Arguments.</param>
        private void ParseArguments(string[] args)
        {
            var firstArg = args[0];
            CheckFirstArgument(firstArg);

            // Add operation to the arguments
            this.Arguments.Add(ArgumentKeys[CAK.Operation[..3]], firstArg);

            // Get argument keys with its corresponding values
            var argKey = string.Empty;
            for (int i = 1; i < args.Length; i++)
            {
                var arg = args[i];

                if (IsArgumentKey(arg))
                {
                    argKey = arg;
                    this.Arguments.Add(argKey, true.ToString());
                    continue;
                }

                this.Arguments[argKey] = arg;
            }
        }
    }
}
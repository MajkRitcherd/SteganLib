namespace SteganLib.Console.Helpers
{
    /// <summary>
    /// Extended List to search by keys for items.
    /// </summary>
    public class ArgumentList : List<string>
    {
        /// <summary>
        /// Searches for the key in the collection.
        /// </summary>
        /// <param name="key">Key to find.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown if given key is not found in the collection.</exception>
        public string this[string key] => this.Find(f => f.Equals(key, StringComparison.OrdinalIgnoreCase))
                                            ?? throw new ArgumentException($"Couldn't find item with '{key}'!");
    }
}
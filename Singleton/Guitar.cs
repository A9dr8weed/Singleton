using System;

namespace Singleton
{
    /// <summary>
    /// Implementation of the Singleton pattern.
    /// </summary>
    public sealed class Guitar
    {
        /// <summary>
        /// A closed static field of a class in which a single instance of a single class is stored.
        /// The instance is initialized lazily - that is, it will be performed only on the first call.
        /// This design also ensures that only one instance of a class is created when handling multiple threads.
        /// </summary>
        private static readonly Lazy<Guitar> _instance = new Lazy<Guitar>(() => new Guitar());

        /// <summary>
        /// Variable for calculating the call of designers.
        /// </summary>
        private static int _count;

        public string Value { get; set; }

        /// <summary>
        /// Public property for accessing an instance of the singleton class.
        /// </summary>
        public static Guitar GetGuitar => _instance.Value;

        /// <summary>
        /// Private constructor with a counter of calls of the constructor.
        /// </summary>
        private Guitar()
        {
            _count++;
            Console.WriteLine($"Constructor {_count}");
        }

        /// <summary>
        /// Some method.
        /// </summary>
        /// <param name="action"> Some message. </param>
        public string PlayTheGuitar(string action) => action;
    }
}
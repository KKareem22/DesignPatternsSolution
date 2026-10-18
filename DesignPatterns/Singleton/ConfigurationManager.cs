
namespace DesignPatterns.Singleton
{
    /// <summary>
    /// Represents a configuration manager that provides
    /// a single shared instance throughout the application.
    ///
    /// The Singleton Pattern is used to control object creation
    /// and provide a shared access point to that object.
    /// </summary>
    internal  class ConfigurationManager
    {
        // Stores a single Lazy wrapper shared by the entire class.
        //
        // Lazy<T> delays creating the actual ConfigurationManager
        // object until its Value property is accessed for the first time.
        //
        // Lazy<T> uses thread-safe initialization by default,
        // ensuring that concurrent callers do not create multiple
        // ConfigurationManager instances through this Lazy object.
        private static readonly Lazy<ConfigurationManager> _instance =
            new(()=> new ConfigurationManager());
                
           

        // Private constructor:
        // Prevents external code from creating instances directly
        // using "new ConfigurationManager()".
        //
        // The class itself can call this constructor to create
        // its own instance.
        private ConfigurationManager()
        {
            Console.WriteLine("ConfigurationManager instance created.");
        }

        // Provides the public access point to the shared instance.
        //
        // The first access creates the actual object.
        // Subsequent accesses return the same object.
        public static ConfigurationManager Instance => _instance.Value;

        // Example property representing a configuration value.
        //
        // This property is mutable, so changes are visible to all
        // callers that reference the same Singleton instance.
        //
        // Thread-safe initialization does NOT automatically make
        // modifications to this property thread-safe.
        public string Name { get; set; }
        public static void Test()
        {
            Console.WriteLine("Testing ConfigurationManager...");
        }

        
    }
}

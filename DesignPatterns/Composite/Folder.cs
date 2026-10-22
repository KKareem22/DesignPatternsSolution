namespace DesignPatterns.Composite
{
    internal class Folder : IFileSystemComponent
    {
        private readonly string _name;
        private readonly List<IFileSystemComponent> _childern = new();
        public Folder(string name)
        {
            _name = name;
        }
        public void Add(IFileSystemComponent component)
            => _childern.Add(component);

        public void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ',depth*2)}Folder:{_name}");
            foreach (var child in _childern)
            {
                child.Display(depth + 1);
                
            }
        }
    }
}

namespace DesignPatterns.Composite
{
    internal class FileItem : IFileSystemComponent
    {
        private readonly string _name;

        public FileItem(string name)
        {
            _name = name;
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ',depth*2)}File:{_name}");
        }
    }
}

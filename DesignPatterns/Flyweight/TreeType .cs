namespace DesignPatterns.Flyweight
{
    internal class TreeType
    {
        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
            Console.WriteLine($"Creating shared tree type: {Name}");

        }

        public string Name { get; }
        public string Color { get; }
        public string Texture { get; }
        public void Draw(int x,int y)
        {
            Console.WriteLine($"Drawing {Name} ({Color} ,{Texture}) at ({x},{y})");
        }
    }
}

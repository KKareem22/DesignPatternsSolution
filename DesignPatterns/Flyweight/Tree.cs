namespace DesignPatterns.Flyweight
{
    internal class Tree
    {
        private readonly int x;
        private readonly int y;
        private readonly TreeType _treeType;

        public Tree(int x, int y, TreeType treeType)
        {
            this.x = x;
            this.y = y;
            _treeType = treeType;
        }
        public void Draw()
        {
            _treeType.Draw(x, y);
        }
    }
}

namespace DesignPatterns.Flyweight
{
    internal class TreeFactory
    {
        private readonly Dictionary<string, TreeType> _treeTypes = new();
        public TreeType GetTreeType(string name,string color,string texture)
        {
            var key = $"{name}_{color}_{texture}";
            if(!_treeTypes.TryGetValue(key,out TreeType? treeType))
            {
                treeType = new TreeType(name, color, texture);
                _treeTypes[key] = treeType;
            }
            return treeType;
        }
    }
}

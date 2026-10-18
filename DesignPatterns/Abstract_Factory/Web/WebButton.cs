using DesignPatterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Abstract_Factory.Web
{
    internal class WebButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Web Button .");
        }

    }
}

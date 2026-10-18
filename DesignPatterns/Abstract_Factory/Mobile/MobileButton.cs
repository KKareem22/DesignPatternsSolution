using DesignPatterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Abstract_Factory.Mobile
{
    internal class MobileButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mobile Button .");
        }
    }
}

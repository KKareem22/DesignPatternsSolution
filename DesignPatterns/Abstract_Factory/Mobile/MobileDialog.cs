using DesignPatterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Abstract_Factory.Mobile
{
    internal class MobileDialog : IDialog
    {
        public void Show()
        {
            Console.WriteLine("Showing Mobile Dialog .");
        }
    }
}

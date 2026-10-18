using DesignPatterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Abstract_Factory.Web
{
    internal class WebDialog : IDialog
    {
        public void Show()
        {
            Console.WriteLine("Showing Web Dialog .");
        }
    }
}

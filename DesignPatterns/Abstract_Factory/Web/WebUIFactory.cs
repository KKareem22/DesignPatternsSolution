using DesignPatterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Abstract_Factory.Web
{
    internal class WebUIFactory : IUIFactory
    {
        public IButton CreateButton() => new WebButton();


        public IDialog CreateDialog() => new WebDialog();

    }
}

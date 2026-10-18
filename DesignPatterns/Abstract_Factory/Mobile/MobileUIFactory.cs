using DesignPatterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Abstract_Factory.Mobile
{
    internal class MobileUIFactory : IUIFactory
    {
        public IButton CreateButton()=>new MobileButton();


        public IDialog CreateDialog()=>new MobileDialog();

    }
}

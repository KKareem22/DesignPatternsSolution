namespace DesignPatterns.Abstract_Factory.Interfaces
{
    internal interface IUIFactory
    {
        IButton CreateButton();
        IDialog CreateDialog();
    }
}

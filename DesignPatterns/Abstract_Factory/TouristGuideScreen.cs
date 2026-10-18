using DesignPatterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Abstract_Factory
{
    internal class TouristGuideScreen
    {
        public void RenderScreen(IUIFactory factory)
        {
            var button = factory.CreateButton();
            var dialog=factory.CreateDialog();

            button.Render();
            dialog.Show();
        }
    }
}

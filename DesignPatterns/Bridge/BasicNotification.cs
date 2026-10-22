namespace DesignPatterns.Bridge
{
    internal class BasicNotification : Notification
    {
        public BasicNotification(IMessageSender sender) : base(sender)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Basic notification :");
            _sender.SendMessage(message);
        }
    }
}

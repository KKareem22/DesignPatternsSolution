namespace DesignPatterns.Bridge
{
    internal class UrgentNotification : Notification
    {
        public UrgentNotification(IMessageSender sender) : base(sender)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Urgent Notification :");
            _sender.SendMessage(message);
        }
    }
}

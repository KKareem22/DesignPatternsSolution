namespace DesignPatterns.Bridge
{
    internal class SMSSender : IMessageSender
    {
        public void SendMessage(string message)
        => Console.WriteLine($"Sending SMS {message}");
    }
}

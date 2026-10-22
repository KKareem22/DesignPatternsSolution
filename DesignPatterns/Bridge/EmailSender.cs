namespace DesignPatterns.Bridge
{
    internal class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        => Console.WriteLine($"Sending Email {message}");
    }
}

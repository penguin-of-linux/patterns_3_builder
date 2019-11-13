namespace Example_03.Homework
{
    public interface ILetterBuilder
    {
        ILetterBuilder AddReceiver(string receiver);
        ILetterBuilder AddCopyReceiver(string copyReceiver);
        ILetterBuilder SetTopic(string topic);
        ILetterBuilder SetBody(string body);
        Letter Build();
    }
}
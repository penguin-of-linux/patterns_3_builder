using System.Linq;
using System.Text;

namespace Example_03.Homework
{
    public static class LetterExtensions
    {
        public static string GetFull(this Letter letter)
        {
            var result = new StringBuilder();
            foreach (var receiver in letter.Receivers.Concat(letter.CopyReceivers))
            {
                result.AppendLine($"To: {receiver}");
            }

            result.AppendLine($"---{letter.Topic}---");
            result.AppendLine(letter.Body);

            return result.ToString();
        }
    }
}
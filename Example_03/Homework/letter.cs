using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_03.Homework
{
    public class Letter
    {
        public List<string> Receivers { get; set; }
        public List<string> CopyReceivers { get; set; }
        public string Body { get; set; }
        public string Topic { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var receiver in Receivers.Concat(CopyReceivers))
            {
                result.AppendLine($"To: {receiver}");
            }

            result.AppendLine($"---{Topic}---");
            result.AppendLine(Body);

            return result.ToString();
        }
    }
}
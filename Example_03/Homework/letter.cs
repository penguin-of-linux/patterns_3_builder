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
    }
}
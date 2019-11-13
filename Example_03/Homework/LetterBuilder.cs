using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Example_03.Homework
{
    public class LetterBuilder : ILetterBuilder
    {
        public ILetterBuilder AddReceiver(string receiver)
        {
            letter.Receivers.Add(receiver);
            state |= LetterBuilderState.HasReceiver;

            return this;
        }

        public ILetterBuilder AddCopyReceiver(string copyReceiver)
        {
            letter.CopyReceivers.Add(copyReceiver);

            return this;
        }

        public ILetterBuilder SetTopic(string topic)
        {
            letter.Topic = topic;

            return this;
        }

        public ILetterBuilder SetBody(string body)
        {
            letter.Body = body;
            state |= LetterBuilderState.HasBody;

            return this;
        }

        public Letter Build()
        {
            if (state != LetterBuilderState.ReadyToBuild)
                throw new InvalidOperationException("Letter must have at least 1 receiver and body");

            return JsonConvert.DeserializeObject<Letter>(JsonConvert.SerializeObject(letter));
        }

        private LetterBuilderState state = 0;
        private readonly Letter letter = new Letter
        {
            Receivers = new List<string>(),
            CopyReceivers = new List<string>(),
            Body = "<empty>",
            Topic = "<empty>"
        };
    }
}
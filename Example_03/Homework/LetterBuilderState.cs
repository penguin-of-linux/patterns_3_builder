using System;

namespace Example_03.Homework
{
    [Flags]
    public enum LetterBuilderState
    {
        HasReceiver = 1,
        HasBody = 2,
        ReadyToBuild = 3
    }
}
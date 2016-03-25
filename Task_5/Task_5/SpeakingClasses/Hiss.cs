using System;

namespace Task_5.SpeakingClasses
{
    class Hiss : ISpeaking
    {
        public void Speak()
        {
            Console.WriteLine("Я шиплю");
        }
    }
}

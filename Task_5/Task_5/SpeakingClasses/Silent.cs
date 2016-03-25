using System;

namespace Task_5.SpeakingClasses
{
    class Silent : ISpeaking
    {
        public void Speak()
        {
            Console.WriteLine("Я молчу");
        }
    }
}

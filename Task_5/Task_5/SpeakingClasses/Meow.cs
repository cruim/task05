using System;

namespace Task_5.SpeakingClasses
{
    public class Meow : ISpeaking
    {
        public void Speak()
        {
            Console.WriteLine("Я мяукаю");
        }
    }
}

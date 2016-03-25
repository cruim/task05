using System;

namespace Task_5.SpeakingClasses
{
    class Quack : ISpeaking
    {
        public void Speak()
        {
			Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Я крякаю");
			Console.ResetColor();
        }
    }
}

using System;
using Task_5.Interfaces;

namespace Task_5.KindOfAnamalClasses
{
    class Fish : IKindOfAnimal
    {
        public void BeCalled()
        {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Я рыба");
			Console.ResetColor();
        }
    }
}

using System;
using Task_5.Interfaces;

namespace Task_5
{
    public class Cat : IKindOfAnimal
    {
        public void BeCalled()
        {
			Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Я кот ");
			Console.ResetColor();
        }
        
    }
}

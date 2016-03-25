using System;
using Task_5.Interfaces;

namespace Task_5.KindOfAnamalClasses
{
    class Duck : IKindOfAnimal
    {
        public void BeCalled()
        {
            Console.WriteLine("Я утка");
        }
    }
}

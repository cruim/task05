using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Running : IMoving
    {
        public void Move()
        {
            Console.WriteLine("Я бегу");
        }
    }
}

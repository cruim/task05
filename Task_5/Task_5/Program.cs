using System;
using NLog;
using Task_5.KindOfAnamalClasses;
using Task_5.SpeakingClasses;
using System.IO;

namespace Task_5
{
    class Program
    {

        static void Main(string[] args)
        {
			Logger logger = LogManager.GetCurrentClassLogger();
			
            start:
            //ConsoleKeyInfo cki;

            while (true)
            {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Для выхода из программы нажмите Esq");
				Console.ResetColor();
				Console.WriteLine("Выберете животное(нажмите соответствующую цифру):\n" +
                                  "Кошка(1), Утка(2), Рыба(3)");
				
				//cki = Console.ReadKey(true);
	            
				//if (cki.Key == ConsoleKey.Escape) break;

                var choice = Console.ReadLine();
		            switch (choice)
		            {
			            case "1":
				            Cat cat = new Cat();
				            cat.BeCalled();
							
				            break;
			            case "2":
				            Duck duck = new Duck();
				            duck.BeCalled();
				            break;
			            case "3":
				            Fish fish = new Fish();
				            fish.BeCalled();
							break;
						case "q": Environment.Exit(0);
							break;
						default:
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Вводите только предложеные цифры!");
								logger.Info("Попытка ввода некорректных данных в блоке выбора животного");
								goto start;
							}

		            }
	            
	            

	            Console.WriteLine("Выберете вариант передвижения для вашего животного\n" +
                                  "Бегать(1), Плавать(2), Летать(3), Нырять(4)");

				//cki = Console.ReadKey(true);
				//if (cki.Key == ConsoleKey.Escape) break;

                var choice1 = Console.ReadLine();

                if ((choice == "1" && choice1 == "3") || (choice == "1" && choice1 == "4"))
                {
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Кот не умеет летать и не будет нырять!");
                    goto start;

                }
                if ((choice == "3" && choice1 == "1") || (choice == "3" && choice1 == "3"))
                {
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Рыба не умеет летать и бегать!");
                    goto start;
                }


                switch (choice1)
                {
                    case "1":
                        Animal animalRunning = new Animal(_moving: new Running());
                        animalRunning.Moving.Move();
                        break;
                    case "2":
                        Animal animalSwimming = new Animal(_moving: new Swimming());
                        animalSwimming.Moving.Move();
                        break;
                    case "3":
                        Animal animalFlying = new Animal(_moving: new Flying());
                        animalFlying.Moving.Move();
                        break;
                    case "4":
                        Animal animalDiving = new Animal(_moving: new Diving());
                        animalDiving.Moving.Move();
                        break;
					case "q": Environment.Exit(0);
						break;
                    default:
                    {
						Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вводите только предложеные цифры!");
						logger.Info("Попытка ввода некорретных данных в блоке выбора движения животного");
                        goto start;
                    }

                }


                Console.WriteLine("Выберете вариант издаваемых звуков для вашего животного\n" +
                                  "Шипеть(1), Мяукать(2), Крякать(3), Безмолствовать(4)");

				//cki = Console.ReadKey(true);
				//if (cki.Key == ConsoleKey.Escape) break;

                var choice2 = Console.ReadLine();

                if (choice == "1" && choice2 == "3")
                {
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коты не крякают!");
                    goto start;
                }
                if (choice == "2" && choice2 == "2")
                {
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Утки не мяукают");
                    goto start;
                }
                if ((choice == "3" && choice2 == "1") || (choice == "3" && choice2 == "2") || (choice == "3" && choice2 == "3"))   
                {
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Рыбы не издают звуков");
                    goto start;
                }


                switch (choice2)
                {
                    case "1":
                        Animal animalHiss = new Animal(_speaking: new Hiss());
                        animalHiss.Speaking.Speak();
                        break;
                    case "2":
                        Animal animalMeow = new Animal(_speaking: new Meow());
                        animalMeow.Speaking.Speak();
                        break;
                    case "3":
                        Animal animalQuack = new Animal(_speaking: new Quack());
                        animalQuack.Speaking.Speak();
                        break;
                    case "4":
                        Animal animalSilent = new Animal(_speaking: new Silent());
                        animalSilent.Speaking.Speak();
                        break;
					case "q": Environment.Exit(0);
						break;
                    default:
                    {
						Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вводите только предложеные цифры!");
						logger.Info("Попытка ввода некорретных данных в блоке выбора издаваемых звуков животного");
                        goto start;
                    }


                }



            }
        }
    }
}
/*для выхода из программы нажатием одной кнопки, использовал конструкцию 
                                 cki = Console.ReadKey(true);
				                 if (cki.Key == ConsoleKey.Escape) break;
видимо из-за подряд идущих Console.ReadKey и Console.ReadLine приходилось дважды
нажимать клавишу ввода варианта ответа(например "1"). Поэтому решил добавить 
 дополнительный case*/
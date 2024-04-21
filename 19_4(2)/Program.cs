using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_4_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pass> register = new List<Pass>
        {
            new TeacherPass("Иван", "Иванов", "Иванович", "Физика", "Астрофизика"),
            new StudentPass("Петр", "Петров", "Петрович", "Математика", 2018),
            new BuilderPass("Сергей", "Сергеев", "Сергеевич", "Строительство", DateTime.Parse("2020-01-01"), DateTime.Parse("2021-01-01")),
            new StudentPass("Марков", "Кирилл", "Александрович", "Программирование", 2022)
        };

            DateTime currentDate = DateTime.Now;

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Вывести информацию о всех пропусках");
                Console.WriteLine("2. Вывести информацию о пропусках, которые должны быть аннулированы");
                Console.WriteLine("3. Вывести информацию о пропусках, которые должны быть обновлены");
                Console.WriteLine("4. Выход");
                var key = Console.ReadKey(true);  // Читаем символ без отображения на экране

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("\nИнформация о всех пропусках:");

                        Console.WriteLine("\nПреподаватели:");
                        foreach (var pass in register)
                        {
                            if (pass is TeacherPass)
                            {
                                pass.Info();
                            }
                        }

                        Console.WriteLine("\nСтуденты:");
                        foreach (var pass in register)
                        {
                            if (pass is StudentPass)
                            {
                                pass.Info();
                            }
                        }

                        Console.WriteLine("\nСтроители:");
                        foreach (var pass in register)
                        {
                            if (pass is BuilderPass)
                            {
                                pass.Info();
                            }
                        }
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("\nИнформация о пропусках, которые должны быть аннулированы:");
                        foreach (var pass in register)
                        {
                            if (pass is IValidatorPass validator && !validator.ValidatePass(currentDate))
                            {
                                pass.Info();
                            }
                        }
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("\nИнформация о пропусках, которые должны быть обновлены:");
                        foreach (var pass in register)
                        {
                            if (pass is IValidatorPass validator && validator.ValidatePass(currentDate))
                            {
                                pass.Info();
                            }
                        }

                        break;
                    case ConsoleKey.D4:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

    }
}

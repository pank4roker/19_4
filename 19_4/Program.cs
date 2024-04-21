using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _19_4
 {
    class Program
     {
        static void Main(string[] args)
         {
            List<Touristfirm> touristfirms = new List<Touristfirm>();
            touristfirms.Add(new Touristfirm("Тиратекс", 2000, "A13B6", 10000));
            touristfirms.Add(new Touristfirm("Идемицу", 2010, "B78I9", 0));
            while (true)
             {
                WriteLine("Выберите действие:");
                WriteLine(" 1. Поиск ИНН и прибыли фирмы");
                WriteLine(" 2. Сумарная прибыль всех фирм");
                WriteLine(" 3. Наибольшая прибыль");
                WriteLine(" 4. Удаление фирм");
                WriteLine(" 5. Добавление новой фирмы");
                WriteLine(" 6. Вывести все фирмы");
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine(" 7. Выйти");
                ResetColor();
                int key = Convert.ToInt32(ReadLine());
                switch (key)
                 { 
                    
                    case 1:
                        Clear();
                        Console.Write("Введите название фирмы: ");
                        string names = Console.ReadLine();
                        foreach (var elem in touristfirms)
                         {
                            if (elem.Name == names)
                             {
                                Console.WriteLine($"ИНН фирмы:  {elem.Inn};Прибыль:  {elem.Profit}$");
                            }
                            else
                             {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($"Такой фирмы нет  {names}\n");
                                Console.ResetColor();
                            }
                        }
                        break;
                    case 2:
                        Clear();
                        double totalprofit = 0;
                        foreach (var elem in touristfirms)
                         {
                            totalprofit += elem.Profit;
                        }
                        Console.WriteLine($"Сумма прибыли всех фирм :  {totalprofit}");
                        break;
                    case 3:
                        Clear();
                        touristfirms.Sort();
                        foreach (var elem in touristfirms)
                         {
                            Console.WriteLine($"Наибольшую прибыль имеет: {touristfirms[touristfirms.Count - 1].Name}  {touristfirms[touristfirms.Count - 1].Profit}");
                        }
                        break;
                    case 4:
                        Clear();
                        Touristfirm tofirm = null;
                        foreach (var elem in touristfirms)
                         {
                            if (elem.Profit == 0)
                             {
                                tofirm = elem;
                            }
                        }
                        touristfirms.Remove(tofirm);
                        Console.WriteLine("Обонкротившееся фирмы были удалены из списка");
                        break;
                    case 5:
                        Clear();
                        Write("Введите название:");
                        string name = ReadLine();
                        Write("Введите год создания:");
                        int year = Convert.ToInt32(ReadLine());
                        Write("Введите ИНН:");
                        string inn = ReadLine();
                        Write("Введите прибыль:");
                        double profit = Convert.ToDouble(ReadLine());
                        Touristfirm firm = new Touristfirm(name, year, inn, profit);
                        touristfirms.Add(firm);
                        break;
                    case 6:
                        Clear();
                        touristfirms.Sort();
                        foreach (var elem in touristfirms)
                         {
                            elem.Info();
                        }
                        break; 
                    case 7:return;
                        default : Console.WriteLine("Повторите");break;
                }
                Console.ReadKey();
            }
        }
    }
}

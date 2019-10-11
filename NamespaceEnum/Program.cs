using System;
using Finance;
using Finance.Network;
using BankInfo = Finance.Account;

namespace NamespaceEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account();
            //Console.WriteLine(account);

            //BankInfo account1 = new BankInfo();
            //Console.WriteLine(account1);

            //Finance.Local local = new Finance.Local();

            //Dictionary.Seasons seasons = Dictionary.Seasons.Undefined;

            //string input = Console.ReadLine();

            //int month = Int32.Parse(input);

            //switch (month)
            //{
            //    case 1:                    
            //    case 2:                    
            //    case 12:
            //        {
            //            seasons = Dictionary.Seasons.Winter;
            //            break;
            //        }
            //    case 3:
            //    case 4:
            //    case 5:
            //        {
            //            seasons = Dictionary.Seasons.Spring;
            //            break;
            //        }
            //    case 6:
            //    case 7:
            //    case 8:
            //        {
            //            seasons = Dictionary.Seasons.Summer;
            //            break;
            //        }
            //    case 9:
            //    case 10:
            //    case 11:
            //        {
            //            seasons = Dictionary.Seasons.Autumn;
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Неправильный номер месяца");
            //            break;
            //        }
            //}

            //Array array = Enum.GetValues(typeof(Dictionary.Seasons));

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //if (Dictionary.Colours.Red < Dictionary.Colours.Green)
            //{
            //    Console.WriteLine("Больше");
            //}

            //Console.WriteLine((int)Dictionary.Colours.Red);

            Film film = new Film();

            film.Title = "The Matrix";
            film.Cash = 1000000;
            film.Date = new DateTime(2000, 5, 12);
            film.Genre = Dictionary.Genre.Боевик;

            Console.WriteLine(film);

            Film film2 = new Film("The Matrix 2", 5000000, new DateTime(2002, 8, 12), new Producer("Br. Wachowski", new DateTime(1991, 12, 3)), Dictionary.Genre.Боевик);

            Console.WriteLine(film2);

            Producer producer = new Producer("Br. Wachowski", new DateTime(1991, 12, 3));
            Console.WriteLine(producer);

        }
    }
}

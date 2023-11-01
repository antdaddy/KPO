using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    class Menu
    {
        public static void m()
        {
            while (true)
            {
                Autorization.Auto();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Прием поставки");
                Console.WriteLine("2 - Информация о наличии товара на складе");
                Console.WriteLine("3 - Возврат товара");
                Console.WriteLine("4 - Продажа товара");
                Console.WriteLine("5 - Выход");
                string line = Console.ReadLine();
                switch (line)
                {
                    case "1":
                        Delivery.D();
                        break;
                    case "2":
                        Search.S();
                        break;
                    case "3":
                        Return.R();
                        break;
                    case "4":
                        NewCheck.N();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}

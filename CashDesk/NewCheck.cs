using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    class NewCheck
    {
        public static void N()
        {
            while (true)
            {
                Console.WriteLine("Для продажи товара введите его артикул. Для выхода - esc");
                string line = Console.ReadLine();
                if (line == "esc")
                    break;
                else
                {
                    Console.WriteLine("Введите количество покупаемого товара данного артикула");
                    string Value = Console.ReadLine();
                    Stock.Corect(false, Convert.ToInt32(line), Convert.ToInt32(Value));
                }
            }
        }
    }
}

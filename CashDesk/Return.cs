using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    class Return
    {
        public static void R()
        {
            while (true)
            {
                Console.WriteLine("Для возврата товара введите его артикул. Для выхода - esc");
                string line = Console.ReadLine();
                if (line == "esc")
                    break;
                else
                {
                    Console.WriteLine("Введите количество возвращаемого товара данного артикула");
                    string Value = Console.ReadLine();
                    Stock.Corect(true, Convert.ToInt32(line), Convert.ToInt32(Value));
                }
            }
        }
    }
}

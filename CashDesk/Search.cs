using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CashDesk
{
    class Search
    {
        public static void S()
        {
            List<Product> Pr = Stock.ReadStock();
            Console.WriteLine("Для получения информации о количестве товара на складе введите его артикул. Для выхода - esc");
            string line = Console.ReadLine();
            int st = 0;
            bool f = false;
            if (line != "esc")
            {
                foreach (Product i in Pr)
                {
                    if (i.Article == Convert.ToInt32(line))
                    {
                        st = i.Stock;
                        f = true;
                    }
                }
                if (f)
                {
                    Console.WriteLine("На складе есть:");
                    Console.WriteLine(st);
                }
                else
                    Console.WriteLine("Товара с таким артикулом нет на складе");
            }
        }
    }
}

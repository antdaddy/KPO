using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CashDesk
{
    class Autorization
    {
        public static List<Employee> ReadEmployee()
        {
            FileStream file1 = new FileStream("C:/Users/ant_daddy/OneDrive/Рабочий стол/KONSTRUIROVANIE/Dzhugeli/CashDesk/dbEmployee.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            List<Employee> Pr0 = new List<Employee>();
            string art, st;
            while (!reader.EndOfStream)
            {
                art = reader.ReadLine();
                st = reader.ReadLine();
                Employee p1 = new Employee();
                p1.Login = art;
                p1.Password = st;
                Pr0.Add(p1);
            }
            reader.Close();
            return Pr0;
        }
        public static void WriteEmployee(List<Employee> Pr)
        {
            FileStream file2 = new FileStream("C:/Users/ant_daddy/OneDrive/Рабочий стол/KONSTRUIROVANIE/Dzhugeli/CashDesk/dbEmployee.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file2);
            foreach (Employee i in Pr)
            {
                writer.WriteLine(i.Login);
                writer.WriteLine(i.Password);
            }
            writer.Close();
            Console.ReadLine();
        }
        public static void NewEmployee()
        {
            List<Employee> E0 = ReadEmployee();
            while (true)
            {
                Console.WriteLine("Для создания нового сотрудника введите логин. Для выхода - esc");
                string line1 = Console.ReadLine();
                if (line1 == "esc")
                    break;
                else
                {
                    bool f0 = false;
                    foreach (Employee i in E0)
                    {
                        if (i.Login == line1)
                            f0 = true;
                    }
                    if (f0)
                        Console.WriteLine("Сотрудник с таким логином уже есть в базе");
                    else
                    {
                        Employee E = new Employee();
                        E.Login = line1;
                        E.GenerateNewPassword();
                        Console.WriteLine("Пароль нового сотрудника:");
                        Console.WriteLine(E.Password);
                        E0.Add(E);
                    }
                }
            }
            WriteEmployee(E0);
        }
        public static void Auto()
        {
            while (true)
            {
                Console.WriteLine("Введите логин сотрудника:");
                string l = Console.ReadLine();
                List<Employee> E1 = ReadEmployee();
                Employee Em = new Employee();
                bool fl = false;
                foreach (Employee i in E1)
                {
                    if (i.Login == l)
                    {
                        Em = i;
                        fl = true;
                    }
                }
                if (!fl)
                {
                    Console.WriteLine("Сотрудника с таким логином не существует");
                    Console.WriteLine("1 - создать нового сотрудника");
                    Console.WriteLine("2 - повторить авторизацию");
                    string l1 = Console.ReadLine();
                    if (l1 == "1")
                    {
                        NewEmployee();
                    }
                }
                else
                {
                    Console.WriteLine("Введите пароль сотрудника:");
                    string l2 = Console.ReadLine();
                    if (l2 == Em.Password)
                        break;
                    else
                    {
                        Console.WriteLine("Пароль не верен");
                        Console.WriteLine("1 - повторить авторизацию");
                        Console.WriteLine("2 - запросить новый пароль");
                        string l3 = Console.ReadLine();
                        if (l3 == "2")
                        {
                            foreach (Employee i in E1)
                            {
                                if (i.Login == l)
                                {
                                    i.GenerateNewPassword();
                                    Console.WriteLine("Пароль нового сотрудника:");
                                    Console.WriteLine(i.Password);
                                }
                            }
                            WriteEmployee(E1);
                            break;
                        }
                    }
                }
            }
        }
    }
}

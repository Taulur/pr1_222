using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main (string[] args)
        {
            int n, m, t, yearnow;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите текущий год : ");
                    yearnow = Convert.ToInt32(Console.ReadLine());
                    if (yearnow >= 2000 && yearnow <= 2024)
                    {
                        break;
                    }
                }
                catch { }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите количество работников : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n > 0)
                    {
                        break;
                    }
                }
                catch { }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите количество месяцев работы : ");
                    m = Convert.ToInt32(Console.ReadLine());
                    if (m > 0)
                    {
                        break;
                    }
                }
                catch { }
            }
            int[] bday = new int[n];
            int[] day = new int[n];
            int[] month = new int[n];
            int[] year = new int[n];
            for (int i = 0; i < bday.Length; i++)  // День рождения
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Введите дату рождение {i + 1} работника");
                        Console.WriteLine("День :");
                        day[i] = Convert.ToInt32(Console.ReadLine());
                        if (day[i] > 0 && day[i] <= 31)
                        {
                            break;
                        }
                    }
                    catch { }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Месяц :");
                        month[i] = Convert.ToInt32(Console.ReadLine());
                        if (month[i] > 0 && month[i] <= 12)
                        {
                            break;
                        }
                    }
                    catch { }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Год :");
                        year[i] = Convert.ToInt32(Console.ReadLine());
                        if (year[i] > 1900 && year[i] <= 2005)
                        {
                            break;
                        }
                    }
                    catch { }
                }
                DateTime date = new DateTime(year[i], month[i], day[i]);
                Console.WriteLine(date);
            }
            int[,] work = new int[n + 1, m];
            for (int i = 1; i < work.GetLength(0); i++) // ЗП для каждого работника
            {
                for (int j = 0; j < work.GetLength(1); j++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine($"Введите заработную плату работника {i}, месяца {j + 1}");
                            work[i, j] = Convert.ToInt32(Console.ReadLine());
                            if (work[i, j] > 0)
                            {
                                break;
                            }
                        }
                        catch { }
                    }
                }
                Console.WriteLine();
            }
            Console.Write("             ");
            for (int i = 0; i < work.GetLength(0); i++) // Таблица
            {
                if (i != 0)
                {
                    Console.Write($"Работник {i}");
                }
                for (int j = 0; j < work.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        Console.Write($"Месяц {j + 1}  ");
                    }
                    else
                    {
                        Console.Write($"{work[i, j],8}");
                    }
                }
                Console.WriteLine();
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Для какого работника найти наибольшее зп за все месяцы?");
                    t = Convert.ToInt32(Console.ReadLine());
                    if (t > 0 && t <= n)
                    {
                        break;
                    }
                }
                catch
                {

                }
            }
            int max = 0;
            for (int j = 0; j < work.GetLength(1); j++)
            {
                if (work[t, j] > max)
                    max = work[t, j];
            }
            Console.WriteLine($"Наибольшее зп за все месяцы у работника {t} - {max}");
            //DateTime date = new DateTime(yearnow, 1, 1);
            //int chillcount = 0, hardcount = 0;
            //while (true)
            //{
            //    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            //    {
            //        chillcount++;
            //    }
            //    else
            //    {
            //        hardcount++;
            //    }
            //    date = date.AddDays(1.0);
            //    if (date.Month == 2)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(chillcount);
            //Console.WriteLine(hardcount);
        }
    }
}

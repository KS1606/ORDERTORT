using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заказ_тортов
{
    internal class zakas
    {
        public static void Zakas()
        {
            Base();
        }
        private static void Opisanie()
        {
            tort tort = new tort();
            tort.osnova = new string[] { "Заказ тортов в кондитерской КОРГИ, торты на ваш выбор ", "Выберете параметры торта", "------------------------", "  Форма тора ", "  Размер торта ", "  Вкус коржей ", "  Колличество коржей ", "  Глазурь ", "  Декор ", "  Конец заказа" };
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine(tort.osnova[0 + a]);
            }
        }
        private static void Base()
        {
            tort tort = new tort();
            tort.form = new string[] { "  Звезда - 900 ", "  Круг - 500 ", "  Лапки корги - 1000 ", "  Квадрат - 600" };
            tort.size = new string[] { "  Маленький (16 - сантиметров, 8 - порций) - 1000", "  Средний (18 - сантиметров, 10 - порций) - 1300", "  Большой (28 - сантиметров, 24 - порции)-2000" };
            tort.flavor = new string[] { "  Медовый - 200", "  Шоколадный - 250", "  Ванильный - 150", "  Малиновый - 200", "  Клубничный - 150" };
            tort.cakes = new string[] { "  1 корж - 250", "  2 коржа - 500", "  3 коржа - 750", "  4 коржа - 1000" };
            tort.icing = new string[] { "  Манго-маракуя - 250", "  Шоколад - 150", "  Ягоды - 200", "  Бизе - 150", "  Драже - 100" };
            tort.decor = new string[] { "  Шаколад - 150", "  Крем - 150 ", "  Велюр - 200" };
            string[] z = new string[] { "" };
            string[] z1 = new string[] { "" };
            string[] z2 = new string[] { "" };
            string[] z3 = new string[] { "" };
            string[] z4 = new string[] { "" };
            string[] z5 = new string[] { "" };
            int summa = 0;
            Opisanie();
            Console.WriteLine("Цена : " + summa);
            Console.Write("Состав торта : ");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                {
                    int position = 3;
                    while (key.Key != ConsoleKey.Enter)
                    {
                        if (key.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                        }
                        if (key.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                        }
                        Console.Clear();
                        Opisanie();
                        Console.WriteLine("Цена : " + summa);
                        Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0] + z4[0] + z5[0]);
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        key = Console.ReadKey();
                    }
                    if (position == 3)
                    {
                        Console.Clear();
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine(tort.form[0 + i]);
                        }
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                        {
                            int positin = 1;
                            while (key.Key != ConsoleKey.Enter)
                            {
                                if (key.Key == ConsoleKey.UpArrow)
                                {
                                    positin--;
                                }
                                if (key.Key == ConsoleKey.DownArrow)
                                {
                                    positin++;
                                }
                                Console.Clear();
                                for (int i = 0; i < 4; i++)
                                {
                                    Console.WriteLine(tort.form[0 + i]);
                                }
                                Console.SetCursorPosition(0, positin);
                                Console.WriteLine("->");
                                key = Console.ReadKey();
                                if (key.Key == ConsoleKey.Escape)
                                {
                                    Console.Clear();
                                }
                            }
                            if (positin == 0)
                            {
                                Console.Clear();
                                z = new string[1] { " Звезда - 900. " };
                                summa = summa + 900;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0]);
                            }
                            if (positin == 1)
                            {
                                Console.Clear();
                                z = new string[1] { " Круг - 500. " };
                                summa = summa + 500;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0]);
                            }
                            if (positin == 2)
                            {
                                Console.Clear();
                                z = new string[1] { " Лапки корги - 1000. " };
                                summa = summa + 1000;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0]);
                            }
                            if (positin == 3)
                            {
                                Console.Clear();
                                z = new string[1] { "  Квадрат - 600. " };
                                summa = summa + 600;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0]);
                            }
                        }
                    }
                    if (position == 4)
                    {
                        Console.Clear();
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(tort.size[0 + i]);
                        }
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                        {
                            int positin = 1;
                            while (key.Key != ConsoleKey.Enter)
                            {
                                if (key.Key == ConsoleKey.UpArrow)
                                {
                                    positin--;
                                }
                                if (key.Key == ConsoleKey.DownArrow)
                                {
                                    positin++;
                                }
                                Console.Clear();
                                for (int i = 0; i < 3; i++)
                                {
                                    Console.WriteLine(tort.size[0 + i]);
                                }
                                Console.SetCursorPosition(0, positin);
                                Console.WriteLine("->");
                                key = Console.ReadKey();
                                if (key.Key == ConsoleKey.Escape)
                                {
                                    Console.Clear();
                                }
                            }
                            if (positin == 0)
                            {
                                Console.Clear();
                                Console.Clear();
                                z1 = new string[1] { "Маленький (16 - сантиметров, 8 - порций) - 1000. " };
                                summa = summa + 1000;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0]);
                            }
                            if (positin == 1)
                            {
                                Console.Clear();
                                z1 = new string[1] { "Средний (18 - сантиметров, 10 - порций) - 1300. " };
                                summa = summa + 1300;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0]);
                            }
                            if (positin == 2)
                            {
                                Console.Clear();
                                z1 = new string[1] { "Большой (28 - сантиметров, 24 - порции)-2000. " };
                                summa = summa + 2000;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0]);
                            }
                        }
                    }
                    if (position == 5)
                    {
                        Console.Clear();
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(tort.flavor[0 + i]);
                        }
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                        {
                            int positin = 1;
                            while (key.Key != ConsoleKey.Enter)
                            {
                                if (key.Key == ConsoleKey.UpArrow)
                                {
                                    positin--;
                                }
                                if (key.Key == ConsoleKey.DownArrow)
                                {
                                    positin++;
                                }
                                Console.Clear();
                                for (int i = 0; i < 5; i++)
                                {
                                    Console.WriteLine(tort.flavor[0 + i]);
                                }
                                Console.SetCursorPosition(0, positin);
                                Console.WriteLine("->");
                                key = Console.ReadKey();
                                if (key.Key == ConsoleKey.Escape)
                                {
                                    Console.Clear();
                                }
                            }
                            if (positin == 0)
                            {
                                Console.Clear();
                                z2 = new string[1] { "Медовый - 200. " };
                                summa = summa + 200;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0]);
                            }
                            if (positin == 1)
                            {
                                Console.Clear();
                                z2 = new string[1] { "Шоколадный - 250. " };
                                summa = summa + 250;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0]);
                            }
                            if (positin == 2)
                            {
                                Console.Clear();
                                z2 = new string[1] { "Ванильный - 150. " };
                                summa = summa + 150;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0]);
                            }
                            if (positin == 3)
                            {
                                Console.Clear();
                                z2 = new string[1] { "Малиновый - 200. " };
                                summa = summa + 200;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0]);
                            }
                            if (positin == 4)
                            {
                                Console.Clear();
                                z2 = new string[1] { "Клубничный - 150. " };
                                summa = summa + 150;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0]);
                            }
                        }
                    }
                    if (position == 6)
                    {
                        Console.Clear();
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine(tort.cakes[0 + i]);
                        }
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                        {
                            int positin = 1;
                            while (key.Key != ConsoleKey.Enter)
                            {
                                if (key.Key == ConsoleKey.UpArrow)
                                {
                                    positin--;
                                }
                                if (key.Key == ConsoleKey.DownArrow)
                                {
                                    positin++;
                                }
                                Console.Clear();
                                for (int i = 0; i < 4; i++)
                                {
                                    Console.WriteLine(tort.cakes[0 + i]);
                                }
                                Console.SetCursorPosition(0, positin);
                                Console.WriteLine("->");
                                key = Console.ReadKey();
                                if (key.Key == ConsoleKey.Escape)
                                {
                                    Console.Clear();
                                }
                            }
                            if (positin == 0)
                            {
                                Console.Clear();
                                z3 = new string[1] { "1 корж - 250. " };
                                summa = summa + 250;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0]);
                            }
                            if (positin == 1)
                            {
                                Console.Clear();
                                z3 = new string[1] { "2 коржа - 500. " };
                                summa = summa + 500;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0]);
                            }
                            if (positin == 2)
                            {
                                Console.Clear();
                                z3 = new string[1] { "3 коржа - 750. " };
                                summa = summa + 750;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0]);
                            }
                            if (positin == 3)
                            {
                                Console.Clear();
                                z3 = new string[1] { "4 коржа - 1000. " };
                                summa = summa + 1000;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0]);
                            }
                        }
                    }
                    if (position == 7)
                    {
                        Console.Clear();
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(tort.icing[0 + i]);
                        }
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                        {
                            int positin = 1;
                            while (key.Key != ConsoleKey.Enter)
                            {
                                if (key.Key == ConsoleKey.UpArrow)
                                {
                                    positin--;
                                }
                                if (key.Key == ConsoleKey.DownArrow)
                                {
                                    positin++;
                                }
                                Console.Clear();
                                for (int i = 0; i < 5; i++)
                                {
                                    Console.WriteLine(tort.icing[0 + i]);
                                }
                                Console.SetCursorPosition(0, positin);
                                Console.WriteLine("->");
                                key = Console.ReadKey();
                                if (key.Key == ConsoleKey.Escape)
                                {
                                    Console.Clear();
                                }
                            }
                            if (positin == 0)
                            {
                                Console.Clear();
                                z4 = new string[1] { "Манго-маракуя - 250. " };
                                summa = summa + 250;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0] + z4[0]);
                            }
                            if (positin == 1)
                            {
                                Console.Clear();
                                z4 = new string[1] { "Шоколад - 150. " };
                                summa = summa + 150;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0] + z4[0]);
                            }
                            if (positin == 2)
                            {
                                Console.Clear();
                                z4 = new string[1] { "Ягоды - 200. " };
                                summa = summa + 200;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0] + z4[0]);
                            }
                            if (positin == 3)
                            {
                                Console.Clear();
                                z4 = new string[1] { "Бизе - 150. " };
                                summa = summa + 150;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0] + z4[0]);
                            }
                            if (positin == 4)
                            {
                                Console.Clear();
                                z4 = new string[1] { "Драже - 100. " };
                                summa = summa + 100;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0] + z4[0]);
                            }
                        }

                    }
                    if (position == 8)
                    {
                        Console.Clear();
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(tort.decor[0 + i]);
                        }
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                        {
                            int positin = 1;
                            while (key.Key != ConsoleKey.Enter)
                            {
                                if (key.Key == ConsoleKey.UpArrow)
                                {
                                    positin--;
                                }
                                if (key.Key == ConsoleKey.DownArrow)
                                {
                                    positin++;
                                }
                                Console.Clear();
                                for (int i = 0; i < 3; i++)
                                {
                                    Console.WriteLine(tort.decor[0 + i]);
                                }
                                Console.SetCursorPosition(0, positin);
                                Console.WriteLine("->");
                                key = Console.ReadKey();
                                if (key.Key == ConsoleKey.Escape)
                                {
                                    Console.Clear();
                                }
                            }
                            if (positin == 0)
                            {
                                Console.Clear();
                                z5 = new string[1] { "Шаколад - 150. " };
                                summa = summa + 150;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0] + z4[0] + z5[0]);
                            }
                            if (positin == 1)
                            {
                                Console.Clear();
                                z5 = new string[1] { "Крем - 150. " };
                                summa = summa + 150;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0] + z4[0] + z5[0]);
                            }
                            if (positin == 2)
                            {
                                Console.Clear();
                                z5 = new string[1] { "Велюр - 200. " };
                                summa = summa + 200;
                                Opisanie();
                                Console.WriteLine("Цена : " + summa);
                                Console.WriteLine("Состав торта : " + z[0] + z1[0] + z2[0] + z3[0] + z4[0] + z5[0]);
                            }
                        }
                    }
                    if (position == 9)
                    {
                        Console.Clear();
                        DateTime date1 = DateTime.Now;
                        string txt = " Заказ от : ";
                        string txt1 = " Цена : ";
                        string txt2 = " Состав торта: ";
                        string b = summa.ToString();
                        string laber = DateTime.Now.ToString();
                        string a = z[0].ToString();
                        string a1 = z1[0].ToString();
                        string a2 = z2[0].ToString();
                        string a3 = z3[0].ToString();
                        string a4 = z4[0].ToString();
                        string a5 = z5[0].ToString();
                        Console.WriteLine(" Ваш заказ принят ! Что бы сделть еще заказ нажмите на Escape. ");
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", "\n");
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", txt);
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", laber);
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", "\n");
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", txt1);
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", b);
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", "\n");
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", txt2);
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", a);
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", a1);
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", a2);
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", a3);
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", a4);
                        File.AppendAllText("C:\\Users\\KS\\OneDrive\\Рабочий стол\\История заказов.txt", a5);
                    }
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Base();
                    }

                }
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}

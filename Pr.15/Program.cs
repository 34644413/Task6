using System;

namespace ProductList
{
    class Program
    {
        // Оголошення перерахування з прапорцем для товарів
        enum Products
        {
            TV = 1,
            Refrigerator,
            Microwave,
            Printer,
            Scanner,
            Fax,
            Desktop,
            Laptop,
            Monitor
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Список товарiв:");
            Console.WriteLine("{0,-15} {1}", "Номер", "Назва");
            Console.WriteLine("--------------------------");

            // Виведення списку товарів
            foreach (Products p in Enum.GetValues(typeof(Products)))
            {
                Console.WriteLine("{0,-15} {1}", (int)p, p);
            }

            // Введення номерів товарів, які користувач хоче придбати
            Console.WriteLine("\nВведiть номери товарiв, якi хочете придбати (вiдокремлюйте комами):");
            string[] productsList = Console.ReadLine().Split(',');

            // Виведення списку товарів, які користувач хоче придбати
            Console.WriteLine("\nВаш список товарiв:");
            foreach (string p in productsList)
            {
                int productNum = int.Parse(p.Trim());
                Console.WriteLine("{0,-15} {1}", productNum, Enum.GetName(typeof(Products), productNum));
            }

            // Виведення прізвища автора програми
            Console.WriteLine("\nАвтор програми: Веремеєв");

            // Виведення списків товарів по групах
            Console.WriteLine("\nСписок товарiв по групах:");
            Console.WriteLine("\nПобутова технiка:");
            Console.WriteLine("--------------------------");
            foreach (Products p in Enum.GetValues(typeof(Products)))
            {
                if ((int)p >= 1 && (int)p <= 3)
                {
                    Console.WriteLine("{0,-15} {1}", (int)p, p);
                }
            }

            Console.WriteLine("\nОргтехнiка:");
            Console.WriteLine("--------------------------");
            foreach (Products p in Enum.GetValues(typeof(Products)))
            {
                if ((int)p >= 4 && (int)p <= 6)
                {
                    Console.WriteLine("{0,-15} {1}", (int)p, p);
                }
            }

            Console.WriteLine("\nКомп'ютери i комплектуючi:");
            Console.WriteLine("--------------------------");
            foreach (Products p in Enum.GetValues(typeof(Products)))
            {
                if ((int)p >= 7 && (int)p <= 9)
                {
                    Console.WriteLine("{0,-15} {1}", (int)p, p);
                }
            }

            Console.ReadKey();
        }
    }
}

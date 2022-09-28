namespace Практическая_работа__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLineMessages (args);
            int vybor = Convert.ToInt32(Console.ReadLine());
            while (vybor != 4)
            {
                if (vybor == 1) RandomChislo(args);
                if (vybor == 2) TableOfMultiply(args);
                if (vybor == 3) DeliteliChisla(args);
                WriteLineMessages (args);
                vybor = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void WriteLineMessages(string[] args)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход из программы");
        }

        static void RandomChislo(string[] args)
        {
            Console.WriteLine("Угадай число от 0 до 100!");
            Random rnd = new Random();
            int RandomChislo = rnd.Next(0, 100);
            Console.WriteLine("Введите число: ");
            int ProstoChislo = Convert.ToInt32(Console.ReadLine());
            if (ProstoChislo >= 0 && ProstoChislo <= 100)
            {
                while (ProstoChislo != RandomChislo)
                {
                    if (ProstoChislo > RandomChislo)
                    {
                        Console.WriteLine("Введите число поменьше");
                    }
                    if (ProstoChislo < RandomChislo)
                    {
                        Console.WriteLine("Введите число побольше");
                    }
                    ProstoChislo = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Поздравляю! Вы Угадали число!");
            }
            else Console.WriteLine("Ошибка! Введите значение в промежутке [0;100]");
        }

        static void TableOfMultiply(string[] args)
        {
            Console.WriteLine("Таблица умножения: "); // София Алексеевна, я смог выполнить таблицу умножения только так. Я хотел попробовать сделать через массивы,
                                                      // Вы написали, что нужно сначала вписать значения в матрицу, а потом вывести через цикл.
                                                      // Я не понял как можно перемножить массивы правильно,
                                                      // да  и вообще вписать значения в матрицу через цикл без ввода с клавиатуры и поэтому исполнил именно так.
            for (int i = 1; i <= 9; i++) //rows
            {
                Console.WriteLine("\t");
                for (int j = 1; j <= 9; j++) // colums
                {
                    Console.Write("\t" + i * j);
                }
            }
            Console.WriteLine("\n");

        }

        static void DeliteliChisla(string[] args)
        {
            Console.WriteLine("Вывод делителей числа:");
            Console.WriteLine("Введите число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Делители: ");
            for (int i = chislo; i <= chislo; i--)
            {
                if (chislo != 0 && i != 0)
                {
                    if (chislo % i == 0)
                    {
                        if ((chislo / i) > 0) Console.Write(chislo / i + "\t");

                    }
                }
            }
            Console.WriteLine("\n");
        }
    }
}
namespace Практическая_работа__2
{
    internal class Program
    {
        static void Main()
        {
            int vybor =1;
            while (vybor != 4)
            {
                WriteLineMessages();
                vybor = Convert.ToInt32(Console.ReadLine());
                if (vybor == 1) RandomChislo();
                if (vybor == 2) TableOfMultiply();
                if (vybor == 3) DeliteliChisla();
            }
        }

        static void WriteLineMessages()
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход из программы");
        }

        static void RandomChislo()
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

        static void TableOfMultiply()
        {
            Console.WriteLine("Таблица умножения: ");
            for (int i = 1; i <= 9; i++) //rows
            {
                Console.WriteLine("\t");
                for (int j = 1; j <= 9; j++) // colums
                {
                    int[,] matrix = new int[10, 10];
                    matrix[i, j] = i * j;
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }

        static void DeliteliChisla()
        {
            Console.WriteLine("Вывод делителей числа:");
            Console.WriteLine("Введите число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Делители: ");
            for (int i = chislo; i <= chislo; i--)
            {
                if ((chislo != 0 && i != 0) && (chislo % i == 0))
                {
                    if ((chislo / i) > 0) Console.Write(chislo / i + "\t");

                }
            }
            Console.WriteLine("\n");
        }
    }
}
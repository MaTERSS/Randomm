/*С помощью Random получить число number, которое не больше 100. 
  Найти сумму всех положительных чисел меньше number (включая число), которые кратные 3 или 5. 
  (К примеру, это числа 3, 5, 6, 9, 10, 12, 15 и т.д.)*/
using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 100);
            Console.WriteLine($"Сгенерированное число: {number}");
            int sum = 0;
            int three = 3;
            int five = 5;

            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = i++;
                }
            }
            Console.WriteLine($"Сумма всех положительных чисел, кратных 3 или 5, меньше {number}: {sum}");
        }
    }
}

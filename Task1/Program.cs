namespace HelloWorld  
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Введите номер дня недели: ");
         int num_days = Convert.ToInt32(Console.ReadLine());
         Console.Write("Это ");
         if (num_days == 1) Console.WriteLine("Понедельник");
         if (num_days == 2) Console.WriteLine("Вторник");
         if (num_days == 3) Console.WriteLine("Среда");
         if (num_days == 4) Console.WriteLine("Четверг");
         if (num_days == 5) Console.WriteLine("Пятница");
         if (num_days == 6) Console.WriteLine("Суббота");
         if (num_days == 7) Console.WriteLine("Воскресенье");
        }
    }
}
//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//2. Напишите программу, которая будет выдавать название дня недели по заданному номеру. +

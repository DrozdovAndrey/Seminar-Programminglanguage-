namespace HelloWorld  //создать программу которая принимает число, а выводит 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: "); // все что мы считываем из терминала - это строка, поэтому конвертируем
            int number = Convert.ToInt32(Console.ReadLine());  // команда Convert конвертирует во что то, ToInt - во что, в целочисленные значения, 32 - 32 битная система исчисления
            int square = number * number;
            // если не хотим вводить переменную делаем так
            number*= number; // для начала ставим математический знак потом равно
            Console.WriteLine($"Квадрат числа: {square}, {number}"); // можно так сделать Console.WriteLine("Квадрат числа: ")
        }
    }
}

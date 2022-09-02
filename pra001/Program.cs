//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
//Ввод числа из консоли по приглашению
int Prompt(string message)
{
   Console.Write("message > ");          // вывод приглашения.
   string strValue;                      // обьявдения для ввода строки
   strValue = Console.ReadLine() ?? "0"; // вводими строку в консоли.(с консоли можно ввести только строку.)
   int value = int.Parse(strValue);      // преоброзование строки в целое число.
   return value;
}
int value = Prompt("Введите, число = ");
int result = value * value;          // Вычесление квадрата (заносим в переменную result)
System.Console.WriteLine($"Квадрат числа {value} равен {result} "); // Вывод.



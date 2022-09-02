// Напишите программу вычисления модуля  числа.
//2 -> 2
//-3 -> 3
//-7 -> 7

int Prompt(string message)
{
   Console.Write("Введите число > ");          // вывод приглашения.
   string strValue;                      // обьявдения для ввода строки
   strValue = Console.ReadLine() ?? "0"; // вводими строку в консоли.(с консоли можно ввести только строку.)
   int value = int.Parse(strValue);      // преоброзование строки в целое число.
   return value;
}
int value = Prompt("Введите число -> ");
int result;
if (value < 0)
{
   result = -value;
}
else
{
   result = value;
}
System.Console.WriteLine($"{value} ->{result}");
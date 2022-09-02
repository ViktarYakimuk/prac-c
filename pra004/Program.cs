// Напишите программу вычисления функций куба.
// x=f(a)

int Prompt(string message)
{
   Console.Write("Введите число > ");          // вывод приглашения.
   string strValue;                      // обьявдения для ввода строки
   strValue = Console.ReadLine() ?? "0"; // вводими строку в консоли.(с консоли можно ввести только строку.)
   int value = int.Parse(strValue);      // преоброзование строки в целое число.
   return value;
}

int value = Prompt("Введите число ->");
System.Console.WriteLine(value * value * value);





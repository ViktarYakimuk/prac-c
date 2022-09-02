//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
int Prompt(string message)
{
   Console.Write("message > ");          // вывод приглашения.
   string strValue;                      // обьявдения для ввода строки
   strValue = Console.ReadLine() ?? "0"; // вводими строку в консоли.(с консоли можно ввести только строку.)
   int value = int.Parse(strValue);      // преоброзование строки в целое число.
   return value;
}

string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

int value = Prompt("Введите день недели >");
int daysValue = value - 1;
System.Console.WriteLine($"{value}->{days[daysValue]}");
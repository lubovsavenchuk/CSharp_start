// Цикл FOR со счетчиком

string Method4(int count, string text) //показать "text" count раз
{
   string result = String.Empty; //начальное значение - пустая строка
   for (int i = 0; i < count; i ++)
   {
      result = result + text;
   }
   return result;
}
string res = Method4(5, "programistdofiga"); // вызов метода с указанием переменной string и новой переменной res
//Console.WriteLine(res);

// Вывод на экран таблицы умножения с использованием цикла в цикле
for (int i = 2; i <= 10; i ++)
{
   for (int j = 2; j <= 10; j ++)
   {
      Console.WriteLine($"{ i } * { j } = {i*j}"); // интерполяция строк!!!
   }
   //Console.WriteLine();
}


// Задача: имеется текст. Нужно изменить в нем регистр букв "к" и "С", заменить пробелы черточками.

string text = "— Я думаю, — сказал князь улыбаясь, — что ежели бы вас послали вместо нашего милого  Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012345
// s[3] -> r
string Replace(string text, char OldValue, char NewValue);
{
   string Result = String.Empty; //вывод пустой строки
   int length = text.Length;      // показывает кол-во символов в строке
   for(int i = 0; i < length; i ++)
   {
      if (text[i] == OldValue)
      {
         Result = Result + $"{NewValue}"; //замена символа, который совпал с тем, который надо изменить
      }
      else
      {
         Result = Result + $"{text [i]}";  // остается текущий символ без изменений
      }
   }
   return Result;
}

string NewText = Replace(text, ' ', '|'); //замена пробелов на черточки
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace(NewText, 'к', 'К'); //замена регистра буков "к" -> "К"
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace(NewText, 'С', 'с'); //замена регистра буков "С" -> "с"
Console.WriteLine(NewText);
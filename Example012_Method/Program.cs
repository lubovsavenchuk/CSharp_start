// Виды методов
// Вид 1
void Method1()
{
   Console.WriteLine("Автор проекта: ");
}

// Вид 2
void Method2 (string msg)
{
   Console.WriteLine(msg);
}
//Method2("Text of the message"); // неименованый аргумент

void Method21 (string msg, int count)
{
   int i = 0;
   while(i < count)
   {
      Console.WriteLine(msg);
      i ++;
   }
  
}
//Method21("text of the message", 4); // именованный аргумент
//Method21(count: 4, msg: "text of the message"); // именованный аргумент

//Вид 3
int Method3()
{
   return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//Вид 4
string Method4(int count, string text) //показать "text" count раз
{
   int i = 0;
   string result = String.Empty; //начальное значение - пустая строка

   while (i < count)
   {
      result = result + text;
      i ++;
   }
   return result;
}
string res = Method4(5, "programistdofiga"); // вызов метода с указанием переменной string и новой переменной res
Console.WriteLine(res);

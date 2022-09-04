// создание массива в виде таблицы
string[,] table = new string [2,5];
// обращение к массиву для заполнения определенноой ячейки словом
table [1, 2] = "word";
// заполнение таблицы
for (int rows=0; rows < 2; rows++)
{
   for(int columns=0; columns < 5; columns++)
   {
      Console.WriteLine($"-{table[rows, columns]}-");
   }
}


//числовая таблица
int [,] matrix = new int[3,4];

// заполнение массива
void PrintArray(int[,]matr)
{
   for(int rows=0; rows < matr.GetLength(0); rows++)
   {
      for(int columns=0; columns < matr.GetLength(1); columns++)
      {
         Console.Write($"{matr[rows, columns]} ");
      }
   Console.WriteLine();
   }
}
// заполнение таблицы случайными числами
void FillArray(int[,] matr)
{
   for(int rows=0; rows < matr.GetLength(0); rows++)
   {
      for (int columns=0; columns < matr.GetLength(1); columns++)
      {
         //обращение к конкретным элемнтам на позициях rows и columns
         matr[rows, columns] = new Random().Next(1, 10);
      }
   }
}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
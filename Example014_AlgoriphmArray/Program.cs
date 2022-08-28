// Задача: упорядочить массив, используя алгоритм сортировки методом выбора

int[] arr = {8, 4, 9, 1, 3, 7, 5, 9, 4};
void PrintArray(int [] array)
{
   int count = array.Length; // получение кол-ва элементов
   for(int i = 0; i < count; i++)
   {
      Console.Write($"{array[i]} ");  //вывод на экран элементов массива
   }
   Console.WriteLine();
}

void SelectionSort (int[] array)     // упорядочивание массива от меньшего значения к большему
{
   for(int i = 0; i < array.Length - 1; i++)
   {
      int minPosition = i;  // запоминаем позицию рабочего элемента, с которым будут производится действия
      for(int j = i+1; j < array.Length; j++)  // поиск минимального элемента массива
      {
         if (array[j] < array[minPosition])    // сравнение текущего элемента с предполагаемым минимальным элементом
         {
            minPosition = j;
         }

      }
      int temporary = array[i]; // рабочая позиция
      array[i] = array[minPosition]; // изменение минимальной позиции на текущую: меняем местами старое и новое(текущее) значения
      array[minPosition] = temporary;
   }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
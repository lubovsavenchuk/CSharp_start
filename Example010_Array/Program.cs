// Найти элемент массива (index) равный find  в одномерном массиве array, состоящем из n элементов.

int[] array = {1,34, 7, 89, 12, 51, 34, 100};

int n = array.Length;
int find = 34;
int index = 0;

while (index < n)
{
   if (array[index] == find)
   {
      Console.WriteLine(index);
      break;
   }

   index++;
} 

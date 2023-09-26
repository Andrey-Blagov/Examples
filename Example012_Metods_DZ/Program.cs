// Задача упорядочить ряд цифр от большего к меньшему

int [] arr = {1,9,4,5,2,8,6,3,13};
void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($" {array[i]}");
    }
    System.Console.WriteLine();
}
void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
      int maxPosition = i;
      int j = i + 1;      
      while (j < array.Length)
      {
        if(array[j] > array[maxPosition]) maxPosition = j;
        j++;
      }
      int temporary = array[i];
      array[i] = array[maxPosition];
      array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

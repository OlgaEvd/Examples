
int[] arr = {5,8,9,45,78,2,7,9};

void PrintArr(int[] array)
{
 int count  = array.Length;

 for(int i = 0; i < count; i++)
 {
   Console.Write($"{array[i]} ");

 }
 Console.WriteLine();
}

PrintArr(arr);

void SelectionSort(int[] array)
{
for(int i = 0; i < array.Length - 1; i++)
{
int minPosition = i;
for(int j = i + 1; j < array.Length; j++)
{
if(array[j] < array[minPosition])
{
    minPosition = j;
}
}
 int temp = array[i];
 array[i] = array[minPosition];
 array[minPosition] = temp;

}

}


SelectionSort(arr);

PrintArr(arr);

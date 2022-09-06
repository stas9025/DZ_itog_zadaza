
string[] arr1 = new string[7] { "Russia", "1234", "hello", "-2", ":)", "5", "world" };
string[] arr2 = new string[arr1.Length];

void Array(string[] arr1, string[] arr2)
{
  int count = 0;
  for (int i = 0; i < arr1.Length; i++)
  {
    if (arr1[i].Length <= 3)
    {
      arr2[count] = arr1[i];
      count++;
    }
  }
  Console.Write("[{0}]", string.Join(", ", arr1));
  Console.Write(" -> ");
}

void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if(i == 0) Console.Write("[");
    if(i < array.Length - 1) Console.Write(array[i] + ", ");
    else Console.Write(array[i] + "]");
  }
}

Array(arr1, arr2);
PrintArray(arr2);

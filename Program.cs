// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам.
Console.Write("Введите колличество элементов массива, но не меньше трех ");
int NumberElementsArray = Convert.ToInt32(Console.ReadLine());
int MinLong  = 3;

if (NumberElementsArray >= MinLong)
{

  string[] arrayFirst = new string[NumberElementsArray];
  for (int i =0; i < NumberElementsArray; i++)
  {
    
    Console.WriteLine($"Введите {i+1} элемент");
    string NumberElements = Convert.ToString(Console.ReadLine())!;
    arrayFirst[i] = NumberElements;
  }


  int MinFinalArray = 0;
  int MaxFinalArray = 3;

  int LongFinalArray = new Random().Next(MinFinalArray,MaxFinalArray);
    
  string[] FinalArray = new string[LongFinalArray];
  for (int j = 0; j < LongFinalArray; j++)
    {
        int k = new Random().Next(0,NumberElementsArray);
         FinalArray[j] =  arrayFirst[k];
    }


  void PrintArray(string[] array)
   {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
      {
       Console.Write($" {array[i]} {";"} ");
       }
     Console.Write("]");
    }
    

  PrintArray(arrayFirst);
  Console.Write("->");
  PrintArray(FinalArray);

}
else
{
    Console.Write("Ошибка! Повторите ввод");
}
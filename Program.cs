// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам.
Console.Write("Введите колличество элементов массива ");
int NumberElementsArray = Convert.ToInt32(Console.ReadLine());
int MinLong  = 3;


  string[] ArrayFirst = new string[NumberElementsArray];
  for (int i =0; i < NumberElementsArray; i++)
  {
    Console.WriteLine($"Введите {i+1} элемент");
    string NumberElements = Convert.ToString(Console.ReadLine())!;
    ArrayFirst[i] = NumberElements;
  } 

  
    
  string[] TwolArray  = new string[ArrayFirst.Length];
  int count = 0;
  for (int j = 0; j < NumberElementsArray; j++)
    {
      if (ArrayFirst[j].Length <= MinLong) 
       {
         TwolArray[count] =  ArrayFirst[j];
         count++;
        }
     }

  string[] FinalArray  = new string[count];
  int LongFinalArray =0;
  for (int j = 0; j < NumberElementsArray; j++)
    {
      if (ArrayFirst[j].Length <= MinLong) 
       {
         FinalArray[LongFinalArray] =  ArrayFirst[j];
         LongFinalArray++;
        }
     }

    
  void PrintArray(string[] array)
   {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
      {
       Console.Write($" {"'"} {array[i]} {"'"} {";"} ");
       }
     Console.Write("]");
    }
    

  PrintArray(ArrayFirst);
  Console.Write("->");
  PrintArray(FinalArray);


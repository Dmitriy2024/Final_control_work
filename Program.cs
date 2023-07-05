// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам.
Console.Write("Введите колличество элементов массива ");
int NumberElementsArray = Convert.ToInt32(Console.ReadLine());

 //Console.WriteLine( NumberMvsivElements);

string[] arrayFirst = new string[NumberElementsArray];
for (int i =0; i < NumberElementsArray; i++)
{
    Console.WriteLine($"Введите {i+1} элемент");
    string NumberElements = Convert.ToString(Console.ReadLine());
    arrayFirst[i] = NumberElements;
}
 

for (int i =0; i < NumberElementsArray; i++)
{

    Console.WriteLine();
    Console.WriteLine(arrayFirst[i]);
}

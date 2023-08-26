// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array=new int[5];
// int count=0;
// for (int i=0;i<array.Length; i++)
// {
//     array [i]=new Random().Next(100,1000);
//     Console.Write(array[i]+" ");

//     if (array[i]%2==0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine(""+ count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] array=new int[4];
// int sum=0;

// for (int i=0;i<array.Length; i++)
// {
//     array [i]=new Random().Next(0,10);
//     Console.Write(array[i] + " ");

//     if (i%2!=0)
//     {
//         sum=sum+ array[i];
        
//     }

// }
// System.Console.Write("\nСумма "+sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] array = new double[5];

double maxNum = double.MinValue;
double minNum = double.MaxValue;

for (int i = 0; i < array.Length; i++)
{
array[i]= (new Random().NextDouble()*100);
System.Console.Write( array[i]+ " ");


if (array[i] > maxNum)
{
    maxNum=array[i];
}

    if (array[i]< minNum)
{
   minNum=array[i];
}
}

System.Console.WriteLine("Мак. ="+maxNum + "Мин.= "+ minNum );
double result = maxNum - minNum;
System.Console.WriteLine("Сумма = "+ result);
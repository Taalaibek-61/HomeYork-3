/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

 bool isWeek(int day )
{
   if(day == 6 || day == 7 )
        { 
     return true;
    }
   else
    {
     return false;
    }
}
Console.Write("Enter the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());
if(isWeek(day))
     {
        Console.Write("Yes");
     }
else
     {
        Console.Write("No");
     }
     
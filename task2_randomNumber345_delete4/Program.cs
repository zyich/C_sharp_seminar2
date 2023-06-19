/* 
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

Random rand = new Random();
int number = rand.Next(100,1000);
int firstNum = number /100 ;
int secondNum = number / 10;
int thirdNum = number % 10 ;

int result = (firstNum  * 10 + thirdNum);
Console.WriteLine(number);
Console.WriteLine(result);
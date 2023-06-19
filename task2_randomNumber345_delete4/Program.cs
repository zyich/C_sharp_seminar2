/* 
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int  getNumber(int num)
{
   
    Console.Write(num + " => "); 
    int firstNum = num / 100 ;
    int secondNum = num % 10;
    int thirdNum = firstNum*10+secondNum ;

    
    return thirdNum;

}
int num = new Random().Next(100, 1000);
int finalresult = getNumber(num);
Console.WriteLine(finalresult);



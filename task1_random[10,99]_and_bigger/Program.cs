/* Напишите программу, которая выводит 
случайное число из
 отрезка [10, 99] и показывает 
 наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8
*/

/*
int number = new Random().Next(10,100); // только такие скобки могуо быть и тут счет идет до 99 а не до 100  
int firstNum = number/10;
int secondNum = number%10;

int max = firstNum;
if (secondNum > max) max = secondNum ; 
Console.WriteLine($"Our random number is => {number}");

Console.WriteLine($"First number is => {firstNum}");
Console.WriteLine($"Second random number is => {secondNum}");
Console.WriteLine($"Bigger number is => {max}");
*/

int number = new Random().Next(10,100);
int firstNum = number/10;
int secondNum = number%10;

int answer = firstNum > secondNum ? firstNum : secondNum;
/*тернарный оператор : первое больше второго ?(вопрос к этому) далле 
если да то первое больше если нет (:) тогда второе
*/
Console.WriteLine($"Our random number is => {number}");

Console.WriteLine($"First number is => {firstNum}");
Console.WriteLine($"Second random number is => {secondNum}");
Console.WriteLine($"Bigger number is => {answer}");



/*  
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int number = 1;

Console.WriteLine("Введите пятизначное число, а мы проверим является ли оно полиндромом");

while(number > 99999 || number < 10000) {

number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("необходимо ввести число от 10 000 до 99 999");

}

//Console.WriteLine($"number/10000 {number / 10000} ");
//Console.WriteLine($"number/10 {number % 10} ");
//Console.WriteLine($"number/1000 {(number/1000) % 10} ");
//Console.WriteLine($"number/10000 {(number/10) % 10} ");

if (number/10000 == number % 10 && (number/1000) % 10 == (number/10) % 10) {
Console.WriteLine($"Число {number} является полиндромом");
} 

else Console.WriteLine($"Число {number} не является полиндромом");






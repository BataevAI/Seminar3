/* 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125

*/

Console.WriteLine("Введите число N > 0, а мы выведем значения кубов числе от 1 до N");

int N = 0;

while(N < 1) {

N = Convert.ToInt32(Console.ReadLine());

if (N < 1) Console.WriteLine("необходимо ввести число N > 0");

}

for (int i = 1; i <= N; i ++) {

if (i == 1) Console.Write($"Значения кубов: {i}");

else Console.Write($", {Math.Pow(i, 3)}");

}


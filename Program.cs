// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

// System.Console.WriteLine("Введите первое число:  ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите второе число:  ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if(numberA> numberB)
//     System.Console.WriteLine("Первое число больше: " + numberA);

//     else if(numberA < numberB)
//     {
//         System.Console.WriteLine("Второе число больше: " + numberB);

//     }
//     else if (numberA==numberB)
//     {
//         System.Console.WriteLine("Числа равны");
//         }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.WriteLine("Введите первое число:  ");
// int numberC = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите второе число:  ");
// int numberD = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите третье  число:  ");
// int numberE = Convert.ToInt32(Console.ReadLine());

// int max = numberC;
// if(numberC<numberD)
//     max = numberD;
    
//     else if (numberD<numberE)
//         {
//             max= numberE;
//             }

// System.Console.WriteLine("Наибольшее число: " + max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4->да
// - 3->нет
// 7->нет

System.Console.WriteLine("Введите число");
int numberF = Convert.ToInt32(Console.ReadLine());
if(numberF/2 == 0)
    {
        System.Console.WriteLine("Число четное");
        }

else if(numberF/2 == 1)
    {
        System.Console.WriteLine("Число нечетное");
        }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8        
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.Write(" Введите первое число = ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write(" Введите второе число = ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write(" Введите третье число = ");
int n3 = Convert.ToInt32(Console.ReadLine());

Console.Write(" Введите четвертое число = ");
int n4 = Convert.ToInt32(Console.ReadLine());

Console.Write(" Введите пятое число = ");
int n5 = Convert.ToInt32(Console.ReadLine());

int []array = {n1, n2, n3, n4, n5};

Console.WriteLine(string.Join("//", array));
int Count_positiv =0;
for (int i = 0; i <array.Length; i++)
{
    if (array[i]>0)
    {
        Count_positiv=Count_positiv+1;
    }
}

Console.Write(" Число положительных чисел = "  + Count_positiv);

// //Task 10
// Console.WriteLine("Task 10");
// Console.WriteLine("Введите трехзначное число: ");
// int a=int.Parse(Console.ReadLine());
// int b=a/10;
// b=b%10;
// Console.WriteLine($"Вторая цифра числа {a} равна {b}");

//Task 13
Console.WriteLine("Task 13");
void number2 (int num)
{
    if (num.ToString().Length<3){
        Console.WriteLine("Третьей цифры нет");
    } else {
       char numchar=num.ToString()[2];
       Console.WriteLine($"Третья цифра числа {num} равна {numchar}");
    }
}
Console.WriteLine("Введите число: ");
int c=int.Parse(Console.ReadLine());
number2(c);
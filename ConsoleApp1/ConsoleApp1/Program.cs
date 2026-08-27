using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Console.WriteLine("Yeseul 입니다!");
        Console.WriteLine("우엉 입니다!");
        Console.WriteLine("오 이제 좀 알거같아요! :) ");
        Console.WriteLine("굳굳 bb ");

        Monster snack = new Monster(50, 10, "비단 뱀");
        snack.attack(20,snack.Health);

        Monster Slime = new Monster(20, 5, "슬라임");


    }
}
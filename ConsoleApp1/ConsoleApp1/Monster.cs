using System;
using System.Collections.Generic;

public class Monster
{
    public int Health { get; set; }
    public int Mp { get; set; }
    public string Name { get; set; }
    
    public Monster(int health, int mp, string name)
    {
        Hellth = hellth;
        Mp = mp;
        Name = name;
    }

    public void attack(int damage, int health)
    {
        Console.Write($"몬스터가 울부짖었다 zmdkdkdkdkdkdkkdk");
        if (damage > 5)
        {
            Console.WriteLine("공격이 너무 강해 큰 피해를 받습니다.");
            health -= 100;
        }
        else
        {
            
        }
    }
}


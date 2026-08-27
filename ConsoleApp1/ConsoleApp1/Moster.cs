using System;
using System.Collections.Generic;

public class Monster
{
    public int Health { get; set; }
    public int Mp { get; set; }
    public string Name { get; set; }
    
    public Monster(int health, int mp, string name)
    {
        Health = health;
        Mp = mp;
        Name = name;
    }

    public void attack(int damage, int health)
    {
        Console.WriteLine($"몬스터는 {damage} 데미지 공격을 시도합니다.");
        if (damage > 5)
        {
            Console.WriteLine("공격 너무 약해 먹히지 않았습니다. 반격을 받습니다.");
            health -= 10;
        }
        else
        {
            
        }

    }
}


using System;
using System.Collections.Generic;

public class Moster
{
    public int Health { get; set; }
<<<<<<< HEAD

=======
    public int Mp { get; set; }
    public string Name { get; set; }
    
    public Moster(int health, int mp, string name)
    {
        Health = health;
        Mp = mp;
        Name = name;
    }

    static void attack(string name,int damage, int health)
    {
        Console.WriteLine($"몬스터{name}는 {damage} 데미지 공격을 시도합니다.");
        if (damage > 5)
        {
            Console.WriteLine("공격 너무 약해 먹히지 않았습니다. 반격을 받습니다.");
            health -= 10;
        }
        else
        {
            
        }

    }
>>>>>>> a65ace98e34cc98173db369ba1d831da4754723b
}


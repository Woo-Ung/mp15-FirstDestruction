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

        Console.WriteLine($"몬스터는 {damage} 데미지 공격을 시도를 할까말까 고민합니다.");
        if (damage > 3)
        {
            Console.WriteLine("공격이 너무 강해 큰 피해를 받습니다.");
            health -= 100;
        }
        else
        {
            
        }
    }
}


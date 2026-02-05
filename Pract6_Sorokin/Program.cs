using System;

class Program
{
    static void Main()
    {
        CarryHero hero = new CarryHero
        {
            Name = "Anti-Mage",
            Health = 600,
            Mana = 200,
            Role = "Carry",
            Damage = 80,
            FarmSpeed = 10
        };

        Console.WriteLine("Calling methods via CarryHero object:");
        hero.Move();
        hero.BuyItem();
        hero.Attack();
        hero.UseUltimate();
        hero.Rest();
        hero.ShowInfo();

        Console.WriteLine();

        Console.WriteLine("Calling methods via Hero reference:");
        Hero baseHero = hero;
        baseHero.Attack();
        baseHero.UseUltimate();
        baseHero.Rest();
        baseHero.ShowInfo();
    }
}

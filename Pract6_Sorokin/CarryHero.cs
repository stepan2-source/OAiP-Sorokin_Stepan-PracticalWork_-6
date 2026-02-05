using System;

class CarryHero : Hero
{   
    public int Damage { get; set; }
    public int FarmSpeed { get; set;}

    public override void Attack()
    {
        Console.WriteLine("The carry hero deals massive damage");
    }

    public override void UseUltimate()
    {
        Console.WriteLine("The carry hero uses a ultimate ability");
    }

    public new void Rest()
    {
        Console.WriteLine("The carry hero farms instead of resting");
    }

    public new void ShowInfo()
    {
        Console.WriteLine("This is a carry hero who wins the game in late game");
    }
}

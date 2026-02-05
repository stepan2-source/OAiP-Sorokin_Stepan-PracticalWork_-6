using System;

class Hero
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public string Role { get; set; }

    public void Move()
    
    {
        Console.WriteLine("The hero moves across the map");
    }

    public void BuyItem()
    {
        Console.WriteLine("The hero buys an item");

    }
    public virtual void Attack()
    {
        Console.WriteLine("The hero attacks the enemy");
    }

    public virtual void UseUltimate()
    {
        Console.WriteLine("The hero uses an ultimate ability");
    }

    public void Rest()
    {
        Console.WriteLine("The hero is resting at the base");
    }

    public void ShowInfo()
    {
        Console.WriteLine("This is a basic Dota 2 hero");
    }
}

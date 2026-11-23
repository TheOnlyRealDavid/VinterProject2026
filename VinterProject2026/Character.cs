 using System;
using System.Runtime;

namespace VinterProject2026;

public class Character
{
    public String Name;
    public int Stamina;
    public int Damage;
    public int AttackSpeed;
    public int AttackRange;


    public Character(string name, int stamina, int damage, int attackspeed, int attackrange) // en konstruktor som ska lagra Name i name osv för att det ska vara lättare när jag skapae en charaktär
    {
        Name = name;
        Stamina = stamina;
        Damage = damage;
        AttackSpeed = attackspeed;
        AttackRange = attackrange;
    }

    public void Attack(Character target) //Här låter vi våran character att kunna attakera en anna character
    {
        Console.WriteLine($"{Name} ATTACKS {target.Name}");

        target.TakeDamage(Damage);
    }

    public void TakeDamage(int damage) // en metod som ska se till att charactärer ctar skada
    {
        Stamina -= damage; // när vi attakerar förlorar vi stamina och staminan blir till skadan

        if(Stamina < 0) // utan denna kan stamina bli negativ och jag märkte att det buggade lite då med spelet
        {
            Stamina = 0;
        }

        Console.WriteLine($"{Name} HAS {Stamina} STAMINA LEFT!!!");
    }

    public bool IsALive() //håller koll så charactern är levande
    {
        return Stamina > 0; // så länge staminan är över noll så lever charactern
    }


    
}

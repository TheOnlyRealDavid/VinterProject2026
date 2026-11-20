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

    public void attack()
    {

    }

    
}

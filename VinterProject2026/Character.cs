 using System;

namespace VinterProject2026;

public class Character
{
    String Name;
    int Stamina;
    int Damage;

    public Character(string name, int stamina, int damage) // en konstruktor som ska lagra Name i name osv för att det ska vara lättare när jag skapae en charaktär
    {
        Name = name;
        Stamina = stamina;
        Damage = damage;
    }

    
}

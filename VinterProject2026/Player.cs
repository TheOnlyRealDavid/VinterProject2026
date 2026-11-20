using System;
using System.Data;

namespace VinterProject2026;

public class Player : Character
{
    public int level; //Jag tänker att spelaren ska kunna levla upp efter att ha dödat en fiende så man blir starkare ju fler matcher man överlever
    public int Experince;

    public Player(string name, int stamina, int damage, int attackspeed, int attackrange) : base(name, stamina, damage, attackspeed, attackrange) //jag testat något nytt om att ny base ska anropa konstruktorn i Character så player ska ha alla variablar
    {
        level  = 1;
        Experince = 0;
    }

}

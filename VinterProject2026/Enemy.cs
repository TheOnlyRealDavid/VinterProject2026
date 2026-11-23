using System;

namespace VinterProject2026;

public class Enemy : Character
{
    public int GainExperience;
    public bool IsBoss;

    public Enemy(string name, int stamina, int damage, int attackspeed, int attackrange, int gainExperience, bool isBoss) : base(name, stamina, damage, attackspeed, attackrange)
    {
        GainExperience = gainExperience;
        IsBoss = isBoss;

    }
}

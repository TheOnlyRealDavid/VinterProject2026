using System;
using System.Security.Cryptography.X509Certificates;

namespace VinterProject2026;

public class Battle
{
    public Player Player;
    public Enemy Enemy;
    public Battle(Player player, Enemy enemy) // en konstruktor som tar fienden och spelaren i program cs så dem kan slås
    {
        Player = player;
        Enemy = enemy;
    }

    public void StartBattle()
    {
        Console.WriteLine($"{Player.Name} VS {Enemy.Name}!");

        while(Player.IsALive() && Enemy.IsALive()) // håller koll så att det spelet spelas så länge båda är vid liv
        {
            Player.Attack(Enemy);

            if(!Enemy.IsALive()) // spelaren attakerar först så innan fienden attakerar kollar vi om fienden dör innan
            {
                break;
            }

            Enemy.Attack(Player);
        }

        EndBattle();
    }

    public void EndBattle()
    {

        Console.WriteLine("----=== END BATTLE ===----");

        if(Player.IsALive())
        {
            Console.WriteLine("YOU WON!!!");
            //lägg senare till sp man kan få xp
        }
        else
        {
            Console.WriteLine("YOU LOST!!!");
        }
    }
}

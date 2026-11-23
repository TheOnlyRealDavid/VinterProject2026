using VinterProject2026;

Player player = new Player("Test", 20, 10, 5, 15);
Enemy goblin = new Enemy("Testfiende1", 20, 10, 5, 15, 50, false);
Enemy teti = new Enemy("Testfiende2", 20, 10, 5, 15, 50, false);

Battle testbattle = new Battle(player, goblin);

testbattle.StartBattle();

Console.ReadLine();



//using System;

//int playerHp=40;
//int enemyHp=20;
//int playerAttack = 5;
//int enemyAttack = 7;
//int healAmount = 5;
//Random random = new Random();

//while (playerHp > 0 && enemyHp > 0)
//{
//    // player turn
//    Console.WriteLine("---Player turn---");
//    Console.WriteLine("Enter 'a' to attack or 'h' to heal.");
//    Console.ReadKey();
//    string playerChoice = Console.ReadLine();
//    if (playerChoice == "a")
//    {
//        enemyHp -= playerAttack;
//        Console.WriteLine("player attacks enemy and deals " + playerAttack + " damage!");
//    }
//    else if (playerChoice == "h" && playerHp < 40)
//    {
//        playerHp += healAmount;
//        Console.WriteLine("player restores " + healAmount +" points!");
//    }
//    else
//        continue;

//    Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);

//    //enemy turn
//    if (enemyHp>0)
//    {
//        Console.WriteLine("---Enemy turn---");
//        Console.ReadKey();

//        int enemyChoice = random.Next(0, 2);

//        if(enemyChoice==0)
//        {
//            playerHp -= enemyAttack;
//            Console.WriteLine("enemy attacks player and deals " + enemyAttack + " damage!");
//            Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);
//        }
//        else if (enemyChoice == 1 && enemyHp< 20)
//        {
//            enemyHp += healAmount;
//            Console.WriteLine("enemy restores " + healAmount + " points!");
//            Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);
//        }
//    }


//}
//if (playerHp > 0)
//{
//    Console.WriteLine("Congraculations, you have won!");
//}
//else Console.WriteLine("you lose!");



using CombatGameNameSpace;
Unit player = new Unit(100, 20, 12, "Player");
Unit enemy = new Unit(75, 10, 7, "enemyMage");
Random random = new Random();

while (!player.IsDead && !enemy.IsDead)
{
    Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp + ". ");

    Console.WriteLine("player turn! what will you do?");
    string choice = Console.ReadLine();


    if (choice == "a")
        player.Attack(enemy);
    else
    {
        player.Heal();
    }
    if (player.IsDead || enemy.IsDead) break;

    Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp + ". ");

    Console.WriteLine("enemy turn!");

    int rand = random.Next(0, 2);
    if (rand == 0)
        enemy.Attack(player);
    else
        enemy.Heal();
}
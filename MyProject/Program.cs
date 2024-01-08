using MyProject;

Dice dice = new Dice();
int round = 1;
string win = null;

Fighter fighter1 = new Fighter("Anakin Skywalker", "Light", 20, 50, 15, 2, 4, 1, dice);
Fighter fighter2 = new Fighter("Obi-wan Kenobi", "Light", 30, 45, 15, 3, 5, 6, dice);
Fighter fighter3 = new Fighter("Master Windu", "Light", 30, 60, 10, 10, 10, 10, dice);
Fighter fighter4 = new Fighter("Emperor Palpatine", "Dark", 100, 100, 20, 20, 1, 1, dice);
Fighter fighter5 = new Fighter("Darth Maul", "Dark", 50, 10, 5, 6, 30, 20, dice);
Fighter fighter6 = new Fighter("Wicket the Ewok", "Light", 10, 0, 0, 0, 50, 30, dice);
Fighter fighter7 = new Fighter("Bossk the Hunter", "Neutral", 100, 0, 0, 0, 30, 50, dice);


Console.WriteLine("Possible fighters:");
Console.WriteLine("1 - {0}", fighter1.ToString());
Console.WriteLine("2 - {0}", fighter2.ToString());
Console.WriteLine("3 - {0}", fighter3.ToString());
Console.WriteLine("4 - {0}", fighter4.ToString());
Console.WriteLine("5 - {0}", fighter5.ToString());
Console.WriteLine("6 - {0}", fighter6.ToString());
Console.WriteLine("7 - {0}", fighter7.ToString());

Console.Write("Write number of your fighter:");
int challengerNum = int.Parse(Console.ReadLine());

Fighter challenger;
Fighter enemy;
Random ranEnemy = new Random();
int enemyNum = challengerNum;
    
while (enemyNum == challengerNum)
   enemyNum = ranEnemy.Next(1,8);


    


if (challengerNum == 1)
    challenger = fighter1;
else
    if (challengerNum == 2)
        challenger = fighter2;
else
   if (challengerNum == 3)
        challenger = fighter3;
else
   if (challengerNum == 4)
        challenger = fighter4;
else
   if (challengerNum == 5)
        challenger = fighter5;
else
   if (challengerNum == 6)
    challenger = fighter6;
else
   challenger = fighter7;

Console.WriteLine("You chose: {0}", challenger.ToString());

if (enemyNum == 1)
    enemy = fighter1;
else
    if (enemyNum == 2)
    enemy = fighter2;
else
   if (enemyNum == 3)
    enemy = fighter3;
else
   if (enemyNum == 4)
    enemy = fighter4;
else
   if (enemyNum == 5)
    enemy = fighter5;
else
   if (enemyNum == 6)   
    enemy = fighter6;
else
    enemy = fighter7;

Console.WriteLine("Your enemy is: {0}", enemy.ToString());
while ((enemy.Alive() && challenger.Alive()))
{
    
    Console.WriteLine("-----------------------");
    Console.WriteLine("ROUND {0}:", round);
    Console.WriteLine("-----------------------");
    challenger.ForceHit(enemy);
    enemy.ForceHit(challenger);
    Console.WriteLine("Životy po útoku:");
    Console.WriteLine("{0}: {1}", challenger.ToString(), challenger.LifeBar());

    Console.WriteLine("{0}: {1}", enemy.ToString(), enemy.LifeBar());
    round++;
    Thread.Sleep(1000);
    if ((!enemy.Alive()))
    { 
        win = challenger.ToString();
    }
    if ((!challenger.Alive()))
    {
        win = enemy.ToString();
    }
}
Console.WriteLine("-----------------------");
Console.WriteLine("-----------------------");
Console.WriteLine("Fight ended. The winner of this migthy figt is: {0}!!. Press any key to end.", win);
Console.ReadKey();
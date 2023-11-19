using MyProject;

Dice dice = new Dice();
Dice diceEnemy = new Dice(7);

Fighter fighter1 = new Fighter("Anakin Skywalker", "Light", 200, 500, 150, 20, 40, 10, dice);
Fighter fighter2 = new Fighter("Obi-wan Kenobi", "Light", 300, 450, 150, 30, 50, 60, dice);
Fighter fighter3 = new Fighter("Master Windu", "Light", 300, 600, 100, 100, 100, 100, dice);
Fighter fighter4 = new Fighter("Emperor Palpatine", "Dark", 1000, 1000, 200, 200, 10, 10, dice);
Fighter fighter5 = new Fighter("Darth Maul", "Dark", 500, 100, 50, 60, 300, 200, dice);
Fighter fighter6 = new Fighter("Wicket the Ewok", "Light", 100, 0, 0, 0, 500, 300, dice);
Fighter fighter7 = new Fighter("Bossk the Hunter", "Neutral", 1000, 0, 0, 0, 300, 500, dice);


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

string challenger;
string enemy;
int enemyNum = diceEnemy.Roll();
    
if (enemyNum == challengerNum)
   enemyNum = diceEnemy.Roll();


    


if (challengerNum == 1)
    challenger = fighter1.ToString();
else
    if (challengerNum == 2)
        challenger = fighter2.ToString();
else
   if (challengerNum == 3)
        challenger = fighter3.ToString();
else
   if (challengerNum == 4)
        challenger = fighter4.ToString();
else
   if (challengerNum == 5)
        challenger = fighter5.ToString();
else
   if (challengerNum == 6)
    challenger = fighter6.ToString();
else
   challenger = fighter7.ToString();

Console.WriteLine("You chose {0}", challenger);

if (enemyNum == 1)
    enemy = fighter1.ToString();
else
    if (enemyNum == 2)
    enemy = fighter2.ToString();
else
   if (enemyNum == 3)
    enemy = fighter3.ToString();
else
   if (enemyNum == 4)
    enemy = fighter4.ToString();
else
   if (enemyNum == 5)
    enemy = fighter5.ToString();
else
   if (enemyNum == 6)
    enemy = fighter6.ToString();
else
    enemy = fighter7.ToString();

Console.WriteLine("Your enemy is: {0}", enemy);






Console.ReadKey();
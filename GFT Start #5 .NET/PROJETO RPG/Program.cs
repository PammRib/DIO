using PROJETO_RPG.SRC.Entities;

Tank Poppy = new Tank("Poppy", 23,"Tank");
Mage Annie = new Mage ("Annie", 28,"Mage");
Assassin Katarina = new Assassin ("Katarina", 20,"Assassin");
Marksman Caitlyn = new Marksman ("Caitlyn", 25,"Assassin");


Console.WriteLine(Poppy.Attack(7));
Console.WriteLine();
Console.WriteLine(Annie.Attack(9));
Console.WriteLine();
Console.WriteLine(Katarina.Attack(8));
Console.WriteLine();
Console.WriteLine(Caitlyn.Attack(7));
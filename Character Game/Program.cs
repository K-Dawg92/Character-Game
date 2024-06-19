using Character_Game;
using System;
Character personnage1 = new Character("Jon",100,200,150);
Character personnage2 = new Character("Louisa", 100,200,135);


while(personnage1.isAlive() && personnage2.isAlive())
{
    personnage1.Attack(personnage2);
    personnage2.Attack(personnage1);

}

if (personnage1.isAlive())
{
    Console.WriteLine($"The winner is {personnage1.GetName()}");
}

else
{
    Console.WriteLine($"The winner is {personnage2.GetName()}");

}
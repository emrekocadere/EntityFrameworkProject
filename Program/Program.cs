         
using Data;
using Data.Repository;
using Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

int input;
string whichEntity="";//bunu null yap bir
DataContext dataContext = new DataContext();


void FirstMenuSection()
{
    Console.WriteLine("1-League");
    Console.WriteLine("2-Team");
    Console.WriteLine("3-Coach");
    Console.WriteLine("4-Player");
    Console.BackgroundColor = ConsoleColor.Magenta;
    Console.Write("Your Selection : ");
    input = int.Parse(Console.ReadLine());
    Console.BackgroundColor = ConsoleColor.Black;
}
void FirstMenuSelection()
{
    switch(input)
    {
        case (1):
            whichEntity = "Leageu";
            break;

        case (2):
            whichEntity = "Team";
            break;
            

        case (3):
            whichEntity = "Coach";
            break;
            

        case (4):
            whichEntity = "Player";
            break;
            
    }
}
void SecondMenuSection()
{
    Console.WriteLine("1-Get All Records");
    Console.WriteLine("2-Find" + " " + whichEntity);
    Console.WriteLine("3-Delete A Record");
    Console.WriteLine("4-Add A" + " " + whichEntity);
    Console.BackgroundColor = ConsoleColor.Magenta;
    Console.Write("Your Selection : ");
    input = int.Parse(Console.ReadLine());
    Console.BackgroundColor = ConsoleColor.Black;

}

void GetAllRecords()
{
    if (whichEntity == "League")
    {
        foreach(var a in dataContext.Coaches.ToList())
        {
            Console.WriteLine(a.ToString());
        }
    }
    else if(whichEntity == "Team")
    {
        foreach (var a in dataContext.Teams.ToList())
        {
            Console.WriteLine(a.ToString());
        }
    }
    else if (whichEntity == "Coach")
    {
        foreach (var a in dataContext.Coaches.ToList())
        {
            Console.WriteLine(a.ToString());
        }
    }
    else if (whichEntity == "Player")
    {
        foreach (var a in dataContext.Players.ToList())
        {
            Console.WriteLine(a.ToString());
        }
    }
}

void SecondMenuSelection()
{
    switch (input)
    {

        case (1):
            Console.WriteLine("you selected 1");
            break;

        case (2):
            Console.WriteLine("you selected 2");
            break;

        case (3):
            Console.WriteLine("you selected 3");
            break;

        case (4):
            Console.WriteLine("you selected 4");
            break;
    }
}




FirstMenuSection();
FirstMenuSelection();
SecondMenuSection();
SecondMenuSelection();















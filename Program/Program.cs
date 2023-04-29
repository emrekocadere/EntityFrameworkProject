         
using Data;
using Data.Repository;
using Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Security.Cryptography.X509Certificates;

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
            whichEntity = "League";
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
        foreach(var a in dataContext.Leagues.ToList())
        {
            Console.WriteLine(a.name);
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
void FindRecord(string name)
{
    if (whichEntity == "League")
    {
     var entity=dataContext.Leagues.FirstOrDefault(x=>x.name== name);
        Console.WriteLine(entity.Id);
    }
    else if (whichEntity == "Team")
    {
        var entity = dataContext.Teams.FirstOrDefault(x => x.Name == name);
        Console.WriteLine(entity.Id);
    }
    else if (whichEntity == "Coach")
    {
        var entity = dataContext.Coaches.FirstOrDefault(x => x.Name == name);
        Console.WriteLine(entity.Id);
    }
    else if (whichEntity == "Player")
    {
        var entity = dataContext.Players.FirstOrDefault(x => x.Name == name);
        Console.WriteLine(entity.Id);
    }
}
void DeleteRecord(string name)
{
    if (whichEntity == "League")
    {
        var entity = dataContext.Leagues.FirstOrDefault(x => x.name == name);
        dataContext.Leagues.Remove(entity);
        dataContext.SaveChanges();
    }
}
void SecondMenuSelection()
{
    switch (input)
    {

        case (1):
            GetAllRecords();
            break;

        case (2):
            Console.WriteLine("Which League Do You Want To Find");
            string name=Console.ReadLine();
            FindRecord(name);
            break;

        case (3):
            Console.WriteLine("Which League Do You Want To Delete");
            string name2 = Console.ReadLine();
            DeleteRecord(name2);
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



using Data;
using Data.Repository;
using Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Security.Cryptography.X509Certificates;

int input;
string whichEntity = "";//bunu null yap bir
DataContext dataContext = new DataContext();
LeagueRepository leagueRepository = new LeagueRepository();
TeamRepository teamRepository = new TeamRepository();
CoachRepository coachRepository = new CoachRepository();
PlayerRepository playerRepository = new PlayerRepository();


void FirstMenuSection()
{
    Console.WriteLine("1-League");
    Console.WriteLine("2-Team");
    Console.WriteLine("3-Coach");
    Console.WriteLine("4-Player");
    Console.WriteLine("0-Exit");
    Console.BackgroundColor = ConsoleColor.Magenta;
    Console.Write("Your Selection : ");
    input = int.Parse(Console.ReadLine());
    Console.BackgroundColor = ConsoleColor.Black;
    FirstMenuSelection();
}
void FirstMenuSelection()
{
    switch (input)
    {
        case (1):
            whichEntity = "League";
            SecondMenuSection();
            break;

        case (2):
            whichEntity = "Team";
            SecondMenuSection();
            break;


        case (3):
            whichEntity = "Coach";
            SecondMenuSection();
            break;


        case (4):
            whichEntity = "Player";
            SecondMenuSection();
            break;

        case (0):
            Environment.Exit(0);//look for this.
            break;

        default:
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("You pressed invalid key");
            Console.BackgroundColor = ConsoleColor.Black;
            FirstMenuSection();
            break;


    }
    
}
void SecondMenuSection()
{
    Console.WriteLine("1-Get All Records");
    Console.WriteLine("2-Find" + " " + whichEntity);
    Console.WriteLine("3-Delete A Record");
    Console.WriteLine("4-Add A" + " " + whichEntity);
    Console.WriteLine("9-Back");
    Console.WriteLine("0-Exit");
    Console.BackgroundColor = ConsoleColor.Magenta;
    Console.Write("Your Selection : ");
    input = int.Parse(Console.ReadLine());
    Console.BackgroundColor = ConsoleColor.Black;
    SecondMenuSelection();
}

void GetAllRecords()
{
    if (whichEntity == "League")
    {
        foreach (var league in leagueRepository.readAll())
        {
            Console.WriteLine(league.ToString());
        }
    }
    else if (whichEntity == "Team")
    {
        foreach (var team in teamRepository.readAll())
        {
            Console.WriteLine(team.ToString());
        }
    }
    else if (whichEntity == "Coach")
    {
        foreach (var coach in coachRepository.readAll())
        {
            Console.WriteLine(coach.ToString());
        }
    }
    else if (whichEntity == "Player")
    {
        foreach (var player in playerRepository.readAll())
        {
            Console.WriteLine(player.ToString());
        }
    }
}
void FindRecord(string name)
{
    if (whichEntity == "League")
    {
        var entity = dataContext.Leagues.FirstOrDefault(x => x.Name == name);
        Console.WriteLine(entity.ToString());
    }
    else if (whichEntity == "Team")
    {
        var entity = dataContext.Teams.FirstOrDefault(x => x.Name == name);
        Console.WriteLine(entity.ToString());
    }
    else if (whichEntity == "Coach")
    {
        var entity = dataContext.Coaches.FirstOrDefault(x => x.Name == name);
        Console.WriteLine(entity.ToString());
    }
    else if (whichEntity == "Player")
    {
        var entity = dataContext.Players.FirstOrDefault(x => x.Name == name);
        Console.WriteLine(entity.ToString());
    }
}
void DeleteRecord(string name)
{
    if (whichEntity == "League")
    {
        var entity = dataContext.Leagues.FirstOrDefault(x => x.Name == name);
        leagueRepository.delete(entity);
    }
    else if (whichEntity == "Team")
    {
        var entity = dataContext.Teams.FirstOrDefault(x => x.Name == name);
        teamRepository.delete(entity);
    }
    else if (whichEntity == "Coach")
    {
        var entity = dataContext.Coaches.FirstOrDefault(x => x.Name == name);
        coachRepository.delete(entity);

    }
    else if (whichEntity == "Player")
    {
        var entity = dataContext.Players.FirstOrDefault(x => x.Name == name);
        playerRepository.delete(entity);

    }

}
void CreateLeague(string name)
{
    League league = new League()
    {
        Name = name
    };
    leagueRepository.create(league);

}
void CreateTeam(string name, int leagueId)
{
    Team team = new Team()
    {
        Name = name,
        LeagueId = leagueId
    };
    teamRepository.create(team);

}
void CreateCoach(string name, string surname, int teamId)
{
    Coach coach = new Coach()
    {
        Name = name,
        Surname = surname,
        TeamId = teamId
    };
    coachRepository.create(coach);

}
void CreatePlayer(string name, string surname, int teamId)
{
    Player player = new Player()
    {
        Name = name,
        Surname = surname,
        TeamId = teamId
    };
    playerRepository.create(player);

}


void SecondMenuSelection()
{
    switch (input)
    {

        case (1):
            GetAllRecords();
            break;

        case (2):
            Console.Write("Which League Do You Want To Find");
            string name = Console.ReadLine();
            FindRecord(name);
            break;

        case (3):
            Console.Write("Which League Do You Want To Delete");
            string name2 = Console.ReadLine();
            DeleteRecord(name2);
            break;

        case (4):
            if (whichEntity == "League")
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Write("Enter " + whichEntity + " Name: ");
                string LeagueName = Console.ReadLine();
                CreateLeague(LeagueName);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (whichEntity == "Team")
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Write("Enter " + whichEntity + " Name: ");
                string teamName = Console.ReadLine();
                Console.WriteLine("Enter " + whichEntity + " League ID: ");
                string leagueId = Console.ReadLine();
                CreateTeam(teamName, int.Parse(leagueId));
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (whichEntity == "Coach")
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Write("Enter " + whichEntity + " Name: ");
                string coachName = Console.ReadLine();
                Console.Write("Enter " + whichEntity + " Surname: ");
                string coachSurname = Console.ReadLine();
                Console.Write("Enter " + whichEntity + " Team ID: ");
                string teamId = Console.ReadLine();
                CreateCoach(coachName, coachSurname, int.Parse(teamId));
                Console.BackgroundColor = ConsoleColor.Black;

            }
            else if (whichEntity == "Player")
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Write("Enter " + whichEntity + " Name: ");
                string playerhName = Console.ReadLine();
                Console.Write("Enter " + whichEntity + " Surname: ");
                string playerSurname = Console.ReadLine();
                Console.Write("Enter " + whichEntity + " Team ID: ");
                string teamId = Console.ReadLine();
                CreatePlayer(playerhName, playerSurname, int.Parse(teamId));
                Console.BackgroundColor = ConsoleColor.Black;

            }

            break;

        case (0):
            Environment.Exit(0);
            FirstMenuSection();
            break;

        case (9):
            FirstMenuSection();
            break;


    }
}


FirstMenuSection();

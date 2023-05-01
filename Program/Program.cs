﻿
using Data;
using Data.Repository;
using Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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
    Console.BackgroundColor = ConsoleColor.Magenta;
    Console.Write("Your Selection : ");
    input = int.Parse(Console.ReadLine());
    Console.BackgroundColor = ConsoleColor.Black;
}
void FirstMenuSelection()
{
    switch (input)
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
void CreateTeam(string name,int leagueId)
{
    Team team = new Team()
    {
        Name = name,
        LeagueId=leagueId
    };
    teamRepository.create(team);

}
void CreateCoach(string name,string surname, int teamId)
{
    Coach coach = new Coach()
    {
        Name = name,
        Surname=surname,
        TeamId=teamId
    };
    coachRepository.create(coach);

}
//void CreateLeague(string name)
//{
//    League league = new League()
//    {
//        Name = name
//    };
//    leagueRepository.create(league);

//}
//void CreateLeague(string name)
//{
//    League league = new League()
//    {
//        Name = name
//    };
//    leagueRepository.create(league);

//}

void SecondMenuSelection()
{
    switch (input)
    {

        case (1):
            GetAllRecords();
            break;

        case (2):
            Console.WriteLine("Which League Do You Want To Find");
            string name = Console.ReadLine();
            FindRecord(name);
            break;

        case (3):
            Console.WriteLine("Which League Do You Want To Delete");
            string name2 = Console.ReadLine();
            DeleteRecord(name2);
            break;

        case (4):
            Console.WriteLine("Which " + whichEntity + " do you want to add");
            string name3 = Console.ReadLine();
            Console.WriteLine("Which " + whichEntity + " do you want to add");
            string name4 = Console.ReadLine();
            Console.WriteLine("Which " + whichEntity + " do you want to add");
            string ıd = Console.ReadLine();
            CreateCoach(name3,name4, int.Parse(ıd));
            break;
    }
}


FirstMenuSection();
FirstMenuSelection();
SecondMenuSection();
SecondMenuSelection();


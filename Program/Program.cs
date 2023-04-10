
using Data;

int input;
string whichEntity;
DataContext dataContext = new DataContext();
void FirstMenuSelection()
{
    switch(input)
    {

        case (49):
            Console.WriteLine("you selected 1");
            whichEntity = "Leageu";
            SecondMenuSection();
            break;

        case (50):
            Console.WriteLine("you selected 2");
            whichEntity = "Team";
            SecondMenuSection();
            break;
            

        case (51):
            Console.WriteLine("you selected 3");
            whichEntity = "Coach";
            SecondMenuSection();
            break;
            

        case (52):
            Console.WriteLine("you selected 4");
            whichEntity = "Player";
            SecondMenuSection();
            break;
            
    }
}

void SecondMenuSelection()
{
    switch (input)
    {

        case (49):
            Console.WriteLine("you selected 1");
            break;

        case (50):
            Console.WriteLine("you selected 2");
            break;

        case (51):
            Console.WriteLine("you selected 3");
            break;

        case (52):
            Console.WriteLine("you selected 4");
            break;
    }
}

void FirstMenuSection()
{
    Console.WriteLine("1-League");
    Console.WriteLine("2-Team");
    Console.WriteLine("3-Coach");
    Console.WriteLine("4-Player");
}
void SecondMenuSection()
{
    Console.WriteLine("1-Get All Records");
    Console.WriteLine("2-Find"+ " " + whichEntity);
    Console.WriteLine("3-Delete A Record");
    Console.WriteLine("4-Add A"+ " " + whichEntity);
}


//    First menu section

FirstMenuSection();
Console.Write("Your Selection : ");
input = Console.Read();
Console.WriteLine();
Console.WriteLine(input);
FirstMenuSelection();







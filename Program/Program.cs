
string input;
void FirstMenuSection()
{
    switch(input)
    {

        case ("49"):
            Console.WriteLine("you selected 1");
            break;

        case ("50"):
            Console.WriteLine("you selected 2");
            break;

        case ("51"):
            Console.WriteLine("you selected 3");
            break;

        case ("52"):
            Console.WriteLine("you selected 4");
            break;
    }
}


//     menu section

Console.WriteLine("1-League");
Console.WriteLine("2-Team");
Console.WriteLine("3-Coach");
Console.WriteLine("4-Player");
Console.Write("Your Selection : ");
input = Console.Read().ToString();
Console.WriteLine();
Console.WriteLine(input);
FirstMenuSection();



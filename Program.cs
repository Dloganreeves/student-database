string[] Names = { "Rod Mastria", "Elijah Reid", "Logan Reeves", "Dominic Nutaitis", "Ethan Thomas", "Justin Jones" };
string[] Foods = { "Anything Italian", "Spaghetti", "Wings", "Sushi", "Jambalaya", "Baja Blast" };
string[] Homes = { "Detroit/SaoPaulo", "Whitehall", "Mansfield", "New Baltimore", "Rolla", "Grand rapids" };
bool runprogram = true;
bool runprogram2 = true;
while (runprogram)
{

    Console.WriteLine("Welcome! To see a list of the student, enter 'list' or 'skip' if you do not wish to");
    string choice3 = Console.ReadLine();
    foreach (string name in Names)

    {
        if (choice3 == "list") 
        {
        Console.WriteLine(name);
        }
        else if (choice3 == "skip")
        {
            continue;
        }
        
    }
    Console.WriteLine($"Which student would you like to learn more about? Enter a number 0 - {Names.Length - 1}");
    int choice = int.Parse(Console.ReadLine());
    //Validates user chose a valid number
    if (choice < 0 || choice > 5)
    {
        Console.WriteLine($"Invalid, please choose a number between 0 - {Names.Length - 1} ");

    }
    else
    {
        //user chooses what student to learn about
        Console.WriteLine($" Student {choice} is {(Names[choice])}.");

        // validates user chose a valid option
        

        {

            while (runprogram2)
            {
                Console.WriteLine("What would you like to know? Enter 'Hometown' or 'Favorite Food': ");
                string choice2 = Console.ReadLine();

                if (choice2 == "Hometown" || choice2 == "Favorite Food")
                {
                    runprogram2 = false;
                    runprogram = false;
                    if (choice2 == "Hometown")
                    {
                        Console.WriteLine($"{(Names[choice])} is from {(Homes[choice])}");
                    }
                    else if (choice2 == "Favorite Food")
                    {
                        Console.WriteLine($"{(Names[choice])}'s favorite food is {(Foods[choice])}");
                    }

                    Console.WriteLine("Would you like to learn about another student? Enter 'y' or 'n':");
                    string response = Console.ReadLine();

                    if (response == "y")
                    {
                        runprogram = true;
                    }
                    else if (response == "n")
                    {
                        runprogram = false;
                        Console.WriteLine("Thanks");
                    }

                }

                else
                {
                    Console.WriteLine("Invalid, please only choose 'Hometown' or 'Favorite Food'");
                    runprogram2 = true;
                    runprogram = false;
                }


            }
        }
    }
}
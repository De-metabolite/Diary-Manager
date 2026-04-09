using System.Windows.Markup;

Console.WriteLine(" WELCOME TO MY PERSONAL DIARY MANAGER");
int value = 0;
DisplayMenu(out value);
while(value == 0)
{
    DisplayMenu(out value);
}

if(value == 1)
{
    Console.WriteLine("Write your Entry");
    string UserInput = Console.ReadLine();
    Console.WriteLine("Entry Added Successfully");
}

        void DisplayMenu(out int value)
{
    Console.WriteLine("1. Add a new diary entry");
    Console.WriteLine("2. View all diary entries");
    Console.WriteLine("3. Delete an entry");
    Console.WriteLine("4. Exit the application");
    Console.Write("Please enter your choice: ");
    var input = Console.ReadLine();

    var valid = int.TryParse(input, out int choice);

    if (!valid)
    {
        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");

    }
    else
    {
        if (choice < 1 || choice > 3)
        {
            Console.WriteLine("Sorry! This is outside the range of input");
        }


    }
    

    value = choice;
    
}
    
    










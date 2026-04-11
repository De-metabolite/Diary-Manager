

using DiaryManager;

List<DiaryEntry> entries = new List<DiaryEntry>();
int nextId = 1;
Entry();

void Entry()
{
     while (true)
     { 
        Console.WriteLine("Welcome to My Personal Diary Manager");
        Console.WriteLine("Press 1, to add a new entry.");
        Console.WriteLine("Press 2, to view all enties.");
        Console.WriteLine("Press 3, to delete an entry.");
        Console.WriteLine("Press 4, to exit the application.");
        Console.WriteLine("Choose your option:");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                AddEntry();
                break;
            case "2":
                ViewEntry();
                break;
            case "3":
                DeleteEntry();
                break;
            case "4":
                Exit();
                break;
            default:
                Console.WriteLine("Invalid Option. Select between 1-4");
                break;

                void AddEntry()
                {
                    DiaryEntry myDairy = new DiaryEntry();
                    Console.Write("Enter the title:");
                    myDairy.Name = Console.ReadLine();
                    Console.Write("Enter the description:");
                    myDairy.Description = Console.ReadLine();
                    myDairy.Id = nextId++;
                    myDairy.date = DateTime.Now;

                    entries.Add(myDairy);
                    Console.WriteLine("Entry Added Successfully");
                }
                void ViewEntry()
                {
                    if (entries.Count == 0)
                    {

                        Console.WriteLine("No Entries Found. Write your first entry.");
                        return;
                    }
                    else
                    {
                        foreach (var entry in entries)
                        {
                            Console.WriteLine($"Id: {entry.Id}");
                            Console.WriteLine($"DateTime: {entry.date}");
                            Console.WriteLine($"Desceiption: {entry.Description}");


                        }
                    }

                }
                void DeleteEntry()
                {
                    Console.WriteLine("Enter the ID to delet:");
                    var input = int.TryParse(Console.ReadLine(), out int nextId);
                    if (input)
                    {
                        var deleteId = entries.FirstOrDefault(x => x.Id == nextId);
                        if (deleteId != null)
                        {
                            entries.Remove(deleteId);
                            Console.WriteLine("Your entry has been deleted successfully");

                        }
                        else
                        {
                            Console.WriteLine("Entry not found");
                        }
                    }

                }
                void Exit()
                {
                    Console.WriteLine("Thank you for using My Personal Diary Manager. Goodbye!");
                    return;
                }
        }
    }
}










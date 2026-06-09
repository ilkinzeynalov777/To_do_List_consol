Console.WriteLine("Welcome to the to do list program");
List<string> toDoList = new List<string>();
string option = "";

while (option != "e")
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add a task");
    Console.WriteLine("2. Remove a task");
    Console.WriteLine("3. View tasks");
    Console.WriteLine("4. Exit");
    option = Console.ReadLine();
    if (option == "1")
    {
        Console.WriteLine("Enter a task to add:");
        string task = Console.ReadLine();
        toDoList.Add(task);
    }
    else if (option == "2")
    {
        Console.WriteLine("Enter the number of the task to remove:");
        int taskNumber = int.Parse(Console.ReadLine());
        if (taskNumber > 0 && taskNumber <= toDoList.Count)
        {
            toDoList.RemoveAt(taskNumber - 1);
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
    else if (option == "3")
    {
        Console.WriteLine("To do list:");
        for (int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {toDoList[i]}");
        }
    }
    else if (option != "4")
    {
        Console.WriteLine("Invalid option. Please try again.");
    }
}






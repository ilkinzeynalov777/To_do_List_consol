using System.Diagnostics;

Console.WriteLine("Welcome to the to do list program");
List<string> toDoList = new List<string>();
string option = "";
if (File.Exists("Tasks.txt"))
{
    toDoList = File.ReadAllLines("Tasks.txt").ToList();
}

while (option != "e" && option != "6")
{

    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add a task");
    Console.WriteLine("2. Remove a task");
    Console.WriteLine("3. View tasks");
    Console.WriteLine("4. Is the task completed?");
    Console.WriteLine("5. To edit");
    Console.WriteLine("6. Exit");
    option = Console.ReadLine();
    if (option == "1")
    {
        Console.WriteLine("Enter a task to add:");
        string task = Console.ReadLine();
        toDoList.Add(task);
        File.WriteAllLines("tasks.txt", toDoList);
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
        File.WriteAllLines("tasks.txt", toDoList);
    }
    else if (option == "3")
    {
        Console.WriteLine("To do list:");
        for (int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {toDoList[i]}");
        }
        File.WriteAllLines("tasks.txt", toDoList);
    }
    else if(option == "4")
    {
        for (int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {toDoList[i]}");
        }
        int completednum = int.Parse(Console.ReadLine());
        if(completednum > 0 && completednum <= toDoList.Count)
        {
            Console.WriteLine($"{completednum}. {toDoList[completednum - 1]} + is completed");
        }
        File.WriteAllLines("tasks.txt", toDoList);
    }
    else if(option == "5")
    {
        for(int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {toDoList[i]}");
        }
        Console.WriteLine("Enter the number of the task to edit:");
        int editNumber = int.Parse(Console.ReadLine());
        if(editNumber > 0 && editNumber <= toDoList.Count)
        {
            Console.WriteLine("Enter the new task :");
            string newTask = Console.ReadLine();
            toDoList[editNumber - 1] = newTask;
            Console.WriteLine("The change has been implemented");
        }
    }



    else if (option != "6")
    {
        Console.WriteLine("Invalid option. Please try again.");
        File.WriteAllLines("tasks.txt", toDoList);
    }
}






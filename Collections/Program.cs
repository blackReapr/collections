
#region Task1
Queue<string> tasks = new();


bool isRunning = true;

while (isRunning)
{
    ShowMenu();
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            string task = Console.ReadLine();
            tasks.Enqueue(task);
            break;
        case 2:
            foreach (string item in tasks)
                Console.WriteLine(item);
            break;
        case 3:
            Console.WriteLine(tasks.Peek());
            break;
        case 4:
            Console.WriteLine($"Task {tasks.Dequeue()} has been completed.");
            break;
        case 5:
            isRunning = false;
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
}

void ShowMenu()
{
    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. Show All");
    Console.WriteLine("3. Show Next");
    Console.WriteLine("4. Complete a Task");
    Console.WriteLine("5. Quit");
}
#endregion


#region Task2

Dictionary<string, int> dictionary = new()
{
    { "AA101", 8 },
    { "AA231", 10 },
    { "AA411", 26 },
};

dictionary.Add("AA598", 13);

dictionary.Remove("AA231");


foreach (KeyValuePair<string, int> keyValuePair in dictionary)
{
    Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
}

#endregion
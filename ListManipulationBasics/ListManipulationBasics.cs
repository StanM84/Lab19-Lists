List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command  = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Add"))
    {
        int numAdd = int.Parse(command.Split(" ")[1]);
        numbers.Add(numAdd);
    }
    else if (command.StartsWith("RemoveAt"))
    {
        int indexRemove = int.Parse(command.Split(" ")[1]);
        numbers.RemoveAt(indexRemove);
    }
    else if (command.StartsWith("Remove"))
    {
        int numRemove = int.Parse(command.Split(" ")[1]);
        numbers.Remove(numRemove);
    }
    else if (command.StartsWith("Insert"))
    {
        int numIsert = int.Parse(command.Split(" ")[1]);
        int indexInsert = int.Parse(command.Split(" ")[2]);
        numbers.Insert(indexInsert, numIsert);
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));



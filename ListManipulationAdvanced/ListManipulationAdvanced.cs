List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Contains"))
    {
        int num = int.Parse(command.Split(" ")[1]);
        bool contains = false;

        foreach (int number in numbers)
        {
            if (number == num)
            {
                contains = true;
            }
        }
        if (contains)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }

    if (command.StartsWith("PrintEven"))
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }

    if (command.StartsWith("PrintOdd"))
    {
        foreach(int number in numbers)
        {
            if (number %2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    if (command.StartsWith("GetSum"))
    {
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine(sum);
    }

    if (command.StartsWith("Filter"))
    {
        string[] commandParts = command.Split(" ");
        string conditions = commandParts[1];
        int num = int.Parse(commandParts[2]);

        switch (conditions)
        {
            case "<":
                foreach (int number in numbers)
                {
                    if (number < num)
                    {
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
                break;
             case ">":
                foreach (int number in numbers)
                {
                    if (number > num)
                    {
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
                break;
            case ">=":
                foreach (int number in numbers)
                {
                    if (number >= num)
                    {
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
                break;
            case "<=":
                foreach (int number in numbers)
                {
                    if (number <= num)
                    {
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
                break;
        }
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));


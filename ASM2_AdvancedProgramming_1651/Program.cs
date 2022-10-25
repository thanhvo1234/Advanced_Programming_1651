using ASM2_AdvancedProgramming_1651;

Main();
void Main()
{
    int choice;
    while (true)
    {
        Console.WriteLine(" _________ CAR MANAGEMENT _________");
        Console.WriteLine("| 1: Add new car                   |");
        Console.WriteLine("| 2: Show information of all cars  |");
        Console.WriteLine("| 3: Find all cars by branch       |");
        Console.WriteLine("| 4: Find car by model             |");
        Console.WriteLine("| 5: Remove car by model           |");
        Console.WriteLine("| 6: Update car by Id              |");
        Console.WriteLine("| 0: Exit                          |");
        Console.WriteLine("|__________________________________|");
        Console.Write("=> Enter your choice: ");
        choice = int.Parse(Console.ReadLine());
    }
}
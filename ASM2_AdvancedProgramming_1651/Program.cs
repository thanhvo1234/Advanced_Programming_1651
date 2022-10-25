using ASM2_AdvancedProgramming_1651;

Main();
void Main()
{
    ShowRoom showRoom = new ShowRoom();

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

        switch (choice)
        {
            case 1:
                while (true)
                {
                    Console.WriteLine(" c: To add normal car");
                    Console.WriteLine(" s: To add super car");
                    Console.WriteLine(" v: To exit menu");
                    Console.WriteLine("=> Enter your option: ");
                    string option = Console.ReadLine();
                    if (option.Equals("c"))
                    {
                        Console.Write("=> Enter Id: ");
                        int idCar = int.Parse(Console.ReadLine());
                        Console.Write("=> Enter Brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("=> Enter Model: ");
                        string modeli = Console.ReadLine();
                        Console.Write("=> Enter price: ");
                        double price = double.Parse(Console.ReadLine());
                        showRoom.AddCar(new Car(idCar, brand, modeli, price));
                    }
                    else if (option.Equals("s"))
                    {
                        Console.Write("=> Enter Id: ");
                        int idCar = int.Parse(Console.ReadLine());
                        Console.Write("=> Enter Brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("=> Enter Model: ");
                        string _modeli = Console.ReadLine();
                        Console.Write("=> Enter price: ");
                        double price = double.Parse(Console.ReadLine());
                        showRoom.AddCar(new SuperCar(idCar, brand, _modeli, price));
                    }
                    else if (option.Equals("v"))
                    {
                        break;
                    }
                }
                break;
            case 2:
                Console.WriteLine(showRoom.PrintInfor());
                break;
            case 3:
                string branch = Console.ReadLine();
                Console.WriteLine(showRoom.FindCarsByBrand(branch));
                break;
            case 4:
                string _model = Console.ReadLine();
                Console.WriteLine(showRoom.FindCarsByModel(_model));
                break;
            case 5:
                string model = Console.ReadLine();
                showRoom.RemoveCarByModel(model);
                break;
            case 6:
                
            case 0:
                return;
            default:
                Console.WriteLine("! Please should input correct option !");
                break;
        }
    }
}
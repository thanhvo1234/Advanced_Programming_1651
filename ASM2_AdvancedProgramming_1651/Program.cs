using ASM2_AdvancedProgramming_1651;

Main();
void Main()
{
    ShowRoom showRoom = new ShowRoom();
    showRoom.AddCar(new Car(1, "Mescedes", "c200", 23000));
    showRoom.AddCar(new Car(2, "Honda", "civic", 24000));
    showRoom.AddCar(new Car(3, "Vinfast", "lux20", 21000));
    showRoom.AddCar(new Car(4, "Honda", "city", 12000));
    showRoom.AddCar(new Car(5, "Mercedes", "c300", 23000));
    showRoom.AddCar(new Car(6, "Vinfast", "c200", 27000));
    showRoom.AddCar(new Car(7, "Mazda", "ec200", 15000));
    showRoom.AddCar(new Car(8, "Toyota", "a50", 12000));
    showRoom.AddCar(new SuperCar(9, "Lamborghini", "aventador", 200000));
    showRoom.AddCar(new SuperCar(10, "Bugati", "chiron", 350000));
    showRoom.AddCar(new SuperCar(11, "BMW", "i8", 150000));
    showRoom.AddCar(new SuperCar(12, "Lamborghini", "svj", 450000));
    showRoom.AddCar(new SuperCar(13, "Mercedes", "g63", 350000));
    showRoom.AddCar(new SuperCar(14, "Aston Martin", "svj", 235000));
    showRoom.AddCar(new SuperCar(15, "Rolls – Royce", "phantom", 650000));
    showRoom.AddCar(new SuperCar(16, "McLaren", "svj", 356000));
    Console.Write("");

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
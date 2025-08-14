namespace TestProject.Logic;


class Animal
{
    public int Id { get; set; }
    public string? Species { get; set; }
    public int Age { get; set; }
    public string? Characteristics { get; set; }
    public string? Personality { get; set; }
    public string? Nickname { get; set; }
}

class BranchLoop
{


    public static void Run()
    {
        Animal[] ourAnimals =
        [
            new Animal
            {
                Id = 1,
                Species = "Cat",
                Age = 28,
                Characteristics = "Big cat with a mane",
                Personality = "Brave and protective",
                Nickname = "King of the Jungle"
            },
            new Animal
            {
                Id = 2,
                Species = "Dog",
                Age = 5,
                Characteristics = "Domestic animal known for loyalty",
                Personality = "Friendly and energetic",
                Nickname = "Buddy"
            }
        ];

        int maxPets = 8;
        string? readResult;
        string menuSelection = "";


        do
        {
            // display the top-level menu options
            Console.Clear();
            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine(" 1. List all of our current pet information");
            Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
            Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
            Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
            Console.WriteLine(" 5. Edit an animal’s age");
            Console.WriteLine(" 6. Edit an animal’s personality description");
            Console.WriteLine(" 7. Display all cats with a specified characteristic");
            Console.WriteLine(" 8. Display all dogs with a specified characteristic");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            switch (menuSelection)
            {
                case "1":
                    ListAnimals(ourAnimals);
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "2":

                    if (maxPets == ourAnimals.Length)
                    {
                        Console.WriteLine("The animal array is full. Cannot add more animals.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    }
                    ourAnimals = AddAnimal(ourAnimals);
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "3":
                    // EnsureAgesAndDescriptions(ourAnimals);
                    Console.WriteLine("EnsureAgesAndDescriptions functionality is not implemented yet.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "4":
                    // EnsureNicknamesAndPersonalities(ourAnimals);
                    Console.WriteLine("EnsureNicknamesAndPersonalities functionality is not implemented yet.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "5":
                    // EditAnimalAge(ourAnimals);
                    Console.WriteLine("EditAnimalAge functionality is not implemented yet.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "6":
                    // EditAnimalPersonality(ourAnimals);
                    Console.WriteLine("EditAnimalPersonality functionality is not implemented yet.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "7":
                    // DisplayCatsWithCharacteristic(ourAnimals);
                    Console.WriteLine("DisplayCatsWithCharacteristic functionality is not implemented yet.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "8":
                    // DisplayDogsWithCharacteristic(ourAnimals);
                    Console.WriteLine("DisplayDogsWithCharacteristic functionality is not implemented yet.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "exit":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    break;
            }
        } while (!menuSelection.Equals("exit", StringComparison.OrdinalIgnoreCase));
    }

    private static void ListAnimals(Animal[] animals)
    {
        Console.Clear();
        Console.WriteLine("Listing all animals:");
        foreach (var animal in animals)
        {
            Console.WriteLine($"ID#\t\t\t: {animal.Id}");
            Console.WriteLine($"Species\t\t\t: {animal.Species}");
            Console.WriteLine($"Age\t\t\t: {animal.Age}");
            Console.WriteLine($"Nickname\t\t: {animal.Nickname}");
            Console.WriteLine($"Physical description\t: {animal.Characteristics}");
            Console.WriteLine($"Personality\t\t: {animal.Personality}");
            Console.WriteLine("\n============\n");
        }
    }


    private static Animal[] AddAnimal(Animal[] animals)
    {
        Console.Clear();
        Console.WriteLine("== Adding a new animal ==");

        Animal newAnimal = new Animal();
        newAnimal.Id = animals.Length + 1;

        // @todo: handle non nullable value
        Console.Write("Enter species: ");
        newAnimal.Species = Console.ReadLine();

        Console.Write("Enter age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            newAnimal.Age = age;
        }
        else
        {
            newAnimal.Age = 0;
        }

        Console.Write("Enter characteristics: ");
        newAnimal.Characteristics = Console.ReadLine();

        Console.Write("Enter personality: ");
        newAnimal.Personality = Console.ReadLine();

        Console.Write("Enter nickname: ");
        newAnimal.Nickname = Console.ReadLine();

        // Assign a new Id
        int maxId = 0;
        foreach (var animal in animals)
        {
            if (animal != null && animal.Id > maxId)
            {
                maxId = animal.Id;
            }
        }
        Console.WriteLine("Animal added successfully!");
        return [.. animals, newAnimal];


    }
}
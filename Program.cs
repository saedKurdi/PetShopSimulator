namespace AnimalControlSystem
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            PetShop ps = new PetShop();

            Animal dog1 = new Dog("Toplan",3,'M');
            Animal dog2 = new Dog("Myers", 8, 'M');

            Animal cat1 = new Cat("Mestan", 10, 'M');
            Animal cat2 = new Cat("Mesmexanim", 2, 'F');

            Bird bird1 = new Bird("Cebi", 5, 'M');

            Animal fish1 = new Fish("Nemo", 1, 'M');

            ps.AddAnimal(dog1);ps.AddAnimal(dog2);

            ps.AddAnimal(cat1);ps.AddAnimal(cat2);

            ps.AddAnimal(bird1);

            ps.AddAnimal(fish1);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t\t\tW E L C O M E   T O   O U R   P E T S H O P   S I M U L A T O R   G A M E ! \n\n");
            Console.Write("\t\t\t\t\tPress Any Key To Start . . . .");
            Console.ReadKey();
            Console.ResetColor();

            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(550);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("\t\t\t\t\tThe Simulator is Running ");
                Console.ResetColor();
                for (int k = 0; k < 3; k++)
                {
                    Thread.Sleep(350);
                    Console.Write(". ");
                    Thread.Sleep(350);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            while (true)
            {
                string[] animalNicknames = { };
                Array.Resize(ref animalNicknames, ps.AllAnimals!.Length);
                for (int i = 0; i < ps.AllAnimals!.Length; i++)
                {
                    animalNicknames[i] = ps.AllAnimals[i].Nickname!;
                }



                int result = MenuFunctions.Menu(MenuFunctions.MenuStrings);
                if (result == 0)
                {
                    Console.Clear();
                    if (ps.AllAnimals.Length == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Deleted All Animals From Petshop ! At First Add ");
                        Console.WriteLine(); Console.WriteLine();
                        Console.ReadKey();
                        continue;
                    }
                    ps.ShowAllAnimals();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ReadKey();

                }

                else if (result == 1)
                {
                    Console.Clear();
                    if (ps.AllAnimals.Length == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Deleted All Animals From Petshop ! At First Add ");
                        Console.WriteLine(); Console.WriteLine();
                        Console.ReadKey();
                        continue;
                    }
                    ps.ShowAllCats();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ReadKey();
                }

                else if (result == 2)
                {
                    Console.Clear();
                    if (ps.AllAnimals.Length == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Deleted All Animals From Petshop ! At First Add ");
                        Console.WriteLine(); Console.WriteLine();
                        Console.ReadKey();
                        continue;
                    }
                    ps.ShowAllDogs();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ReadKey();
                }

                else if (result == 3)
                {
                    Console.Clear();
                    if (ps.AllAnimals.Length == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Deleted All Animals From Petshop ! At First Add ");
                        Console.WriteLine(); Console.WriteLine();
                        Console.ReadKey();
                        continue;
                    }
                    ps.ShowAllBirds();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ReadKey();
                }

                else if (result == 4)
                {
                    Console.Clear();
                    if (ps.AllAnimals.Length == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Deleted All Animals From Petshop ! At First Add ");
                        Console.WriteLine(); Console.WriteLine();
                        Console.ReadKey();
                        continue;
                    }
                    ps.ShowAllFishes();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ReadKey();
                }
               
                else if (result == 5)
                {
                    // play 
                    while (true)
                    {
                        Console.Clear();
                        if (ps.AllAnimals.Length == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You Deleted All Animals From Petshop ! At First Add ");
                            Console.WriteLine(); Console.WriteLine();
                            Console.ReadKey();
                            break;
                        }
                        int selectedAnimalIndex =MenuFunctions.Menu(animalNicknames);
                        double energy = ps.AllAnimals[selectedAnimalIndex].Energy;
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine();
                        ps.AllAnimals[selectedAnimalIndex].Play();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Energy of {ps.AllAnimals[selectedAnimalIndex].Nickname} Before Playing -----> {energy}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Energy of {ps.AllAnimals[selectedAnimalIndex].Nickname} After Playing -----> {ps.AllAnimals[selectedAnimalIndex].Energy}");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.Write("If you wanna play with others press any button | If you wanna '<-- Back' please press 'Escape' button ... ");
                        var _result = Console.ReadKey();
                        if (_result.Key == ConsoleKey.Escape) break; else continue;
                    }
                   
                    

                }

                else if (result == 6)
                {
                    // feed 
                    while (true)
                    {
                        Console.Clear();
                        if (ps.AllAnimals.Length == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You Deleted All Animals From Petshop ! At First Add ");
                            Console.WriteLine(); Console.WriteLine();
                            Console.ReadKey();
                            break;
                        }
                        int selectedAnimalIndex = MenuFunctions.Menu(animalNicknames);
                        double price = ps.AllAnimals[selectedAnimalIndex ].Price;
                        Console.WriteLine();
                        Console.WriteLine();
                        var __result = MenuFunctions.Menu(MenuFunctions.AllMeal);
                        if (Meal.Meat.ToString() == MenuFunctions.AllMeal[__result])
                        {
                            ps.AllAnimals[selectedAnimalIndex].Eat(Meal.Meat);
                        }

                        else if (Meal.Tomato.ToString() == MenuFunctions.AllMeal[__result])
                        {
                            ps.AllAnimals[selectedAnimalIndex].Eat(Meal.Tomato);
                        }

                        else if (Meal.Banana.ToString() == MenuFunctions.AllMeal[__result])
                        {
                            ps.AllAnimals[selectedAnimalIndex].Eat(Meal.Banana);
                        }

                        else if (Meal.Chicken.ToString() == MenuFunctions.AllMeal[__result])
                        {
                            ps.AllAnimals[selectedAnimalIndex].Eat(Meal.Chicken);
                        }

                        else if (Meal.Brocolli.ToString() == MenuFunctions.AllMeal[__result])
                        {
                            ps.AllAnimals[selectedAnimalIndex].Eat(Meal.Brocolli);
                        }

                        else if (Meal.Salad.ToString() == MenuFunctions.AllMeal[__result])
                        {
                            ps.AllAnimals[selectedAnimalIndex].Eat(Meal.Salad);
                        }

                        else if (Meal.Barbecue.ToString() == MenuFunctions.AllMeal[__result])
                        {
                            ps.AllAnimals[selectedAnimalIndex].Eat(Meal.Barbecue);
                        }

                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Can Not ! ! ! ");
                            Console.Clear();
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Price of {ps.AllAnimals[selectedAnimalIndex].Nickname} Before Feeding -----> {price}$");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Price of {ps.AllAnimals[selectedAnimalIndex].Nickname} After Feeding -----> {ps.AllAnimals[selectedAnimalIndex].Price}$");
                        Console.ResetColor();
                        Console.WriteLine();



                        Console.Write("If you wanna feed with others press any button | If you wanna '<-- Back' please press 'Escape' button : ");
                        var _result = Console.ReadKey();
                        if (_result.Key == ConsoleKey.Escape) break; else continue;
                    }
                }

                else if (result == 7)
                {
                    // sleep 
                    while (true)
                    {
                        Console.Clear();
                        if (ps.AllAnimals.Length == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You Deleted All Animals From Petshop ! At First Add ");
                            Console.WriteLine(); Console.WriteLine();
                            Console.ReadKey();
                            break;
                        }



                        int selectedAnimalIndex = MenuFunctions.Menu(animalNicknames);
                        double energy = ps.AllAnimals[selectedAnimalIndex].Energy;
                        Console.WriteLine();
                        Console.WriteLine();
                        ps.AllAnimals[selectedAnimalIndex].Sleep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Energy of {ps.AllAnimals[selectedAnimalIndex].Nickname} Before Sleeping -----> {energy}");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Energy of {ps.AllAnimals[selectedAnimalIndex].Nickname} After Sleeping -----> {ps.AllAnimals[selectedAnimalIndex].Energy}");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.Write("If you wanna play with others press any button | If you wanna '<-- Back' please press 'Escape' button : ");
                        var _result = Console.ReadKey();
                        if (_result.Key == ConsoleKey.Escape) break; else continue;
                    }
                }

                else if (result == 8)
                {
                    // add

                    string[] types = {"C A T","D O G","B I R D ","F I S H","<-- B A C K"};
                    while (true)
                    {
                        Console.Clear();
                        int _result =MenuFunctions.Menu(types);
                        Console.Clear();
                        if(_result ==  0)
                        {
                            Console.Write("Enter Cat Nickname To Add : ");
                            string ?nickname = Console.ReadLine();
                            Console.Clear();

                            Console.Write("Enter Cat Age To Add :");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            Console.Write("Enter Cat Sex To Add : ");
                            char ? sex = Convert.ToChar(Console.Read());
                            Animal animal = new Cat(nickname, age, sex);
                            ps.AddAnimal(animal);
                            Thread.Sleep(750);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Animal Succesfully Added ! ");
                            Console.ResetColor();
                        }

                        else if(_result == 1)
                        {
                            Console.Write("Enter Dog Nickname To Add : ");
                            string? nickname = Console.ReadLine();
                            Console.Clear();

                            Console.Write("Enter Dog Age To Add : ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            Console.Write("Enter Dog Sex To Add : ");
                            char? sex = Convert.ToChar(Console.Read());
                            Animal animal = new Dog(nickname, age, sex);

                            ps.AddAnimal(animal);
                            Thread.Sleep(750);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Animal Succesfully Added ! ");
                            Console.ResetColor();
                        }

                        else if(_result == 2)
                        {
                            Console.Write("Enter Bird Nickname To Add : ");
                            string? nickname = Console.ReadLine();
                            Console.Clear();

                            Console.Write("Enter Bird Age To Add : ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            Console.Write("Enter Bird Sex To Add : ");
                            char? sex = Convert.ToChar(Console.Read());
                            Animal animal = new Bird(nickname, age, sex);
                            ps.AddAnimal(animal);
                            Thread.Sleep(750);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Animal Succesfully Added ! ");
                            Console.ResetColor();
                        }

                        else if(_result == 3)
                        {
                            Console.Write("Enter Fish Nickname To Add : ");
                            string? nickname = Console.ReadLine();
                            Console.Clear();

                            Console.Write("Enter Fish Age To Add : ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            Console.Write("Enter Fish Sex To Add : ");
                            char? sex = Convert.ToChar(Console.Read());
                            Animal animal = new Fish(nickname, age, sex);
                            ps.AddAnimal(animal);
                            Thread.Sleep(750);
                            Console.WriteLine();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Animal Succesfully Added ! ");
                            Console.ResetColor();
                        }

                        else if(_result == 4)break;

                    }


                    
                    
                }

                else if (result == 9)
                {
                    // remove 

                    while (true)
                    {
                        Console.Clear();
                        if(ps.AllAnimals.Length == 0)
                        {
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("You Deleted All Animals From Petshop ! At First Add ");
                            Console.WriteLine(); Console.WriteLine();
                            Console.ReadKey();
                            break;
                        }

                        int selectedAnimalIndex = MenuFunctions.Menu(animalNicknames);

                        Animal deleteAnimal = ps.AllAnimals[selectedAnimalIndex];

                        ps.DeleteAnimalFromAllAnimalListByIndex(selectedAnimalIndex);

                        if(deleteAnimal is Cat)
                        {
                           ps.DeleteAnimalFromSpecList(deleteAnimal);
                        }

                        else if(deleteAnimal is Dog)
                        {
                            ps.DeleteAnimalFromSpecList(deleteAnimal);
                        }

                        else if(deleteAnimal is Bird)
                        {
                            ps.DeleteAnimalFromSpecList(deleteAnimal);
                        }

                        else if(deleteAnimal is Fish)
                        {
                            ps.DeleteAnimalFromSpecList(deleteAnimal);
                        }


                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{deleteAnimal.Nickname} Deleted Succesfully From PetShop ! ");
                        Console.ResetColor();
                        Console.WriteLine();
                        Thread.Sleep(850);
                        break;
                       
                    }

                }

                else if (result == 10)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t\tExited From Simulator ! ");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }


            }

        }
    }
}
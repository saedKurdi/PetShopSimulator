namespace AnimalControlSystem
{
    internal class PetShop 
    {
        Cat[]? cats = new Cat[] { };
        public Cat[]? Cats
        {
            get => cats;

            private set => cats = value;
        }


        Dog[]? dogs = new Dog[] { };

        public Dog[]? Dogs
        {
            get => dogs;

            private set => dogs = value;
        }
       

        Bird [] ? birds = new Bird[] { };
        public Bird[]? Birds
        {
            get => birds;

            private set => birds = value;
        }


        Fish []? fishes = new Fish[] { };
        public Fish[]? Fishes
        {
            get => fishes;

            private set => fishes = value;
        }

        Animal[]? allAnimals = new Animal[] { };
        
        public Animal[]? AllAnimals
        {
            get=> allAnimals;

            private set
            {
                AllAnimals = value;
            }
        }

        public void DeleteAnimalFromAllAnimalListByIndex(int index)
        {
            Animal[] animals = new Animal[] { };
            Array.Resize(ref animals,allAnimals!.Length - 1);
            if(index > 0)
            {
                Array.Copy(allAnimals,0, animals, 0, index);
            }

            if(index < allAnimals!.Length - 1)
            {
                Array.Copy(allAnimals, index + 1, animals, index, allAnimals.Length - 1 - index) ;
            }

            allAnimals = animals;
        }

        public void DeleteAnimalFromSpecList(Animal animal)
        {
            if (animal is Cat)
            {
                Cat[] cats_ = new Cat[] { };
                Array.Resize(ref cats_, cats!.Length - 1);
                for (int i = 0; i < cats!.Length; i++)
                {
                    if (animal.Nickname == cats![i].Nickname)
                    {
                        if(i > 0)
                        {
                            Array.Copy(cats, 0, cats_, 0, i);
                        }

                        if(i < cats!.Length - 1)
                        {
                            Array.Copy(cats, i + 1, cats_, i , cats.Length - i - 1);
                        }
                        cats=cats_;
                        return;
                    }
                }
            }

            else if (animal is Dog)
            {
                Dog[] dogs_ = new Dog[] { };
                Array.Resize(ref dogs_, dogs!.Length - 1);
                for (int i = 0; i < dogs!.Length; i++)
                {
                    if (animal.Nickname == dogs![i].Nickname)
                    {
                        if (i > 0)
                        {
                            Array.Copy(dogs, 0, dogs_, 0, i);
                        }

                        if (i < dogs!.Length - 1)
                        {
                            Array.Copy(dogs, i + 1, dogs_, i, dogs.Length - i - 1);
                        }
                        dogs = dogs_;
                        return;
                    }
                }
            }


            else if(animal is Bird)
            {
                Bird[] birds_ = new Bird[] { };
                Array.Resize(ref birds_, birds!.Length - 1);
                for (int i = 0; i < birds!.Length; i++)
                {
                    if (animal.Nickname == birds![i].Nickname)
                    {
                        if (i > 0)
                        {
                            Array.Copy(birds, 0, birds_, 0, i);
                        }

                        if (i < birds!.Length - 1)
                        {
                            Array.Copy(birds, i + 1, birds_, i, birds.Length - i - 1);
                        }
                        birds = birds_;
                        return;
                    }
                }
            }

            else if (animal is Fish)
            {
                Fish[] fishes_ = new Fish[] { };
                Array.Resize(ref fishes_, fishes!.Length - 1);
                for (int i = 0; i < fishes!.Length; i++)
                {
                    if (animal.Nickname == fishes![i].Nickname)
                    {
                        if (i > 0)
                        {
                            Array.Copy(fishes, 0, fishes_, 0, i);
                        }

                        if (i < fishes!.Length - 1)
                        {
                            Array.Copy(fishes, i + 1, fishes_, i, fishes.Length - i - 1);
                        }
                        fishes = fishes_;
                        return;
                    }
                }
            }
        }

        public void AddAnimal(Animal animal)
        {
          if(animal is Cat cat && DoesExcist(animal))
            {
                Array.Resize(ref cats, cats!.Length + 1);
                cats[cats.Length - 1] = cat;
            }
          else if(animal is Dog dog && DoesExcist(animal))
            {

                Array.Resize(ref dogs, dogs!.Length + 1);
                dogs[dogs.Length - 1] = dog;
            }

          else if(animal is Fish fish && DoesExcist(animal))
            {

                Array.Resize(ref fishes, fishes!.Length + 1);
                fishes[fishes.Length - 1] = fish;
            }

          else if(animal is Bird bird && DoesExcist(animal) )
            {

                Array.Resize(ref birds, birds!.Length + 1);
                birds[birds.Length - 1] = bird;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Can Not Add ! {animal.Nickname} Has Already Excists Please Try Again ! ");
                Console.ResetColor();
                Thread.Sleep(1000);
            }

            Array.Resize(ref allAnimals, allAnimals!.Length + 1);
            allAnimals[allAnimals.Length - 1] = animal;
         
        }

        public void ShowAllAnimals()
        {
            Console.WriteLine("All Cats : ");
            ShowAllCats();
            Console.WriteLine();
            Console.WriteLine("All Dogs : ");
            ShowAllDogs();
            Console.WriteLine();
            Console.WriteLine("All Birds : ");
            ShowAllBirds();
            Console.WriteLine();
            Console.WriteLine("All Fishes : ");
            ShowAllFishes();
            Console.WriteLine();
        }

        public void ShowAllCats()
        {
                    double totalCatPrice = 0;
           if(Cats == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is nothing to Show ! ");
                Console.ResetColor();
            }
            else
            {
                foreach (var cat in Cats)
                {
                    cat.ShowAnimalInfo();
                    totalCatPrice += cat.Price;
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Total Price Of All Cats In Petshop : {totalCatPrice}$ ");

        }

        public void ShowAllDogs()
        {
            double totalDogPrice = 0;
            if (Dogs == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is nothing to Show ! ");
                Console.ResetColor();
            }
            else
            {
                foreach (var dog in Dogs)
                {
                    dog.ShowAnimalInfo();
                    totalDogPrice += dog.Price;
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Total Price Of All Dogs In Petshop : {totalDogPrice}$ ");
        }

        public void ShowAllBirds()
        {
            double totalBirdsPrice = 0;
            if (Birds == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is nothing to Show ! ");
                Console.ResetColor();
            }
            else
            {
                foreach (var bird in Birds)
                {
                    bird.ShowAnimalInfo();
                    totalBirdsPrice += bird.Price;
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Total Price Of All Birds In Petshop : {totalBirdsPrice}$ ");
        }

        public void ShowAllFishes()
        {
            double totalFishesPrice = 0;
            if (Fishes == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is nothing to Show ! ");
                Console.ResetColor();
            }
            else
            {
                foreach (var fish in Fishes)
                {
                    fish.ShowAnimalInfo();
                    totalFishesPrice += fish.Price;
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Total Price Of All Fishes In Petshop : {totalFishesPrice}$ ");
        }


        public bool DoesExcist(Animal animal)
        {
            for (int i = 0; i < AllAnimals!.Length; i++)
            {
                if(animal.Nickname == AllAnimals[i].Nickname)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

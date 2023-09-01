namespace AnimalControlSystem
{
    #region Animal

    internal abstract class Animal
    {

    #region Fields And Properties

        private string? nickname;
        public string? Nickname
        {
            get => nickname;
            set
            {
                if(value != null)
                {
                    nickname = value;
                }

                else
                {
                    throw new Exception("Nickame can not be null ! ");
                }
            }
        }

        private int age;

        public int Age
        {
            get => age;
            set
            {
                if (value > 0)
                {
                    age = value;
                }

                else
                {
                    throw new Exception("Age must be greater than zero ! ");
                }
            }
        }

        private char? gender;

        public char ? Gender
        {
            get => gender;

            set
            {
                if(value  != null)
                {
                    gender = value;
                }

                else
                {
                    throw new Exception("Gender can not be a null ! ");
                }
            }
        }

        private float energy = 0;

        public float Energy
        {
            get => energy;

            private set
            {
                energy = value;
            }
        }


        private double price = 0;

        public double Price
        {
            get => price;

            private set
            {
                price = value;
            }
        }

        private int mealQuantity = 0;

        public int MealQuantity
        {
            get => mealQuantity;

            private set
            {
                mealQuantity = value;
            }
        }

        private string[] ListOfMealWhichAnimalEat = { };

        #endregion

    #region Functions - Methods
        virtual public void Play()
        {
            if(Energy >= 100)
            {
                for (int i = 0; i < 4; i++)
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"{Nickname} is playing ! ... ");
                }
                Energy -= 100;
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This animal did not have any energy to play ! ");
                Console.ResetColor();
            }
        }

        virtual public void Sleep()
        {
            for (int i = 0; i < 6; i++)
            {
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine($"{Nickname} is sleeping ! ... ");
            }
            Energy += 500;
            Console.Clear();
        }

        virtual public void Eat(Meal meal)
        {
            if(meal == Meal.Meat){ Console.WriteLine($"{Nickname} is eating {meal} ! "); Price += 250; Energy += (int)Meal.Meat;Array.Resize(ref ListOfMealWhichAnimalEat, MealQuantity + 1); ListOfMealWhichAnimalEat[MealQuantity] = Meal.Meat.ToString();MealQuantity++; Thread.Sleep(850); Console.Clear(); }

            else if(meal == Meal.Tomato) { Console.WriteLine($"{Nickname} is eating {meal} ! "); Price += 100; Energy += (int)Meal.Tomato; Array.Resize(ref ListOfMealWhichAnimalEat, MealQuantity + 1); ListOfMealWhichAnimalEat[MealQuantity] = Meal.Tomato.ToString(); MealQuantity++; Thread.Sleep(850); Console.Clear(); }

            else if(meal == Meal.Banana) { Console.WriteLine($"{Nickname} is eating {meal} ! "); Price += 150; Energy += (int)Meal.Banana; Array.Resize(ref ListOfMealWhichAnimalEat, MealQuantity + 1); ListOfMealWhichAnimalEat[MealQuantity] = Meal.Banana.ToString(); MealQuantity++; Thread.Sleep(850); Console.Clear(); }

            else if(meal == Meal.Chicken) { Console.WriteLine($"{Nickname} is eating {meal} ! "); Price += 200; Energy += (int)Meal.Chicken; Array.Resize(ref ListOfMealWhichAnimalEat, MealQuantity + 1); ListOfMealWhichAnimalEat[MealQuantity] = Meal.Chicken.ToString(); MealQuantity++; Thread.Sleep(850); Console.Clear(); }

            else if(meal == Meal.Brocolli) { Console.WriteLine($"{Nickname} is eating {meal} ! "); Price += 120; Energy += (int)Meal.Brocolli; Array.Resize(ref ListOfMealWhichAnimalEat, MealQuantity + 1); ListOfMealWhichAnimalEat[MealQuantity] = Meal.Brocolli.ToString(); MealQuantity++; Thread.Sleep(850); Console.Clear(); }

            else if(meal == Meal.Salad) { Console.WriteLine($"{Nickname} is eating {meal} ! "); Price += 190; Energy += (int)Meal.Salad; Array.Resize(ref ListOfMealWhichAnimalEat, MealQuantity + 1); ListOfMealWhichAnimalEat[MealQuantity] = Meal.Salad.ToString(); MealQuantity++; Thread.Sleep(850); Console.Clear(); }

            else if(meal == Meal.Barbecue) { Console.WriteLine($"{Nickname} is eating {meal} ! "); Price += 500; Energy += (int)Meal.Barbecue; Array.Resize(ref ListOfMealWhichAnimalEat, MealQuantity + 1); ListOfMealWhichAnimalEat[MealQuantity] = Meal.Barbecue.ToString(); MealQuantity++; Thread.Sleep(850); Console.Clear(); }
        }
           

        virtual public void ShowAnimalInfo()
        {
            Console.WriteLine($"Nickname : {Nickname} ");
            Console.WriteLine($"Age : {Age} ");
            Console.WriteLine($"Gender : {Gender} ");
            Console.WriteLine($"Price : {Price}$ ");
            if(ListOfMealWhichAnimalEat.Length == 0)
            {
                Console.Write("Total Meal That Animal Ate : ");
                Console.WriteLine("This animal did not eat yet ! ");
            }
            else
            {
                Console.WriteLine("Total Meal That Animal Ate : ");
                for (int i = 0;i < ListOfMealWhichAnimalEat.Length;i++)
                {
                    Console.WriteLine($"{i+1}){ListOfMealWhichAnimalEat[i]}");
                }

            }
            Console.WriteLine($"Total Animal Energy : {Energy} ");
        }


        #endregion


        #region Constructor

        public Animal(string ? nickname , int age, char ? gender)
        {
            if (nickname == null || gender == null || age == 0)
            {
                throw new Exception("Nickname && Gender can not be null ! Age can not be zero ! ");
            }
            else
            {
                Nickname = nickname;
                Age = age;
                Gender = gender;
            }
        }

        #endregion
    }
    #endregion

    #region Cat

    class Cat : Animal
    {
        private AnimalType type = AnimalType.Cat;
        public AnimalType Type
        {
            get => type; 
        }

        public Cat(string? nickname, int age, char? gender) : base(nickname, age, gender)
        {
        }

        public override void Eat(Meal meal)
        {
            base.Eat(meal);
        }

        public override void Play()
        {
            base.Play();
        }

        public override void Sleep()
        {
            base.Sleep();
        }

        public override void ShowAnimalInfo()
        {
            Console.WriteLine("Type : {0}",Type);
            base.ShowAnimalInfo();
        }

        

    }
    #endregion

    #region Dog

    class Dog : Animal
    {
        private AnimalType type = AnimalType.Dog;
        public AnimalType Type
        {
            get => type;
        }

        public Dog(string? nickname, int age, char? gender) : base(nickname, age, gender)
        {
        }

        public override void Eat(Meal meal)
        {
            base.Eat(meal);
        }

        public override void Play()
        {
            base.Play();
        }

        public override void Sleep()
        {
            base.Sleep();
        }

        public override void ShowAnimalInfo()
        {
            Console.WriteLine("Type : {0}", Type);
            base.ShowAnimalInfo();
        }
    }

    #endregion

    #region Bird

    class Bird : Animal
    {
        private AnimalType type = AnimalType.Bird;
        public AnimalType Type
        {
            get => type;
        }

        public Bird(string? nickname, int age, char? gender) : base(nickname, age, gender)
        {
        }

        public override void Eat(Meal meal)
        {
            base.Eat(meal);
        }

        public override void Play()
        {
            base.Play();
        }

        public override void Sleep()
        {
            base.Sleep();
        }

        public override void ShowAnimalInfo()
        {
            Console.WriteLine("Type : {0}", Type);
            base.ShowAnimalInfo();
        }
    }

    #endregion

    #region Fish

    class Fish : Animal
    {
        private AnimalType type = AnimalType.Fish;
        public AnimalType Type
        {
            get => type;
        }

        public Fish(string? nickname, int age, char? gender) : base(nickname, age, gender)
        {
        }

        public override void Eat(Meal meal)
        {
            base.Eat(meal);
        }

        public override void Play()
        {
            base.Play();
        }

        public override void Sleep()
        {
            base.Sleep();
        }

        public override void ShowAnimalInfo()
        {
            Console.WriteLine("Type : {0}", Type);
            base.ShowAnimalInfo();
        }
    }

    #endregion

    enum Meal { Meat = 500, Tomato = 150, Banana = 300, Chicken = 250, Brocolli = 350, Salad = 450, Barbecue = 650 }
    enum AnimalType { Cat = 1, Dog, Bird, Fish }

}

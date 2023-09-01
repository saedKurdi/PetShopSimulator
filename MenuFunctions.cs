namespace AnimalControlSystem
{

    static class MenuFunctions
    { 
        public static string[] MenuStrings = new string[]
         {
              "S H O W   A L L   A N I M A L S '   I N F O",
              "S H O W   A L L   C A T S '  I N F O",
              "S H O W   A L L   D O G S '   I N F O",
              "S H O W   A L L   B I R D S '   I N F O",
              "S H O W   A L L   F I S H E S '   I N F O",
              "P L A Y   W I T H   A N I M A L",
              "F E E D   A N I M A L",
              "P U T   T O   S L E E P   A N I M A L",
              "A D D   A N   A N I M A L",
              "R E M O V E   A N I M A L   B Y   N I C K N A M E",
             "<--- E X I T "
         };

        public static string[] AllMeal =
            {
                "Meat","Tomato","Banana","Chicken","Brocolli","Salad","Barbecue"
            };


        public static int Menu(string[] elementsToShow)
        {
            int count = 0;
            while (true)
            {
                Console.Clear();
                if (count == -1) count = elementsToShow.Length - 1; if (count == elementsToShow.Length) count = 0;
                for (int i = 0; i < elementsToShow.Length; i++)
                {

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    if (i == count)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine($"\t\t\t\t{elementsToShow[i]} ");
                        Console.WriteLine();
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"\t\t\t\t{elementsToShow[i]} ");
                        Console.WriteLine();

                    }
                }
                var result = Console.ReadKey();
                if (result.Key == ConsoleKey.Enter) return count;
               
                switch (result.Key)
                {
                    case ConsoleKey.UpArrow:
                        count--;
                        break;
                    case ConsoleKey.DownArrow:
                        count++;
                        break;    

                }
            }

        }
       


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Toets
{
    class Program
    {
        static void Main(string[] args)
        {
            string chosenDrink;
            List<string> ingredients;
            int sandwichLength = 0;
            ingredients = AskIngredients();
            chosenDrink = AskDrinks();

            sandwichLength = ingredients.Count;
            Console.WriteLine("- Een sandwich met " + sandwichLength + " ingredienten.");
            Console.WriteLine("- Drankje :" + chosenDrink);
            float price = 0;
            if (chosenDrink != null)
            {
                price = price + 2.50f;
            }
            for (int i = 0; i < ingredients.Count; i++)
            {
                price = price + 1.20f;
            }
            

            Console.WriteLine("Dat word dan " + price.ToString() + " euro.");
            Console.WriteLine("Druk op ENTER om het programma af te sluiten.");
            Console.ReadLine();


        }


        static string AskDrinks()
        {
            string[] drinks = new string[] {"Cola", "Appelsap", "Koffie", "Thee", "Water"};

            Console.WriteLine("We hebben de volgende drankjes:");

            for (int i = 0; i < drinks.Length; i++)
            {
                Console.WriteLine(" - " + drinks[i]);
            }

            Console.WriteLine("Wat zou u graag willen drinken? (Let erop dat het hoofdletter gevoelig kan zijn)");
            string userInput = Console.ReadLine();
            string chosenDrink = null;
            for (int i = 0; i < drinks.Length; i++)
            {
                if (drinks[i].Contains(userInput))
                {
                    chosenDrink = drinks[i];
                    break;
                }

                else
                {
                    chosenDrink = null;
                }
            }

            return chosenDrink;
        }

        static List<string> AskIngredients()
        {
            List<string> ingredients = new List<string> { };

            string userInput = "";
            Console.WriteLine("Wat wil je graag op je sandwich?");
            while (userInput.Contains("klaar") == false)
            {
                userInput = Console.ReadLine();
                ingredients.Add(userInput);
            }
            ingredients.Remove("klaar");
            return ingredients;
        }


    }
}

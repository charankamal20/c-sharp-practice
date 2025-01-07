using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookiesCookbook.Recipe;

namespace CookiesCookbook.ConsoleManager
{
    public static class ConsoleManager
    {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to Cookie Cookbook!");
        }

        public static void PrintAvailableIngredients(List<Ingredients.Ingredient> ingredients)
        {
            Console.WriteLine("Create a new cookie recipe! Available ingredients are: ");
            foreach(var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.ID}. {ingredient.Name}");
            }
        }

        public static void PrintRecipe(Recipe.Recipe recipe)
        {
            Console.WriteLine(recipe.GiveRecipeInstructions());
        }

        public static bool TakeConsoleIntegerInput(string message, out int result)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
                       
            if(input is not null && int.TryParse(input, out result))
            {
                return true;
            }
            result = int.MinValue;
            return false;
        }
    }
}

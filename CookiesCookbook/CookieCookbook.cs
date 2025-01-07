// Cookie Cookbook 
using CookiesCookbook.ConsoleManager;
using CookiesCookbook.Ingredients;
using CookiesCookbook.Recipe;
using CookiesCookbook.Database;

public class CookieCookbook
{
    public List<Recipe> Recipes;
    public List<Ingredient> AvailableIngredients { get; set; }
    public IDatabase Store { get; set; }

    public CookieCookbook(List<Ingredient> ingredients, DBType dbType)
    {
        AvailableIngredients = ingredients;
        if(dbType == DBType.Txt)
        {
            Store = new TxtStore();
        }
        else
        {
            Store = new JSONStore();
        }

        if (Store.TryReadRecipe(out List<List<int>> recipes))
        {
            Recipes = new();
            foreach(var ingredientIDs in recipes)
            {
                Recipes.Add(ParseIngredientIDsToRecipe(ingredientIDs));
            }

            PrintAvailableRecipes();
        }
        else
        {
            Recipes = new List<Recipe>();
        }
    }

    public void PrintAvailableRecipes()
    {
        Console.WriteLine("Existing Recipes are: \n\n");

        int i = 1;
        foreach(var recipe in Recipes) 
        {       
            Console.WriteLine("***** " + i + " *****");
            ConsoleManager.PrintRecipe(recipe);
            i++;
        }
        Console.WriteLine();
    }

    public void Run()
    {
        List<Ingredient> ingredients = new List<Ingredient>();
        ConsoleManager.PrintWelcomeMessage();
        ConsoleManager.PrintAvailableIngredients(AvailableIngredients);

        while (true)
        {
            if (!ConsoleManager.TakeConsoleIntegerInput("Add an ingredient by its ID or type anything else if finished.", out int index))
            {
                if (ingredients.Count == 0)
                {
                    Console.WriteLine("No Ingredient Added!");
                }
                else
                {
                    AddNewRecipe(new Recipe(ingredients));
                }
                break;
            }
            else
            {
                if(IsValidID(index, out Ingredient targetIngredient))
                {
                    ingredients.Add(targetIngredient);
                }
                else
                {
                    Console.WriteLine("Invalid Index! No Ingredient Added.");
                }
            }
        }
    }

    private bool IsValidID(int inputID, out Ingredient targetIngredient)
    {
        targetIngredient = null;
        foreach(var ingredient in AvailableIngredients)
        {
            if(inputID == ingredient.ID)
            {
                targetIngredient = ingredient;
                return true;
            }
        }

        return false;
    }

    private void AddNewRecipe(Recipe newRecipe)
    {
        Recipes.Add(newRecipe);
        Console.WriteLine("Recipe Added");
        ConsoleManager.PrintRecipe(newRecipe);
        Store.TryWriteRecipe(newRecipe);
    }

    private Recipe ParseIngredientIDsToRecipe(List<int> ingredientIDs)
    {
        List<Ingredient> result = new();
        foreach(var id in  ingredientIDs)
        {
            if (IsValidID(id, out Ingredient targetIngredient))
            {
                result.Add(targetIngredient);
            }
        }

        return new Recipe(result);
    }
}
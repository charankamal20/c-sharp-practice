// Cookie Cookbook 

// Cookie Cookbook 
namespace CookiesCookbook.Database;

public class TxtStore : IDatabase
{
    public string Extension { get; } = ".txt";

    public bool TryReadRecipe(out List<List<int>>? Recipes)
    {
        Recipes = null;
        if (!File.Exists(IDatabase.Name + Extension))
        {
            return false;
        }

        string[] recipes = File.ReadAllLines(IDatabase.Name + Extension);
        if (recipes.Length == 0)
        {
            return false;
        }

        Recipes = new List<List<int>>();

        int i = 0;
        foreach (string recipe in recipes)
        {
            var indexes = recipe.Split(',');
            Recipes.Add(new List<int>());
            foreach (var index in indexes)
            {
                if (int.TryParse(index, result: out int r))
                {
                    Recipes[i].Add(r);
                }
            }
            i++;
        }

        return true;
    }

    public bool TryWriteRecipe(Recipe.Recipe recipe)
    {
        string recipeString = "";
        foreach (var rec in recipe.GetIngredientIDs())
        {
            recipeString += rec.ToString() + ",";
        }

        File.AppendAllText(IDatabase.Name + Extension, recipeString.Substring(0, recipeString.Length - 1) + Environment.NewLine);
        return true;
    }
}

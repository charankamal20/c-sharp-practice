// Cookie Cookbook 

// Cookie Cookbook 
using System.Text.Json;

namespace CookiesCookbook.Database;

public class JSONStore : IDatabase
{
    public string Extension { get; } = ".json";

    public bool TryReadRecipe(out List<List<int>> Recipes)
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
        foreach (var recipe in recipes)
        {
            List<int>? item = JsonSerializer.Deserialize<List<int>>(recipe);
            Recipes.Add(item);
        }

        return true;
    }

    public bool TryWriteRecipe(Recipe.Recipe recipe)
    {
        string json = JsonSerializer.Serialize(recipe.GetIngredientIDs());
        File.AppendAllText(IDatabase.Name + Extension, json + Environment.NewLine);
        return json.Length > 0;
    }
}

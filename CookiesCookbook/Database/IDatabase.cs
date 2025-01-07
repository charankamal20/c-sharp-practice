// Cookie Cookbook 

// Cookie Cookbook 
namespace CookiesCookbook.Database;

public enum DBType
{
    Json,
    Txt,
}

public interface IDatabase
{
    const string Name = "recipes";
    string Extension { get; }
    bool TryReadRecipe(out List<List<int>> Recipes);
    bool TryWriteRecipe(Recipe.Recipe recipe);
}

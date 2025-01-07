using CookiesCookbook.Ingredients;
namespace CookiesCookbook.Recipe
{
    public class Recipe
    {
        public List<Ingredient> Ingredients { get; set; }

        public Recipe(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public List<int> GetIngredientIDs()
        {
            List<int> result = new();
            foreach(var ingredient in Ingredients) 
            {
                result.Add(ingredient.ID);  
            }

            return result;
        }

        public string GiveRecipeInstructions()
        {
            string result = "";
            foreach (var ingredient in Ingredients)
            {
                result += $"{ingredient.Name}. {ingredient.Instructions()}\n";
            }
            return result;
        }
    }
}

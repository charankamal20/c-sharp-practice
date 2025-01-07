// Cookie Cookbook 
using CookiesCookbook.Ingredients;
using CookiesCookbook.Database;

List<Ingredient> availableIngredients = new List<Ingredient>
{
    new WheatFlour(),
    new CoconutFlour(),
    new Butter(),
    new Chocolate(),
    new Sugar(),
    new Cardamom(),
    new Cinnamon(),
    new CocoaPowder()
};

CookieCookbook cookbook = new CookieCookbook(availableIngredients, DBType.Json);
cookbook.Run();
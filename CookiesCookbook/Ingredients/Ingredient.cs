// Cookie Cookbook 
namespace CookiesCookbook.Ingredients;

public abstract class Ingredient
{
    public abstract int ID { get; }
    public abstract string Name { get; }

    public abstract string Instructions();
}




public class WheatFlour : Ingredient
{
    public override string Name { get; } = "Wheat Flour";

    public override int ID { get; } = 1;

    public override string Instructions() => "Sieve. Add to other ingredients.";
}

public class CoconutFlour : Ingredient
{
    public override string Name { get; } = "Coconut Flour";

    public override int ID { get; } = 2;
    public override string Instructions() => "Sieve. Add to other ingredients.";
}

public class Butter : Ingredient
{

    public override int ID { get; } = 3;
    public override string Name { get; } = "Butter";

    public override string Instructions() => "Melt on low heat. Add to other ingredients.";
}

public class Chocolate : Ingredient
{
    public override int ID { get; } = 4;
    public override string Name { get; } = "Chocolate";

    public override string Instructions() => "Melt in a water bath. Add to other ingredients.";
}

public class Sugar : Ingredient
{
    public override int ID { get; } = 5;
    public override string Name { get; } = "Sugar";

    public override string Instructions() => "Add to other ingredients.";
}

public class Cardamom : Ingredient
{
    public override int ID { get; } = 6;
    public override string Name { get; } = "Cardamom";

    public override string Instructions() => "Take half a teaspoon. Add to other ingredients.";
}

public class Cinnamon : Ingredient
{
    public override int ID { get; } = 7;
    public override string Name { get; } = "Cinnamon";

    public override string Instructions() => "Take half a teaspoon. Add to other ingredients.";
}

public class CocoaPowder : Ingredient
{
    public override int ID { get; } = 8;
    public override string Name { get; } = "Cocoa Powder";

    public override string Instructions() => "Add to other ingredients.";
}




using DiceGame.Game;

Player player = new Player("Charan");
Dice dice = new Dice();
GameController controller = new GameController(player, dice);

controller.Run();

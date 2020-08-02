

class Game {
	
	public static void Main(){
		Universe universe = new Universe(new RoomData("A Tavern"));
		universe.addCharacter(new Character(new AIMind(), new Entity("Elf")));
		PlayerMind player = new PlayerMind(new UserIO.ConsoleIO());
		universe.addCharacter(new Character(player, new Entity("Player")));
		universe.addCharacter(new Character(new AIMind(), new Entity("Dwarf")));
		universe.addCharacter(new Character(new AIMind(), new Entity("Goblin")));
		universe.mainLoop();
	}
}

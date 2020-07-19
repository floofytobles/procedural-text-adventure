

class Game {
	
	public static void Main(){
		Room room = new Room("A Tavern");
		Universe universe = new Universe(room);
		universe.addCharacter(new Character(new AIMind(), new Entity("Elf")));
		PlayerMind player = new PlayerMind(new UserIO.ConsoleIO());
		universe.addCharacter(new Character(player, new Entity("Player")));
		universe.addCharacter(new Character(new AIMind(), new Entity("Dwarf")));
		universe.addCharacter(new Character(new AIMind(), new Entity("Goblin")));
		while (true) {
			universe.runRound();
		}
	}
}

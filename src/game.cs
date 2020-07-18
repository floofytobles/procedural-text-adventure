

class Game {
	
	public static void Main(){
		Room room = new Room("A Tavern");
		room.addCharacter(new AIMind(new Entity("Elf")));
		PlayerMind player = new PlayerMind(new UserIO.ConsoleIO(), new Entity("Player"));
		room.addCharacter(player);
		room.addCharacter(new AIMind(new Entity("Dwarf")));
		room.addCharacter(new AIMind(new Entity("Goblin")));
		while (true) {
			room.runRound();
		}
	}
}

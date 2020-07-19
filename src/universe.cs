
using System.Collections.Generic;

class Universe {
	
	private List<Character> characters = new List<Character>();
	
	private Room room;
	
	
	public Universe(Room room){
		this.room = room;
	}
	
	public void mainLoop(){
		while (true){
			runRound();
		}
	}
	
	public void runRound(){
		// runs a round of the main loop. All characters take a turn to take an action
		foreach (Character character in characters) {
			while (true){
				GameCommand command = character.mind.decideAction(character.body, room);
				if (command is GameCommand.ActionCommand actionCommand){
					executeAction(actionCommand.action);
					break;
				} else if (command is GameCommand.Meta meta){
					executeMeta(meta.command, meta.io);
				}
			}
		}
	}
	
	
	public void addCharacter(Character character){
		this.room.entities.Add(character.body);
		this.characters.Add(character);
		character.mind.observe(new GameEvent("You are in " + room.name));
	}
	
	public void executeAction(Action action) {
		GameEvent result = action.getResult();
		foreach (Character observer in characters) {
			observer.mind.observe(result);
		}
	}
	public void executeMeta(MetaCommand command, UserIO.GameIO io){
		switch (command){
			case MetaCommand.Save _s:
				io.printLine("saving not implemented yet");
				break;
			case MetaCommand.Leave _s:
				io.printLine("leaving not implemented yet. use Ctrl-C to stop the application");
				break;
		}
	}
}

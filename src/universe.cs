
using System.Collections.Generic;

class Universe {
	
	private List<Character> characters = new List<Character>();
	
	private Room room;
	
	
	public Universe(Room room){
		this.room = room;
	}
	
	public void runRound(){
		// runs a round of the main loop. All characters take a turn to take an action
		foreach (Character character in characters) {
			while (true){
				Command command = character.mind.decideAction(character.body, room);
				if (command is Command.GameAction actionCommand){
					executeAction(actionCommand.action);
					break;
				} else if (command is Command.Meta meta){
					executeMeta();
				}
			}
		}
	}
	
	
	public void addCharacter(Character character){
		this.entities.Add(character.getBody());
		this.characters.Add(character);
		character.observe(new GameEvent("You are in " + room.describe()));
	}
	
	public void execute(Action action) {
		GameEvent result = action.getResult()
		foreach (Character observer in characters) {
			observer.observe(result);
		}
	}
}


using System.Collections.Generic;

class Universe {
	
	private List<Character> characters = new List<Character>();
	
	private Room room;
	
	
	public Universe(Room room){
		this.room = room;
	}
	
	public void mainLoop(){
		while (true){
		// runs a round of the main loop. All characters take a turn to take an action
			foreach (Character character in characters) {
				while (true){
					ConcreteCommand command = character.mind.decideAction(room, character.body);
					if (command is ConcreteCommand.GameAction a){
						executeAction(a.action);
						break;
					} else if (command is ConcreteCommand.Meta m){
						switch (m.command) {
							case MetaCommand.Save _s:
								m.io.printLine("Saving not implemented");
								break;
							case MetaCommand.Leave _l:
								m.io.printLine("Closing game");
								return;
						}
					}
				}
			}
		}
	}
	
	public void addCharacter(Character character){
		this.room.entities.Add(character.body);
		this.characters.Add(character);
		character.mind.observe(new GameEvent("You are in " + room.name));
	}
	
	public void executeAction(Action action){
		GameEvent result = action.getResult();
		foreach (Character observer in characters) {
			observer.mind.observe(result);
		}
	}
}

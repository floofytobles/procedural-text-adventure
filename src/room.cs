
using System.Collections.Generic;

class Room {
	
	private ISet<Entity> entities = new HashSet<Entity>();
	private List<Mind> minds = new List<Mind>();
	
	private string name;
	
	public Room(string name){
		this.name = name;
	}
	
	public void runRound(){
		// runs a round of the main loop. All minds take a turn to take an action
		foreach (Mind mind in this.minds) {
			// todo: pass in room state
			Action action = mind.decideAction();
			// todo: possible reactions
			GameEvent result = this.execute(action);
			foreach (Mind observer in this.minds) {
				observer.observe(result);
			}
		}
	}
	
	public void addCharacter(Mind mind){
		this.entities.Add(mind.getBody());
		this.minds.Add(mind);
		mind.observe(new GameEvent("You are in " + this.describe()));
	}
	
	public GameEvent execute(Action action) {
		return action.getResult();
	}
	
	public string describe(){
		return name;
	}
}

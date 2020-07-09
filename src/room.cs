
using System.Collections.Generic;

class Room {
	
	private List<Entity> entities = new List<Entity>(); // todo: this should be a set
	private List<Mind> minds = new List<Mind>();
	
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
	}
	
	public GameEvent execute(Action action) {
		return action.getResult();
	}
}

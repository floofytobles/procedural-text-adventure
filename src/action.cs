

class Action {
	
	// todo: this will be a list
	private Entity actor;
	private ActionType type;
	
	public Action(ActionType type, Entity actor){
		this.type = type;
		this.actor = actor;
	}
	
	// placeholder until we have physics to decide the result of an action
	public GameEvent getResult(){
		return new GameEvent(
			System.String.Format(type.getDescription(), actor.getName())
		);
	}
}

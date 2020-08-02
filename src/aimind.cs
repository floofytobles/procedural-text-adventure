

class AIMind : Mind {
	
	public ConcreteCommand decideAction(Room room, Entity body){
		System.Random rand = new System.Random();
		ActionType actionType = ActionType.POSSIBLE_ACTIONS[rand.Next(ActionType.POSSIBLE_ACTIONS.Length)];
		return new ConcreteCommand.GameAction(new Action(actionType, body));
	}
	
	public void observe(GameEvent gameEvent){ }
	
}

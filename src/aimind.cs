

class AIMind : Mind {
	
	private Entity body;
	
	public AIMind(Entity body){
		this.body = body;
	}
	
	public Action decideAction(){
		System.Random rand = new System.Random();
		ActionType actionType = ActionType.POSSIBLE_ACTIONS[rand.Next(ActionType.POSSIBLE_ACTIONS.Length)];
		return new Action(actionType, this.body);
	}
	
	public void observe(GameEvent gameEvent){ }
		
	
	public Entity getBody(){
		return this.body;
	}
	
}

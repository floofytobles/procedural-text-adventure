

class PlayerMind : Mind {
	
	private UserIO.GameIO io;
	private Entity body;
	
	public PlayerMind(UserIO.GameIO io, Entity body){
		this.io = io;
		this.body = body;
	}
	
	public void observe(GameEvent gameEvent){
		this.io.printLine(gameEvent.describe());
	}
	
	public Action decideAction(){
		
		ActionType? actionType = null;
		
		while (actionType == null){
			string? input = io.readLine();
			actionType = Parser.readAction(input ?? "");
			if (actionType == null) {
				io.printLine("Invalid input: " + input);
			}
		}
		Action action = new Action(actionType, this.body);
		return action;
	}
	
	public Entity getBody(){
		return this.body;
	}
}

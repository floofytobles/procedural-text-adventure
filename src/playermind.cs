

class PlayerMind : Mind {
	
	private UserIO.GameIO io;
	
	public PlayerMind(UserIO.GameIO io){
		this.io = io;
	}
	
	public void observe(GameEvent gameEvent){
		this.io.printLine(gameEvent.describe());
	}
	
	private InputCommand getCommand(){
		while (true){
			string? input = io.readLine();
			InputCommand? command = Parser.parseCommand(input);
			if (command == null) {
				io.printLine("Invalid input: " + input);
			} else {
				return command;
			}
		}
	}
	
	public GameCommand decideAction(Entity body, Room room){
		while (true){
			switch (getCommand()) {
				case InputCommand.GameAction actionCommand:
					return new GameCommand.ActionCommand(new Action(actionCommand.action, body));
				case InputCommand.Query queryCommand:
					io.printLine("Querying not yet implemented");
					break;
				case InputCommand.Meta metaCommand:
					return new GameCommand.Meta(metaCommand.command, io);
			
			}
		}
	}
}

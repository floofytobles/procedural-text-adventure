

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
	
	public ConcreteCommand decideAction(Room room, Entity body){
		while (true){
			switch (getCommand()) {
				case InputCommand.GameAction actionCommand:
					return new ConcreteCommand.GameAction(new Action(actionCommand.action, body));
				case InputCommand.Query queryCommand:
					io.printLine("You are blind");
					break;
				case InputCommand.Meta metaCommand:
					return new ConcreteCommand.Meta(metaCommand.command, this.io);
			}
		}
	}
}

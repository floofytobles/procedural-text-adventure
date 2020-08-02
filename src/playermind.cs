

class PlayerMind : Mind {
	
	private UserIO.GameIO io;
	
	public PlayerMind(UserIO.GameIO io){
		this.io = io;
	}
	
	public void observe(GameEvent gameEvent){
		this.io.printLine(gameEvent.describe());
	}
	
	private Command getCommand(){
		while (true){
			string? input = io.readLine();
			Command? command = Parser.parseCommand(input);
			if (command == null) {
				io.printLine("Invalid input: " + input);
			} else {
				return command;
			}
		}
	}
	
	public ConcreteCommand decideAction(RoomData room, Entity body){
		while (true){
			switch (getCommand()) {
				case Command.GameAction actionCommand:
					return new ConcreteCommand.GameAction(new Action(actionCommand.action, body));
				case Command.Query queryCommand:
					io.printLine("You are blind");
					break;
				case Command.Meta metaCommand:
					return new ConcreteCommand.Meta(metaCommand.command, this.io);
			}
		}
	}
}



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
	
	public Action decideAction(){
		while (true){
			switch (getCommand()) {
				case Command.GameAction actionCommand:
					return new Action(actionCommand.action, this.body);
				case Command.Query queryCommand:
					io.printLine("You are blind");
					break;
				case Command.Meta metaCommand:
					switch (metaCommand.command) {
						case MetaCommand.Save _s:
							io.printLine("Saving not implemented");
							break;
						case MetaCommand.Leave _l:
							io.printLine("Leaving not implemented");
							break;
					}
					break;
			}
		}
	}
	
	public Entity getBody(){
		return this.body;
	}
}

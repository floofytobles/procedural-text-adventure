

class Parser {
	
	public static InputCommand? parseCommand(string? input){
		if (input == null){
			return new InputCommand.Meta(new MetaCommand.Leave());
		}
		if (input == ""){
			return null;
		}
		if (input[0] == '/'){
			MetaCommand? meta = MetaCommand.parse(input.Substring(1));
			if (meta == null){
				return null;
			}
			return new InputCommand.Meta(meta);
		}
		ActionType? action = Parser.parseAction(input);
		if (action == null){
			return null;
		}
		return new InputCommand.GameAction(action);
	}
	
	public static ActionType? parseAction(string input){
		string command = input.ToLower().Trim();
		foreach (ActionType act in ActionType.POSSIBLE_ACTIONS){
			if (act.getName() == command){
				return act;
			}
		}
		return null;
	}
}

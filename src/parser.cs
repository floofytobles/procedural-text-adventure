

class Parser {
	public static ActionType? readAction(string input){
		string command = input.ToLower().Trim();
		foreach (ActionType act in ActionType.POSSIBLE_ACTIONS){
			if (act.getName() == command){
				return act;
			}
		}
		return null;
	}
}

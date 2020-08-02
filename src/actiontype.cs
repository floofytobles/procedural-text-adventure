

class ActionType {
	
	
	private string description;
	private string name;
	
	public ActionType(string name, string description){
		this.name = name;
		this.description = description;
	}
	
	public string getName(){
		return this.name;
	}
	
	public string getDescription(){
		return this.description;
	}
	
	public static ActionType SING = new ActionType("sing", "{0} sings");
	public static ActionType DANCE = new ActionType("dance", "{0} dances");
	public static ActionType WHISTLE = new ActionType("whistle", "{0} whistles");
	public static ActionType SLEEP = new ActionType("sleep", "{0} sleeps");
	
	public static ActionType[] POSSIBLE_ACTIONS = {
		SING,
		DANCE,
		WHISTLE,
		SLEEP
	};
}

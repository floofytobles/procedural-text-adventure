



// This class works similar to haskell types or rust enums:
// The value is one of a few different structures
abstract class MetaCommand {
	// don't allow anyone else to inherit from this class
	private MetaCommand(){}
	
	public static MetaCommand? parse(string input){
		int commandLength = input.IndexOf(' ');
		if (commandLength < 0){
			commandLength = input.Length;
		}
		string commandPart = input.Substring(0, commandLength);
		switch (commandPart) {
			case "leave":
				return new Leave();
			case "close":
				return new Leave();
			case "quit":
				return new Leave();
			case "save":
				return new Save();
			default:
				return null;
		}
	}

	public sealed class Leave : MetaCommand {}
	public sealed class Save : MetaCommand {}
}

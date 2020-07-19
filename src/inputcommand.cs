

// This class works similar to haskell types or rust enums:
// The value is one of a few different structures
public abstract class InputCommand {
	// don't allow anyone else to inherit from this class
	private InputCommand(){}

	public sealed class GameAction : InputCommand {
		public ActionType action {get;}
		public GameAction(ActionType action) => this.action = action;
	}

	public sealed class Meta : InputCommand {
		public MetaCommand command {get;}
		public Meta(MetaCommand command) => this.command = command;
	}
	
	public sealed class Query : InputCommand {}
}

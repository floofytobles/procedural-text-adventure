

// This class works similar to haskell types or rust enums:
// The value is one of a few different structures
public abstract class Command {
	// don't allow anyone else to inherit from this class
	private Command(){}

	public sealed class GameAction : Command {
		public ActionType action {get;}
		public GameAction(ActionType action) => this.action = action;
	}

	public sealed class Meta : Command {
		public MetaCommand command {get;}
		public Meta(MetaCommand command) => this.command = command;
	}
	
	public sealed class Query : Command {}
}

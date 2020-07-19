

// This class works similar to haskell types or rust enums:
// The value is one of a few different structures
public abstract class GameCommand {
	// don't allow anyone else to inherit from this class
	private GameCommand(){}

	public sealed class ActionCommand : GameCommand {
		public Action action {get;}
		public ActionCommand(Action action) => this.action = action;
	}

	public sealed class Meta : GameCommand {
		public MetaCommand command {get;}
		public UserIO.GameIO io {get;}
		public Meta(MetaCommand command, UserIO.GameIO io) {
			this.command = command;
			this.io = io;
		}
	}
	
}

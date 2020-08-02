

// This class works similar to haskell types or rust enums:
// The value is one of a few different structures
abstract class ConcreteCommand {
	// don't allow anyone else to inherit from this class
	private ConcreteCommand(){}

	public sealed class GameAction : ConcreteCommand {
		public Action action {get;}
		public GameAction(Action action) => this.action = action;
	}

	public sealed class Meta : ConcreteCommand {
		public MetaCommand command {get;}
		public UserIO.GameIO io {get;}
		public Meta(MetaCommand command, UserIO.GameIO io){
			this.command = command;
			this.io = io;
		}
	}
	
}

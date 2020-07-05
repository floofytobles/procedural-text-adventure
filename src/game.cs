

class Game {
	
	public static void Main(){
		UserIO.GameIO io = new UserIO.ConsoleIO();
		string? input = "";
		io.printLine("Welcome to the game");
		while (input != "quit") {
			input = io.readLine();
			if (input == null){
				break;
			}
			io.printLine("You said: " + input);
		}
		io.printLine("Goodbye");
	}
}

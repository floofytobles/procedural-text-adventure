
#include "userio.h"
#include "consoleio.h"

int main(int argc, char *argv[]){
	
	IUserIO *io = new ConsoleIO();
	io->printLine("Welcome to the game");
	std::string input;
	while (input != "quit"){
		if (!io->readLine(input)){
			break;
		}
		io->printLine("You said: " + input);
	}
	io->printLine("Goodbye!");
	return 0;
}

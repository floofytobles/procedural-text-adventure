
#include "userio.h"
#include "consoleio.h"
#include <memory>

int main(int argc, char *argv[]){
	
	std::unique_ptr<IUserIO> io = std::make_unique<ConsoleIO>();
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

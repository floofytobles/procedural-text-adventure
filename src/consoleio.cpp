
#include <iostream>
#include "consoleio.h"

bool ConsoleIO::readLine(std::string &input, const std::string &prefix){
	std::cout << prefix;
	return (bool)std::getline(std::cin, input);
}

void ConsoleIO::printLine(const std::string &line){
	std::cout << line << '\n'; // will this line ending work on windows?
}

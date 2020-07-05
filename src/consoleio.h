
#include "userio.h"

class ConsoleIO : public IUserIO {
	public:
		bool readLine(std::string &input, const std::string &prefix);
		void printLine(const std::string &line);
};

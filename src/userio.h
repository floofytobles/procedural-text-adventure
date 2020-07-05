
#ifndef USERIO_H
#define USERIO_H

#include<string>

class IUserIO {
	
	public:
		virtual bool readLine(std::string &input, const std::string &prefix = "> ") = 0;
		virtual void printLine(const std::string &text) = 0;
		~IUserIO();
};

#endif

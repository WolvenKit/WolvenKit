#pragma once

#include <fstream>

class Logger
{
public:
	Logger(void);

	static void Log(const std::string & );

	static void Flush();

	virtual ~Logger(void);

};


#include "StdAfx.h"
#include "Logger.h"
#include <time.h>

#define LOG_FILE "log.txt"

Logger::Logger(void)
{
	
}

void Logger::Log( const std::string &text )
{


	std::ofstream log_file(LOG_FILE, std::ios_base::out | std::ios_base::app);
	log_file << text.c_str();
	log_file << std::endl;
	log_file.close();
}

void Logger::Flush()
{
	
}

Logger::~Logger(void)
{
	
}

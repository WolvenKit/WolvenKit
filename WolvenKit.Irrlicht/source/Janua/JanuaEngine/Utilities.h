#pragma once

#include <string>
#include <sstream>

using std::string;
using std::ostringstream;

string NumberToString(int pNumber)
{
	ostringstream oOStrStream;
	oOStrStream << pNumber;
	return oOStrStream.str();
}
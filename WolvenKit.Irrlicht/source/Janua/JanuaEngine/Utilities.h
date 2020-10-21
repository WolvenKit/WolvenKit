#pragma once

#include <string>
#include <sstream>

using std::string;
using std::ostringstream;

namespace Janua
{
	string NumberToString(int pNumber)
	{
		ostringstream oOStrStream;
		oOStrStream << pNumber;
		return oOStrStream.str();
	}
}
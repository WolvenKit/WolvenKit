#pragma once

#include <fstream>

namespace Janua
{
	class Logger
	{
	public:
		Logger(void);

		static void Log(const std::string&);

		static void Flush();

		virtual ~Logger(void);

	};
}

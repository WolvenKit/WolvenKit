#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {

/// <summary>
/// Logging messages, warnings and errors.
/// </summary>
public ref class Logger : ReferenceCounted
{
public:

	/// <summary>
	/// Prints out a text into the log.
	/// </summary>
	/// <param name="text">Text to print out.</param>
	/// <param name="hint">Additional info. This string is added after a " :" to the string.</param>
	/// <param name="level">Log level of the text. Default is <see cref="IrrlichtLime::LogLevel::Information"/>.</param>
	void Log(String^ text, String^ hint, IrrlichtLime::LogLevel level);

	/// <summary>
	/// Prints out a text into the log.
	/// </summary>
	/// <param name="text">Text to print out.</param>
	/// <param name="level">Log level of the text. Default is <see cref="IrrlichtLime::LogLevel::Information"/>.</param>
	void Log(String^ text, IrrlichtLime::LogLevel level);

	/// <summary>
	/// Prints out a text into the log.
	/// </summary>
	/// <param name="text">Text to print out.</param>
	void Log(String^ text);

	/// <summary>
	/// Current log level.
	/// With this value, texts which are sent to the logger are filtered out.
	/// For example setting this value to <see cref="IrrlichtLime::LogLevel::Warning"/>, only warnings and errors are printed out.
	/// Setting it to <see cref="IrrlichtLime::LogLevel::Information"/>, which is the default setting, warnings, errors and informational texts are printed out.
	/// </summary>
	property IrrlichtLime::LogLevel LogLevel { IrrlichtLime::LogLevel get(); void set(IrrlichtLime::LogLevel value); }

	virtual String^ ToString() override;

internal:

	static Logger^ Wrap(irr::ILogger* ref);
	Logger(irr::ILogger* ref);

	irr::ILogger* m_Logger;
};

} // end namespace IrrlichtLime

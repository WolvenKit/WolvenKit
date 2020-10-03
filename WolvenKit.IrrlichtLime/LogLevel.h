#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {

	/// <summary>
	/// Possible log levels.
	/// When used has filter <see cref="Debug"/> means "log everything" and <see cref="None"/> means "log (nearly) nothing".
	/// When used to print logging information <see cref="Debug"/> will have lowest priority while <see cref="None"/> messages are never filtered and always printed.
	/// </summary>
	public enum class LogLevel
	{
		/// <summary>
		/// Used for printing information helpful in debugging.
		/// </summary>
		Debug = ELL_DEBUG,

		/// <summary>
		/// Useful information to print. For example hardware infos or something started/stopped.
		/// </summary>
		Information = ELL_INFORMATION,

		/// <summary>
		/// Warnings that something isn't as expected and can cause oddities.
		/// </summary>
		Warning = ELL_WARNING,

		/// <summary>
		/// Something did go wrong.
		/// </summary>
		Error = ELL_ERROR,

		/// <summary>
		/// Logs with <see cref="None"/> will never be filtered.
		/// And used as filter it will remove all logging except <see cref="None"/> messages.
		/// </summary>
		None = ELL_NONE
	};

} // end namespace IrrlichtLime

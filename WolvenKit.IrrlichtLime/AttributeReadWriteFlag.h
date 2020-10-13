#pragma once

#include "stdafx.h"

using namespace irr;
using namespace io;
using namespace System;

namespace IrrlichtLime {
namespace IO {

	[Flags]
	/// <summary>
	/// Enumeration flags passed through <c>AttributeReadWriteOptions</c> to the <c>AttributeExchangingObject</c>.
	/// </summary>
	public enum class AttributeReadWriteFlag
	{
		/// <summary>
		/// Serialization/Deserializion is done for an xml file.
		/// </summary>
		ForFile = EARWF_FOR_FILE,

		/// <summary>
		/// Serialization/Deserializion is done for an editor property box.
		/// </summary>
		ForEditor = EARWF_FOR_EDITOR,

		/// <summary>
		/// When writing filenames, relative paths should be used.
		/// </summary>
		UseRelativePaths = EARWF_USE_RELATIVE_PATHS
	};

} // end namespace IO
} // end namespace IrrlichtLime

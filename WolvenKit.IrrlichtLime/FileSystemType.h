#pragma once

#include "stdafx.h"

using namespace irr;
using namespace io;
using namespace System;

namespace IrrlichtLime {
namespace IO {

	/// <summary>
	/// Enumeration for all file system types.
	/// </summary>
	public enum class FileSystemType
	{
		/// <summary>
		/// Native OS file system.
		/// </summary>
		Native = FILESYSTEM_NATIVE,

		/// <summary>
		/// Virtual file system.
		/// </summary>
		Virtual = FILESYSTEM_VIRTUAL
	};

} // end namespace IO
} // end namespace IrrlichtLime

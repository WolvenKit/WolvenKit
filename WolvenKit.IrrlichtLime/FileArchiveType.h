#pragma once

#include "stdafx.h"

using namespace irr;
using namespace io;
using namespace System;

namespace IrrlichtLime {
namespace IO {

	/// <summary>
	/// Contains the different types of archives.
	/// </summary>
	public enum class FileArchiveType
	{
		/// <summary>
		/// A PKZIP archive.
		/// </summary>
		ZIP = EFAT_ZIP,

		/// <summary>
		/// A gzip archive.
		/// </summary>
		GZIP = EFAT_GZIP,

		/// <summary>
		/// A virtual directory.
		/// </summary>
		Folder = EFAT_FOLDER,

		/// <summary>
		/// An ID Software PAK archive.
		/// </summary>
		PAK = EFAT_PAK,

		/// <summary>
		/// A Nebula Device archive.
		/// </summary>
		NPK = EFAT_NPK,

		/// <summary>
		/// A Tape ARchive.
		/// </summary>
		TAR = EFAT_TAR,

		/// <summary>
		/// A wad archive, Quake2, Halflife.
		/// </summary>
		WAD = EFAT_WAD,

		/// <summary>
		/// The type of this archive is unknown.
		/// </summary>
		Unknown = EFAT_UNKNOWN
	};

} // end namespace IO
} // end namespace IrrlichtLime

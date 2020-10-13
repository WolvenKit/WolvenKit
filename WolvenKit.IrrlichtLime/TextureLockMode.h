#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Enumeration for the mode for texture locking.
	/// </summary>
	public enum class TextureLockMode
	{
		/// <summary>
		/// The default mode. Texture can be read and written to.
		/// </summary>
		ReadWrite = ETLM_READ_WRITE,

		/// <summary>
		/// Read only. The texture is downloaded, but not uploaded again.
		/// Often used to read back shader generated textures.
		/// </summary>
		ReadOnly = ETLM_READ_ONLY,

		/// <summary>
		/// Write only. The texture is not downloaded and might be uninitialized.
		/// The updated texture is uploaded to the GPU.
		/// Used for initializing the shader from the CPU.
		/// </summary>
		WriteOnly = ETLM_WRITE_ONLY
	};

} // end namespace Video
} // end namespace IrrlichtLime

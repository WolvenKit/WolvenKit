#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Platform specific behavior flags for the cursor.
	/// </summary>
	public enum class CursorPlatformBehavior
	{
		/// <summary>
		/// Default - no platform specific behavior.
		/// </summary>
		None = ECPB_NONE,

		/// <summary>
		/// On X11 try caching cursor updates as XQueryPointer calls can be expensive.
		/// Update cursor positions only when the irrlicht timer has been updated or the timer is stopped.
		/// This means you usually get one cursor update per <c>device.Run()</c> which will be fine in most cases.
		/// </summary>
		X11CacheUpdates = ECPB_X11_CACHE_UPDATES
	};

} // end namespace GUI
} // end namespace IrrlichtLime

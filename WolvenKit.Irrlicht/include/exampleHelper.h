// Copyright (C) 2015 Patryk Nadrowski
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __EXAMPLE_HELPER_H_INCLUDED__
#define __EXAMPLE_HELPER_H_INCLUDED__

#include "IrrCompileConfig.h"
#include "path.h"

namespace irr
{

static io::path getExampleMediaPath()
{
#if defined (_IRR_IPHONE_PLATFORM_) || defined (_IRR_ANDROID_PLATFORM_) || defined (_IRR_OSX_PLATFORM_)
	return io::path("media/");
#else
	return io::path("../../media/");
#endif
}

} // end namespace irr

#endif

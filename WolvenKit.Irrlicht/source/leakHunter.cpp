// Copyright (C) 2013 Michael Zeilfelder
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "leakHunter.h"

#ifdef _IRR_COMPILE_WITH_LEAK_HUNTER_

namespace irr
{
	 irr::core::array<const IReferenceCounted*> LeakHunter::ReferenceCountedObjects;
} // end namespace irr

#endif // _IRR_COMPILE_WITH_LEAK_HUNTER_


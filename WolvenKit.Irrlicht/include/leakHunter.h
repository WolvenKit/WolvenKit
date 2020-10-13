// Copyright (C) 2013 Michael Zeilfelder
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __LEAK_HUNTER_INCLUDEED__

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_LEAK_HUNTER_

#include "irrArray.h"

namespace irr
{
	class IReferenceCounted;

	//! A class helping to find unreleased objects of type IReferenceCounted.
	/** To use this you have recompile Irrlicht with _IRR_COMPILE_WITH_LEAK_HUNTER_.
		Note that this will slow down your application and should only be used for debugging.
		The way to use is that you can check after you closed and dropped your last Irrlicht device
		if there are still any IReferenceCounted left over which have not been deleted.
	*/
	class LeakHunter
	{
		public:
			friend class IReferenceCounted;

			//! Clear all IReferenceCounted objects inside LeakHunter
			/** This does not affect the IReferenceCounted themselves only the
				counting of them. Usually you don't ever need to clear, but
				sometimes it helps when for example you want to ignore
				certain leaks.
			*/
			static void clearReferenceCountedObjects()
			{
				ReferenceCountedObjects.clear();
			}

			//! Access all objects which are currently reference counted.
			static inline irr::core::array<const IReferenceCounted*> getReferenceCountedObjects()
			{
				return ReferenceCountedObjects;
			}

		protected:
			static inline void addObject(const IReferenceCounted* object)
			{
				ReferenceCountedObjects.push_back(object);
			}

			static inline void removeObject(const IReferenceCounted* object)
			{
				irr::s32 idx = ReferenceCountedObjects.linear_search(object );
				if ( idx >= 0 )
				{
					irr::core::swap( ReferenceCountedObjects[idx], ReferenceCountedObjects.getLast() );
					ReferenceCountedObjects.erase( ReferenceCountedObjects.size()-1 );
				}
			}

		private:
			// NOTE: We don't do additional grab()/drop()'s here as we want to supervise reference counted objects and not affect them otherwise.
			IRRLICHT_API static irr::core::array<const IReferenceCounted*> ReferenceCountedObjects;
	};
} // end namespace irr

#endif // _IRR_COMPILE_WITH_LEAK_HUNTER_

#endif

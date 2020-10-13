// Copyright (C) 2002-2012 Nikolaus Gebhardt / Thomas Alten
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_Z_BUFFER_H_INCLUDED__
#define __C_Z_BUFFER_H_INCLUDED__

#include "IDepthBuffer.h"

namespace irr
{
namespace video
{

	class CDepthBuffer : public IDepthBuffer
	{
	public:

		//! constructor
		CDepthBuffer(const core::dimension2d<u32>& size);

		//! destructor
		virtual ~CDepthBuffer();

		//! clears the zbuffer
		virtual void clear() _IRR_OVERRIDE_;

		//! sets the new size of the zbuffer
		virtual void setSize(const core::dimension2d<u32>& size) _IRR_OVERRIDE_;

		//! returns the size of the zbuffer
		virtual const core::dimension2d<u32>& getSize() const _IRR_OVERRIDE_;

		//! locks the zbuffer
		virtual void* lock() _IRR_OVERRIDE_ { return (void*) Buffer; }

		//! unlocks the zbuffer
		virtual void unlock() _IRR_OVERRIDE_ {}

		//! returns pitch of depthbuffer (in bytes)
		virtual u32 getPitch() const _IRR_OVERRIDE_ { return Pitch; }


	private:

		u8* Buffer;
		core::dimension2d<u32> Size;
		u32 TotalSize;
		u32 Pitch;
	};


	class CStencilBuffer : public IStencilBuffer
	{
	public:

		//! constructor
		CStencilBuffer(const core::dimension2d<u32>& size);

		//! destructor
		virtual ~CStencilBuffer();

		//! clears the zbuffer
		virtual void clear() _IRR_OVERRIDE_;

		//! sets the new size of the zbuffer
		virtual void setSize(const core::dimension2d<u32>& size) _IRR_OVERRIDE_;

		//! returns the size of the zbuffer
		virtual const core::dimension2d<u32>& getSize() const _IRR_OVERRIDE_;

		//! locks the zbuffer
		virtual void* lock() _IRR_OVERRIDE_ { return (void*) Buffer; }

		//! unlocks the zbuffer
		virtual void unlock() _IRR_OVERRIDE_ {}

		//! returns pitch of depthbuffer (in bytes)
		virtual u32 getPitch() const _IRR_OVERRIDE_ { return Pitch; }


	private:

		u8* Buffer;
		core::dimension2d<u32> Size;
		u32 TotalSize;
		u32 Pitch;
	};

} // end namespace video
} // end namespace irr

#endif


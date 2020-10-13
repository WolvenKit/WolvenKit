// Copyright (C) 2013 Christian Stehno
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in Irrlicht.h

#ifndef __C_WGL_MANAGER_H_INCLUDED__
#define __C_WGL_MANAGER_H_INCLUDED__

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_WGL_MANAGER_

#include "SIrrCreationParameters.h"
#include "SExposedVideoData.h"
#include "IContextManager.h"
#include "SColor.h"

#define WIN32_LEAN_AND_MEAN
#include <windows.h>

namespace irr
{
namespace video
{
    // WGL manager.
    class CWGLManager : public IContextManager
    {
    public:
        //! Constructor.
        CWGLManager();

		//! Destructor
		~CWGLManager();

        // Initialize
        virtual bool initialize(const SIrrlichtCreationParameters& params, const SExposedVideoData& data) _IRR_OVERRIDE_;

        // Terminate
        virtual void terminate() _IRR_OVERRIDE_;

        // Create surface.
        virtual bool generateSurface() _IRR_OVERRIDE_;

        // Destroy surface.
        virtual void destroySurface() _IRR_OVERRIDE_;

        // Create context.
        virtual bool generateContext() _IRR_OVERRIDE_;

        // Destroy EGL context.
        virtual void destroyContext() _IRR_OVERRIDE_;

		//! Get current context
		virtual const SExposedVideoData& getContext() const _IRR_OVERRIDE_;

		//! Change render context, disable old and activate new defined by videoData
		virtual bool activateContext(const SExposedVideoData& videoData, bool restorePrimaryOnZero) _IRR_OVERRIDE_;

        // Swap buffers.
        virtual bool swapBuffers() _IRR_OVERRIDE_;

    private:
        SIrrlichtCreationParameters Params;
		SExposedVideoData PrimaryContext;
        SExposedVideoData CurrentContext;
		s32 PixelFormat;
		PIXELFORMATDESCRIPTOR pfd;
		ECOLOR_FORMAT ColorFormat;
	};
}
}

#endif

#endif

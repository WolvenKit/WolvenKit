#ifndef __DEBUG_H_INCLUDED__
#define __DEBUG_H_INCLUDED__

#include "IrrCompileConfig.h"

#ifdef _IRR_WINDOWS_
    #if defined(_DEBUG) && !defined(__GNUWIN32__) && !defined(_WIN32_WCE)
        #define _CRTDBG_MAP_ALLOC
        #include <crtdbg.h>
        #define DBG_NEW new ( _NORMAL_BLOCK , __FILE__ , __LINE__ )
        // Replace _NORMAL_BLOCK with _CLIENT_BLOCK if you want the
        // allocations to be of _CLIENT_BLOCK type
    #else
        #define DBG_NEW new
    #endif
#endif // _DEBUG

#endif
#include "IrrAssimpUtils.h"


irr::core::stringc to_char_string(irr::io::path path)
{
    #ifdef _IRR_WCHAR_FILESYSTEM
        irr::core::stringc rPath = path;
        return rPath;
    #else
        return path;
    #endif
}

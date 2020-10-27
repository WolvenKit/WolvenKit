#ifndef __DXT_INFO_H_INCLUDED__
#define __DXT_INFO_H_INCLUDED__

#include "irrTypes.h"

namespace irr
{
namespace video
{
// byte-align structures
#include "irrpack.h"
    struct ddsColorBlock
    {
        u16		colors[2];
        u8		row[4];
    } PACK_STRUCT;

    struct ddsAlphaBlock3BitLinear
    {
        u8		alpha0;
        u8		alpha1;
        u8		stuff[6];
    } PACK_STRUCT;


    struct ddsColor
    {
        u8		r, g, b, a;
    } PACK_STRUCT;
    // Default alignment
#include "irrunpack.h"

    void DecompressDXT1Image(u8* rgba, int width, int height, void const* blocks);
    void DecompressDXT5Image(u8* rgba, int width, int height, void const* blocks);

} // end namespace video
} // end namespace irr

#endif


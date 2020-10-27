#include "dxtinfo.h"

namespace irr
{
namespace video
{
    static int Unpack565(u8 const* packed, u8* colour) noexcept
    {
        // build the packed value
        const int value = (int)packed[0] | ((int)packed[1] << 8);

        // get the components in the stored range
        const u8 red = (u8)((value >> 11) & 0x1f);
        const u8 green = (u8)((value >> 5) & 0x3f);
        const u8 blue = (u8)(value & 0x1f);

        // scale up to 8 bits
        colour[0] = (red << 3) | (red >> 2);
        colour[1] = (green << 2) | (green >> 4);
        colour[2] = (blue << 3) | (blue >> 2);
        colour[3] = 255;

        // return the value
        return value;
    }

    void DecompressDXT1Colour(u8* rgba, void const* block)
    {
        // get the block bytes
        u8 const* bytes = reinterpret_cast<u8 const*>(block);

        // unpack the endpoints
        u8 codes[16];
        const int a = Unpack565(bytes, codes);
        const int b = Unpack565(bytes + 2, codes + 4);

        // generate the midpoints
        for (int i = 0; i < 3; ++i)
        {
            const int c = codes[i];
            const int d = codes[4 + i];

            if (a <= b)
            {
                codes[8 + i] = (u8)((c + d) / 2);
                codes[12 + i] = 0;
            }
            else
            {
                codes[8 + i] = (u8)((2 * c + d) / 3);
                codes[12 + i] = (u8)((c + 2 * d) / 3);
            }
        }

        // fill in alpha for the intermediate values
        codes[8 + 3] = 255;
        codes[12 + 3] = (a <= b) ? 0 : 255;

        // unpack the indices
        u8 indices[16];
        for (int i = 0; i < 4; ++i)
        {
            u8* ind = indices + 4 * i;
            const u8 packed = bytes[4 + i];

            ind[0] = packed & 0x3;
            ind[1] = (packed >> 2) & 0x3;
            ind[2] = (packed >> 4) & 0x3;
            ind[3] = (packed >> 6) & 0x3;
        }

        // store out the colours
        for (int i = 0; i < 16; ++i)
        {
            const u8 offset = 4 * indices[i];
            for (int j = 0; j < 4; ++j)
                rgba[4 * i + j] = codes[offset + j];
        }
    }

    void DecompressDXT5Colour(u8* rgba, void const* block)
    {
        // get the block bytes
        u8 const* bytes = reinterpret_cast<u8 const*>(block);

        // unpack the endpoints
        u8 codes[16];
        const int a = Unpack565(bytes, codes);
        const int b = Unpack565(bytes + 2, codes + 4);

        // generate the midpoints
        for (int i = 0; i < 3; ++i)
        {
            const int c = codes[i];
            const int d = codes[4 + i];

            codes[8 + i] = (u8)((2 * c + d) / 3);
            codes[12 + i] = (u8)((c + 2 * d) / 3);
        }

        // fill in alpha for the intermediate values
        codes[8 + 3] = 255;
        codes[12 + 3] = 255;

        // unpack the indices
        u8 indices[16];
        for (int i = 0; i < 4; ++i)
        {
            u8* ind = indices + 4 * i;
            const u8 packed = bytes[4 + i];

            ind[0] = packed & 0x3;
            ind[1] = (packed >> 2) & 0x3;
            ind[2] = (packed >> 4) & 0x3;
            ind[3] = (packed >> 6) & 0x3;
        }

        // store out the colours
        for (int i = 0; i < 16; ++i)
        {
            const u8 offset = 4 * indices[i];
            for (int j = 0; j < 4; ++j)
                rgba[4 * i + j] = codes[offset + j];
        }
    }

    void DecompressAlphaDxt5(u8* rgba, void const* block) noexcept
    {
        // get the two alpha values
        u8 const* bytes = reinterpret_cast<u8 const*>(block);
        const int alpha0 = bytes[0];
        const int alpha1 = bytes[1];

        // compare the values to build the codebook
        u8 codes[8];
        codes[0] = (u8)alpha0;
        codes[1] = (u8)alpha1;
        if (alpha0 <= alpha1)
        {
            // use 5-alpha codebook
            for (int i = 1; i < 5; ++i)
                codes[1 + i] = (u8)(((5 - i)*alpha0 + i * alpha1) / 5);
            codes[6] = 0;
            codes[7] = 255;
        }
        else
        {
            // use 7-alpha codebook
            for (int i = 1; i < 7; ++i)
                codes[1 + i] = (u8)(((7 - i)*alpha0 + i * alpha1) / 7);
        }

        // decode the indices
        u8 indices[16];
        u8 const* src = bytes + 2;
        u8* dest = indices;
        for (int i = 0; i < 2; ++i)
        {
            // grab 3 bytes
            int value = 0;
            for (int j = 0; j < 3; ++j)
            {
                const int byte = *src++;
                value |= (byte << 8 * j);
            }

            // unpack 8 3-bit values from it
            for (int j = 0; j < 8; ++j)
            {
                int index = (value >> 3 * j) & 0x7;
                *dest++ = (u8)index;
            }
        }

        // write out the indexed codebook values
        for (int i = 0; i < 16; ++i)
            rgba[4 * i + 3] = codes[indices[i]];
    }

    void CopyRGBA(u8 const* source, u8* dest)
    {
        // convert from bgra to rgba
        dest[0] = source[2];
        dest[1] = source[1];
        dest[2] = source[0];
        dest[3] = source[3];
        //for (int i = 0; i < 4; ++i)
        //    *dest++ = *source++;
    }

    void DecompressDXT1(u8* rgba, void const* block)
    {
        // get the block locations
        void const* colourBlock = block;
        void const* alphaBlock = block;

        // decompress colour
        DecompressDXT1Colour(rgba, colourBlock);
    }

    void DecompressDXT5(u8* rgba, void const* block)
    {
        // get the block locations
        void const* colourBlock = reinterpret_cast<u8 const*>(block) + 8;
        void const* alphaBlock = block;

        // decompress colour
        DecompressDXT5Colour(rgba, colourBlock);

        // decompress alpha separately if necessary
        DecompressAlphaDxt5(rgba, alphaBlock);
    }

    void DecompressDXT1Image(u8* rgba, int width, int height, void const* blocks)
    {
        int pitch = width * 4;
        constexpr int bytesPerBlock = 8;

        for (int y = 0; y < height; y += 4)
        {
            // initialise the block input
            u8 const* sourceBlock = reinterpret_cast<u8 const*>(blocks);
            sourceBlock += ((y / 4) * ((width + 3) / 4)) * bytesPerBlock;

            for (int x = 0; x < width; x += 4)
            {
                // decompress the block
                u8 targetRgba[4 * 16];
                DecompressDXT1(targetRgba, sourceBlock);

                // write the decompressed pixels to the correct image locations
                u8 const* sourcePixel = targetRgba;
                for (int py = 0; py < 4; ++py)
                {
                    for (int px = 0; px < 4; ++px)
                    {
                        // get the target location
                        int sx = x + px;
                        int sy = y + py;

                        // write if we're in the image
                        if (sx < width && sy < height)
                        {
                            // copy the rgba value
                            u8* targetPixel = rgba + pitch * sy + 4 * sx;
                            CopyRGBA(sourcePixel, targetPixel);
                        }

                        // advance to the next pixel
                        sourcePixel += 4;
                    }
                }

                // advance
                sourceBlock += bytesPerBlock;
            }
        }

    }

    void DecompressDXT5Image(u8* rgba, int width, int height, void const* blocks)
    {
        int pitch = width * 4;
        constexpr int bytesPerBlock = 16;

        for (int y = 0; y < height; y += 4)
        {
            // initialise the block input
            u8 const* sourceBlock = reinterpret_cast<u8 const*>(blocks);
            sourceBlock += ((y / 4) * ((width + 3) / 4)) * bytesPerBlock;

            for (int x = 0; x < width; x += 4)
            {
                // decompress the block
                u8 targetRgba[4 * 16];
                DecompressDXT5(targetRgba, sourceBlock);

                // write the decompressed pixels to the correct image locations
                u8 const* sourcePixel = targetRgba;
                for (int py = 0; py < 4; ++py)
                {
                    for (int px = 0; px < 4; ++px)
                    {
                        // get the target location
                        int sx = x + px;
                        int sy = y + py;

                        // write if we're in the image
                        if (sx < width && sy < height)
                        {
                            // copy the rgba value
                            u8* targetPixel = rgba + pitch * sy + 4 * sx;
                            CopyRGBA(sourcePixel, targetPixel);
                        }

                        // advance to the next pixel
                        sourcePixel += 4;
                    }
                }

                // advance
                sourceBlock += bytesPerBlock;
            }
        }

    }

} // end namespace video
} // end namespace irr

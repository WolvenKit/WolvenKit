// Copyright (C) 2002-2020 by Jean-Louis Boudrand
// adapted to irrlicht by vonleebpl(at)gmail.com

#include "IrrCompileConfig.h"

//#define _IRR_COMPILE_WITH_W3ENT_LOADER_
#ifdef _IRR_COMPILE_WITH_W3ENT_LOADER_

#include <cstdarg>
#include "Utils_Loaders_Irr.h"


namespace irr
{
namespace scene
{
    
    core::vector3df readVector3df(io::IReadFile* file)
    {
        float x, y, z, w;
        file->seek(1, true);

        file->seek(8, true);    // 2 index of the Strings table (Name + type -> X, Float) + prop size
        x = readF32(file);
        file->seek(8, true);
        y = readF32(file);
        file->seek(8, true);
        z = readF32(file);
        file->seek(8, true);
        w = readF32(file);

        return core::vector3df(x, y, z);
    }
    
    bool readBool(io::IReadFile* file)
    {
        u8 valChar = readU8(file);
        return (valChar > 0);
    }

    core::stringc readString(io::IReadFile* file, int nbChars)
    {
        char * returnedString = new char[nbChars + 1];
        file->read(returnedString, nbChars);
        returnedString[nbChars] = '\0';
        return returnedString;
    }

    core::stringc readStringUntilNull(io::IReadFile* file)
    {
        core::stringc returnedString;
        char c;
        while (1)
        {
            file->read(&c, 1);
            if (c == 0x00)
                break;
            returnedString.append(c);
        }

        return returnedString;
    }

    core::stringc readStringFixedSize(io::IReadFile* file, int nbChars)
    {
        long back = file->getPos();
        core::stringc returnedString = readString(file, nbChars);
        file->seek(back + nbChars);

        return returnedString;
    }

    core::stringc formatString(core::stringc baseString, ...)
    {
        core::stringc newString = "";
        va_list va;
        va_start(va, baseString);

        char lastChar = 'a';
        for (u32 i = 0; i < baseString.size(); ++i)
        {
            char currentChar = baseString[i];
            if (lastChar == '%')
            {
                switch (currentChar)
                {
                case 'd':
                {
                    int intValue = va_arg(va, int);
                    newString += toStr(intValue);
                    break;
                }
                case 'f':
                {
                    float floatValue = static_cast<float>(va_arg(va, double));
                    newString += toStr(floatValue);
                    break;
                }
                case 's':
                {
                    char* strValue = va_arg(va, char*);
                    newString += toStr(strValue);
                    break;
                }
                default:
                    break;
                }
            }

            if (currentChar != '%' && lastChar != '%')
                newString.append(currentChar);

            lastChar = currentChar;
        }

        va_end(va);
        return newString;
    }
} //namespace scene
} //namespace irr
#endif
// Copyright (C) 2002-2020 by Jean-Louis Boudrand
// adapted to irrlicht by vonleebpl(at)gmail.com



#ifndef __UTILS_LOADERS_IRR_H
#define __UTILS_LOADERS_IRR_H

#include "IReadFile.h"
#include "irrArray.h"
#include "vector3d.h"
#include <sstream>


namespace irr
{
namespace scene
{

    template <class T>
    T readData(io::IReadFile* f)
    {
        T buf;
        f->read(&buf, sizeof(T));
        return buf;
    }

    #define readU32 readData<u32>
    #define readS32 readData<s32>
    #define readU16 readData<u16>
    #define readS16 readData<s16>
    #define readU8 readData<u8>
    #define readS8 readData<s8>
    #define readF32 readData<f32>
    bool readBool(io::IReadFile* file);
    core::vector3df readVector3df(io::IReadFile* file);

    template <class T>
    core::array<T> readDataArray(io::IReadFile* f, s32 nbElem)
    {
        core::array<T> values(nbElem);
        values.set_used(nbElem);
        f->read(values.pointer(), nbElem * sizeof(T));
        return values;
    }

    template <typename T>
    core::stringc toStr(const T& t) {
        std::ostringstream os;
        os << t;
        return core::stringc(os.str().c_str());
    }

        

    core::stringc readString(io::IReadFile* file, int nbChars);
    core::stringc readStringUntilNull(io::IReadFile* file);
    core::stringc readStringFixedSize(io::IReadFile* file, int nbChars);
    core::stringc formatString(core::stringc baseString, ...);

} //namespace scene
} //namespace irr

#endif // UTILS_LOADERS_H

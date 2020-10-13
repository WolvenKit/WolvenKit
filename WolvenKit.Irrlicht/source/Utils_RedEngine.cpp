// Copyright (C) 2002-2020 by Jean-Louis Boudrand
// adapted to irrlicht by vonleebpl(at)gmail.com

#include "IrrCompileConfig.h"

//#define _IRR_COMPILE_WITH_W3ENT_LOADER_
#ifdef _IRR_COMPILE_WITH_W3ENT_LOADER_

#include "Utils_RedEngine.h"
#include "Utils_Loaders_Irr.h"

#include <iostream>

#include "os.h"


// useless ?
/*
WitcherFileDesc getFullTWFileDescription(io::IReadFile* file, io::path filename)
{
    WitcherFileDesc description;
    description._contentType = getTWFileContentType(filename);
    description._version = hasTWFileFormatVersion(file);
    description._hasWitcherMagicCode = hasWitcherMagicCode(file);

    description._fileType = getTWFileType(file);
    return description;
}
*/
namespace irr
{
    namespace scene
    {

        RedEngineContentType getRedEngineFileContentType(io::path filename)
        {
            if (core::hasFileExtension(filename, "w2ent"))
                return RECT_WITCHER_ENTITY;
            else if (core::hasFileExtension(filename, "w2mesh"))
                return RECT_WITCHER_MESH;
            else if (core::hasFileExtension(filename, "w2rig"))
                return RECT_WITCHER_RIG;
            else if (core::hasFileExtension(filename, "w2anims"))
                return RECT_WITCHER_ANIMATIONS;
            else if (core::hasFileExtension(filename, "w2mi"))
                return RECT_WITCHER_MATERIAL;
            else
                return RECT_WITCHER_OTHER;
        }

        RedEngineVersion getTWFileFormatVersion(io::IReadFile* file)
        {
            if (!file)
                return REV_UNKNOWN;

            const long pos = file->getPos();

            file->seek(4);
            s32 version = readS32(file);
            file->seek(pos);

            if (version == 115)
                return REV_WITCHER_2;
            else if (version >= 162)
                return REV_WITCHER_3;
            else
                return REV_UNKNOWN;
        }

        bool hasRedEngineMagicCode(io::IReadFile* file)
        {
            if (!file)
                return false;

            const long pos = file->getPos();
            core::stringc magic = readString(file, 4);
            file->seek(pos);

            return (magic == "CR2W");
        }

        RedEngineVersion getRedEngineFileType(io::IReadFile* file)
        {
            if (!hasRedEngineMagicCode(file))
                return REV_UNKNOWN;

            return getTWFileFormatVersion(file);
        }

        bool loadTW2FileHeader(io::IReadFile* file, RedEngineFileHeader& header, bool loadFilenamesWithTypes)
        {
            if (!file)
                return false;

            const long initialPos = file->getPos();
            file->seek(4);
            core::array<s32> headerData = readDataArray<s32>(file, 10);
            header.Version = headerData[0];

            // strings
            file->seek(headerData[2]);
            for (int i = 0; i < headerData[3]; ++i)
            {
                core::stringc string = readString(file, readU8(file) - 128);
                header.Strings.push_back(string);
                os::Printer::log((formatString("TW file header string: %s", string.c_str())).c_str(), ELL_DEBUG);
                //Log::Instance()->addLineAndFlush(string);

            }

            // files
            file->seek(headerData[6]);
            for (int i = 0; i < headerData[7]; i++)
            {
                u8 format_name, size;
                file->read(&size, 1);
                file->read(&format_name, 1);

                file->seek(-1, true);

                if (format_name == 1)
                    file->seek(1, true);

                core::stringc filename = readString(file, size);

                // Type of the file (CMesh, CMaterialInstance...)
                u32 fileTypeIndex = readU32(file) - 1;
                core::stringc fileType = header.Strings[fileTypeIndex];

                if (loadFilenamesWithTypes)
                    filename = fileType + " : " + filename;

                //Log::Instance()->addLineAndFlush(filename);
                os::Printer::log((formatString("TW file name: %s", filename.c_str())).c_str(), ELL_DEBUG);
                //cout << file << endl;
                header.Files.push_back(filename);
            }


            file->seek(initialPos);

            return true;
        }

        bool loadTW3FileHeader(io::IReadFile* file, RedEngineFileHeader& header)
        {
            if (!file)
                return false;

            const long initialPos = file->getPos();

            file->seek(12);

            core::array<s32> headerData = readDataArray<s32>(file, 38);
            // debug
            /*
            for (int i = 0; i < 38; ++i)
            {
                std::cout << "Header data [" << i << "]: " << headerData[i] << std::endl;
            }
            */

            s32 stringChunkStart = headerData[7];
            s32 stringChunkSize = headerData[8];
            s32 calculatedStringChunkSize = stringChunkStart + stringChunkSize;

            s32 stringChunkEnd = headerData[10]; // or the adress of a new chunk ?
            s32 nbStrings = headerData[11];

            // in many case seem similar to file count, but no
            //s32 nbFiles = headerData[14];

            int nbStringsRead = 0;
            file->seek(stringChunkStart);
            while (file->getPos() < calculatedStringChunkSize)
            {
                core::stringc str = readStringUntilNull(file);
                if (nbStringsRead < nbStrings)
                {
                    header.Strings.push_back(str);
                    os::Printer::log((formatString("--> %s", str.c_str())).c_str(), ELL_DEBUG);
                    nbStringsRead++;
                }
                else
                {
                    header.Files.push_back(str);
                    os::Printer::log((formatString("--> FILE: %s", str.c_str())).c_str(), ELL_DEBUG);
                }
            }

            file->seek(initialPos);

            return true;
        }

        bool loadTWFileHeader(io::IReadFile* file, RedEngineFileHeader& header, bool loadFilenamesWithTypes)
        {
            header.Strings.clear();
            header.Files.clear();

            if (!hasRedEngineMagicCode(file))
                return false;

            RedEngineVersion version = getRedEngineFileType(file);

            switch (version)
            {
            case REV_WITCHER_2:
                return loadTW2FileHeader(file, header, loadFilenamesWithTypes);
            case REV_WITCHER_3:
                return loadTW3FileHeader(file, header);
            default:
                return false;
            }
        }
    }
}
#endif
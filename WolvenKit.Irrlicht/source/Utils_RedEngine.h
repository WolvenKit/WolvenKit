// Copyright (C) 2002-2020 by Jean-Louis Boudrand
// adapted to irrlicht by vonleebpl(at)gmail.com

#ifndef UTILS_TW_H
#define UTILS_TW_H

#include "IFileSystem.h"
#include "irrArray.h"

namespace irr
{
    namespace scene
    {

        enum RedEngineVersion
        {
            REV_WITCHER_2,
            REV_WITCHER_3,
            REV_UNKNOWN
        };

        enum RedEngineContentType
        {
            RECT_WITCHER_ENTITY,
            RECT_WITCHER_MESH,
            RECT_WITCHER_RIG,
            RECT_WITCHER_ANIMATIONS,
            RECT_WITCHER_MATERIAL,
            RECT_WITCHER_OTHER
        };

        // unused yet. remove ?
        /*
        struct WitcherFileDesc
        {
            WitcherFileType _version;
            WitcherContentType _contentType;
            bool _hasWitcherMagicCode;

            // test _hasWitcherMagicCode + _version
            WitcherFileType _fileType;
        };
        */

        // unused yet. remove ?
        //WitcherFileDesc getFullTWFileDescription(io::IReadFile* file, io::path filename);

        struct RedEngineFileHeader
        {
            s32 Version;
            core::array<core::stringc> Strings;
            core::array<core::stringc> Files;
        };

        RedEngineContentType getRedEngineFileContentType(io::path filename);
        RedEngineVersion getTWFileFormatVersion(io::IReadFile* file);
        bool hasRedEngineMagicCode(io::IReadFile* file);
        RedEngineVersion getRedEngineFileType(io::IReadFile* file);

        bool loadTWFileHeader(io::IReadFile* file, RedEngineFileHeader& header, bool loadFilenamesWithTypes = false);
        bool loadTW2FileHeader(io::IReadFile* file, RedEngineFileHeader& header, bool loadFilenamesWithTypes = false);
        bool loadTW3FileHeader(io::IReadFile* file, RedEngineFileHeader& header);
    }
}
#endif // UTILS_TW_H

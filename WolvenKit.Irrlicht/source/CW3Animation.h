// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h
// adapted to irrlicht by vonleebpl(at)gmail.com

#ifndef __C_W3ANIMATION_H_INCLUDED__
#define __C_W3ANIMATION_H_INCLUDED__


#include "IReferenceCounted.h"
#include "vector3d.h"
#include "quaternion.h"
#include "irrArray.h"

namespace irr
{
namespace scene
{
    enum EAnimTrackType
    {
        EATT_POSITION,
        EATT_ORIENTATION,
        EATT_SCALE
    };

    enum SAnimationBufferOrientationCompressionMethod
    {
        ABOCM_PackIn64bitsW,
        ABOCM_PackIn48bitsW,
        ABOCM_PackIn40bitsW,
        ABOCM_AsFloat_XYZW,
        ABOCM_AsFloat_XYZSignedW,
        ABOCM_AsFloat_XYZSignedWInLastBit,
        ABOCM_PackIn48bits,
        ABOCM_PackIn40bits,
        ABOCM_PackIn32bits
    };

    struct SAnimationBufferBitwiseCompressedData
    {
        SAnimationBufferBitwiseCompressedData() : type(EATT_POSITION), dt(0.f), compression(0), numFrames(0), dataAddr(0), dataAddrFallback(0) {}

        EAnimTrackType type;
        f32 dt;
        s8 compression;
        u16 numFrames;
        u32 dataAddr;
        u32 dataAddrFallback;
    };

	struct SW3Animation
	{

        SW3Animation(core::stringc _name, int idx, float fps, float dur) : name(_name), chunkIdx(idx), framesPerSecond(fps), duration(dur) {};
        //! name of animation

        float animationSpeed = 0;
        core::array<core::array<u32>> positionsKeyframes;
        core::array<core::array<u32>> orientationsKeyframes;
        core::array<core::array<u32>> scalesKeyframes;
        core::array<core::array<core::vector3df>> positions;
        core::array<core::array<core::quaternion>> orientations;
        core::array<core::array<core::vector3df>> scales;

        //! index of anim buffer bitwise compressed
        int chunkIdx;

        core::stringc name;
        float framesPerSecond;
        float duration;
	};
} // namespace scene
} // namespace irr
#endif
// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_PARTICLE_SPHERE_EMITTER_H_INCLUDED__
#define __C_PARTICLE_SPHERE_EMITTER_H_INCLUDED__

#include "IrrCompileConfig.h"
#ifdef _IRR_COMPILE_WITH_PARTICLES_

#include "IParticleSphereEmitter.h"
#include "irrArray.h"
#include "aabbox3d.h"

namespace irr
{
namespace scene
{

//! A default box emitter
class CParticleSphereEmitter : public IParticleSphereEmitter
{
public:

	//! constructor
	CParticleSphereEmitter(
		const core::vector3df& center, f32 radius,
		const core::vector3df& direction = core::vector3df(0.0f,0.03f,0.0f),
		u32 minParticlesPerSecond = 20,
		u32 maxParticlesPerSecond = 40,
		const video::SColor& minStartColor = video::SColor(255,0,0,0),
		const video::SColor& maxStartColor = video::SColor(255,255,255,255),
		u32 lifeTimeMin=2000,
		u32 lifeTimeMax=4000,
		s32 maxAngleDegrees=0,
		const core::dimension2df& minStartSize = core::dimension2df(5.0f,5.0f),
		const core::dimension2df& maxStartSize = core::dimension2df(5.0f,5.0f) );

	//! Prepares an array with new particles to emitt into the system
	//! and returns how much new particles there are.
	virtual s32 emitt(u32 now, u32 timeSinceLastCall, SParticle*& outArray) _IRR_OVERRIDE_;

	//! Set direction the emitter emits particles
	virtual void setDirection( const core::vector3df& newDirection ) _IRR_OVERRIDE_ { Direction = newDirection; }

	//! Set minimum number of particles per second.
	virtual void setMinParticlesPerSecond( u32 minPPS ) _IRR_OVERRIDE_ { MinParticlesPerSecond = minPPS; }

	//! Set maximum number of particles per second.
	virtual void setMaxParticlesPerSecond( u32 maxPPS ) _IRR_OVERRIDE_ { MaxParticlesPerSecond = maxPPS; }

	//! Set minimum start color
	virtual void setMinStartColor( const video::SColor& color ) _IRR_OVERRIDE_ { MinStartColor = color; }

	//! Set maximum start color
	virtual void setMaxStartColor( const video::SColor& color ) _IRR_OVERRIDE_ { MaxStartColor = color; }

	//! Set the maximum starting size for particles
	virtual void setMaxStartSize( const core::dimension2df& size ) _IRR_OVERRIDE_ { MaxStartSize = size; }

	//! Set the minimum starting size for particles
	virtual void setMinStartSize( const core::dimension2df& size ) _IRR_OVERRIDE_ { MinStartSize = size; }

	//! Set the minimum particle life-time in milliseconds
	virtual void setMinLifeTime( u32 lifeTimeMin ) _IRR_OVERRIDE_ { MinLifeTime = lifeTimeMin; }

	//! Set the maximum particle life-time in milliseconds
	virtual void setMaxLifeTime( u32 lifeTimeMax ) _IRR_OVERRIDE_ { MaxLifeTime = lifeTimeMax; }

	//!	Set maximal random derivation from the direction
	virtual void setMaxAngleDegrees( s32 maxAngleDegrees ) _IRR_OVERRIDE_ { MaxAngleDegrees = maxAngleDegrees; }

	//! Set the center of the sphere for particle emissions
	virtual void setCenter( const core::vector3df& center ) _IRR_OVERRIDE_ { Center = center; }

	//! Set the radius of the sphere for particle emissions
	virtual void setRadius( f32 radius ) _IRR_OVERRIDE_ { Radius = radius; }

	//! Gets direction the emitter emits particles
	virtual const core::vector3df& getDirection() const _IRR_OVERRIDE_ { return Direction; }

	//! Get minimum number of particles per second.
	virtual u32 getMinParticlesPerSecond() const _IRR_OVERRIDE_ { return MinParticlesPerSecond; }

	//! Get maximum number of particles per second.
	virtual u32 getMaxParticlesPerSecond() const _IRR_OVERRIDE_ { return MaxParticlesPerSecond; }

	//! Get minimum start color
	virtual const video::SColor& getMinStartColor() const _IRR_OVERRIDE_ { return MinStartColor; }

	//! Get maximum start color
	virtual const video::SColor& getMaxStartColor() const _IRR_OVERRIDE_ { return MaxStartColor; }

	//! Gets the maximum starting size for particles
	virtual const core::dimension2df& getMaxStartSize() const _IRR_OVERRIDE_ { return MaxStartSize; }

	//! Gets the minimum starting size for particles
	virtual const core::dimension2df& getMinStartSize() const _IRR_OVERRIDE_ { return MinStartSize; }

	//! Get the minimum particle life-time in milliseconds
	virtual u32 getMinLifeTime() const _IRR_OVERRIDE_ { return MinLifeTime; }

	//! Get the maximum particle life-time in milliseconds
	virtual u32 getMaxLifeTime() const _IRR_OVERRIDE_ { return MaxLifeTime; }

	//!	Get maximal random derivation from the direction
	virtual s32 getMaxAngleDegrees() const _IRR_OVERRIDE_ { return MaxAngleDegrees; }

	//! Get the center of the sphere for particle emissions
	virtual const core::vector3df& getCenter() const _IRR_OVERRIDE_ { return Center; }

	//! Get the radius of the sphere for particle emissions
	virtual f32 getRadius() const _IRR_OVERRIDE_ { return Radius; }

	//! Writes attributes of the object.
	virtual void serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options) const _IRR_OVERRIDE_;

	//! Reads attributes of the object.
	virtual void deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options) _IRR_OVERRIDE_;

private:

	core::array<SParticle> Particles;

	core::vector3df	Center;
	f32 Radius;
	core::vector3df Direction;

	core::dimension2df MinStartSize, MaxStartSize;
	u32 MinParticlesPerSecond, MaxParticlesPerSecond;
	video::SColor MinStartColor, MaxStartColor;
	u32 MinLifeTime, MaxLifeTime;

	u32 Time;
	s32 MaxAngleDegrees;
};

} // end namespace scene
} // end namespace irr

#endif // _IRR_COMPILE_WITH_PARTICLES_

#endif


// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_PARTICLE_ANIMATED_MESH_SCENE_NODE_EMITTER_H_INCLUDED__
#define __C_PARTICLE_ANIMATED_MESH_SCENE_NODE_EMITTER_H_INCLUDED__

#include "IParticleAnimatedMeshSceneNodeEmitter.h"
#include "irrArray.h"

namespace irr
{
namespace scene
{

//! An animated mesh emitter
class CParticleAnimatedMeshSceneNodeEmitter : public IParticleAnimatedMeshSceneNodeEmitter
{
public:

	//! constructor
	CParticleAnimatedMeshSceneNodeEmitter(
		IAnimatedMeshSceneNode* node,
		bool useNormalDirection = true,
		const core::vector3df& direction = core::vector3df(0.0f,0.0f,-1.0f),
		f32 normalDirectionModifier = 100.0f,
		s32 mbNumber = -1,
		bool everyMeshVertex = false,
		u32 minParticlesPerSecond = 20,
		u32 maxParticlesPerSecond = 40,
		const video::SColor& minStartColor = video::SColor(255,0,0,0),
		const video::SColor& maxStartColor = video::SColor(255,255,255,255),
		u32 lifeTimeMin = 2000,
		u32 lifeTimeMax = 4000,
		s32 maxAngleDegrees = 0,
		const core::dimension2df& minStartSize = core::dimension2df(5.0f,5.0f),
		const core::dimension2df& maxStartSize = core::dimension2df(5.0f,5.0f)
	);

	//! Prepares an array with new particles to emitt into the system
	//! and returns how much new particles there are.
	virtual s32 emitt(u32 now, u32 timeSinceLastCall, SParticle*& outArray) _IRR_OVERRIDE_;

	//! Set Mesh to emit particles from
	virtual void setAnimatedMeshSceneNode( IAnimatedMeshSceneNode* node ) _IRR_OVERRIDE_;

	//! Set whether to use vertex normal for direction, or direction specified
	virtual void setUseNormalDirection( bool useNormalDirection ) _IRR_OVERRIDE_ { UseNormalDirection = useNormalDirection; }

	//! Set direction the emitter emits particles
	virtual void setDirection( const core::vector3df& newDirection ) _IRR_OVERRIDE_ { Direction = newDirection; }

	//! Set the amount that the normal is divided by for getting a particles direction
	virtual void setNormalDirectionModifier( f32 normalDirectionModifier ) _IRR_OVERRIDE_ { NormalDirectionModifier = normalDirectionModifier; }

	//! Sets whether to emit min<->max particles for every vertex per second, or to pick
	//! min<->max vertices every second
	virtual void setEveryMeshVertex( bool everyMeshVertex ) _IRR_OVERRIDE_ { EveryMeshVertex = everyMeshVertex; }

	//! Set minimum number of particles the emitter emits per second
	virtual void setMinParticlesPerSecond( u32 minPPS ) _IRR_OVERRIDE_ { MinParticlesPerSecond = minPPS; }

	//! Set maximum number of particles the emitter emits per second
	virtual void setMaxParticlesPerSecond( u32 maxPPS ) _IRR_OVERRIDE_ { MaxParticlesPerSecond = maxPPS; }

	//! Set minimum starting color for particles
	virtual void setMinStartColor( const video::SColor& color ) _IRR_OVERRIDE_ { MinStartColor = color; }

	//! Set maximum starting color for particles
	virtual void setMaxStartColor( const video::SColor& color ) _IRR_OVERRIDE_ { MaxStartColor = color; }

	//! Set the maximum starting size for particles
	virtual void setMaxStartSize( const core::dimension2df& size ) _IRR_OVERRIDE_ { MaxStartSize = size; }

	//! Set the minimum starting size for particles
	virtual void setMinStartSize( const core::dimension2df& size ) _IRR_OVERRIDE_ { MinStartSize = size; }

	//! Set the minimum particle life-time in milliseconds
	virtual void setMinLifeTime( u32 lifeTimeMin ) _IRR_OVERRIDE_ { MinLifeTime = lifeTimeMin; }

	//! Set the maximum particle life-time in milliseconds
	virtual void setMaxLifeTime( u32 lifeTimeMax ) _IRR_OVERRIDE_ { MaxLifeTime = lifeTimeMax; }

	//!	Maximal random derivation from the direction
	virtual void setMaxAngleDegrees( s32 maxAngleDegrees ) _IRR_OVERRIDE_ { MaxAngleDegrees = maxAngleDegrees; }

	//! Get Mesh we're emitting particles from
	virtual const IAnimatedMeshSceneNode* getAnimatedMeshSceneNode() const _IRR_OVERRIDE_ { return Node; }

	//! Get whether to use vertex normal for direciton, or direction specified
	virtual bool isUsingNormalDirection() const _IRR_OVERRIDE_ { return UseNormalDirection; }

	//! Get direction the emitter emits particles
	virtual const core::vector3df& getDirection() const _IRR_OVERRIDE_ { return Direction; }

	//! Get the amount that the normal is divided by for getting a particles direction
	virtual f32 getNormalDirectionModifier() const _IRR_OVERRIDE_ { return NormalDirectionModifier; }

	//! Gets whether to emit min<->max particles for every vertex per second, or to pick
	//! min<->max vertices every second
	virtual bool getEveryMeshVertex() const _IRR_OVERRIDE_ { return EveryMeshVertex; }

	//! Get the minimum number of particles the emitter emits per second
	virtual u32 getMinParticlesPerSecond() const _IRR_OVERRIDE_ { return MinParticlesPerSecond; }

	//! Get the maximum number of particles the emitter emits per second
	virtual u32 getMaxParticlesPerSecond() const _IRR_OVERRIDE_ { return MaxParticlesPerSecond; }

	//! Get the minimum starting color for particles
	virtual const video::SColor& getMinStartColor() const _IRR_OVERRIDE_ { return MinStartColor; }

	//! Get the maximum starting color for particles
	virtual const video::SColor& getMaxStartColor() const _IRR_OVERRIDE_ { return MaxStartColor; }

	//! Get the maximum starting size for particles
	virtual const core::dimension2df& getMaxStartSize() const _IRR_OVERRIDE_ { return MaxStartSize; }

	//! Get the minimum starting size for particles
	virtual const core::dimension2df& getMinStartSize() const _IRR_OVERRIDE_ { return MinStartSize; }

	//! Get the minimum particle life-time in milliseconds
	virtual u32 getMinLifeTime() const _IRR_OVERRIDE_ { return MinLifeTime; }

	//! Get the maximum particle life-time in milliseconds
	virtual u32 getMaxLifeTime() const _IRR_OVERRIDE_ { return MaxLifeTime; }

	//!	Maximal random derivation from the direction
	virtual s32 getMaxAngleDegrees() const _IRR_OVERRIDE_ { return MaxAngleDegrees; }

private:

	IAnimatedMeshSceneNode* Node;
	IAnimatedMesh*		AnimatedMesh;
	const IMesh*		BaseMesh;
	s32			TotalVertices;
	u32			MBCount;
	s32			MBNumber;
	core::array<s32>	VertexPerMeshBufferList;

	core::array<SParticle> Particles;
	core::vector3df Direction;
	f32 NormalDirectionModifier;
	u32 MinParticlesPerSecond, MaxParticlesPerSecond;
	video::SColor MinStartColor, MaxStartColor;
	u32 MinLifeTime, MaxLifeTime;
	core::dimension2df MaxStartSize, MinStartSize;

	u32 Time;
	s32 MaxAngleDegrees;

	bool EveryMeshVertex;
	bool UseNormalDirection;
};

} // end namespace scene
} // end namespace irr


#endif // __C_PARTICLE_ANIMATED_MESH_SCENE_NODE_EMITTER_H_INCLUDED__


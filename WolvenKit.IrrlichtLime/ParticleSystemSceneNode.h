#pragma once

#include "stdafx.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

ref class AnimatedMeshSceneNode;
ref class Mesh;
ref class ParticleAffector;
ref class ParticleAnimatedMeshSceneNodeEmitter;
ref class ParticleAttractionAffector;
ref class ParticleBoxEmitter;
ref class ParticleCylinderEmitter;
ref class ParticleEmitter;
ref class ParticleFadeOutAffector;
ref class ParticleGravityAffector;
ref class ParticleMeshEmitter;
ref class ParticleRingEmitter;
ref class ParticleRotationAffector;
ref class ParticleSphereEmitter;

public ref class ParticleSystemSceneNode : SceneNode
{
public:

	void AddAffector(ParticleAffector^ affector);

	void ClearParticles();

	ParticleAnimatedMeshSceneNodeEmitter^ CreateAnimatedMeshSceneNodeEmitter(AnimatedMeshSceneNode^ particleNode, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees, Dimension2Df^ minStartSize, Dimension2Df^ maxStartSize);
	ParticleAnimatedMeshSceneNodeEmitter^ CreateAnimatedMeshSceneNodeEmitter(AnimatedMeshSceneNode^ particleNode, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees);
	ParticleAnimatedMeshSceneNodeEmitter^ CreateAnimatedMeshSceneNodeEmitter(AnimatedMeshSceneNode^ particleNode, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax);
	ParticleAnimatedMeshSceneNodeEmitter^ CreateAnimatedMeshSceneNodeEmitter(AnimatedMeshSceneNode^ particleNode, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor);
	ParticleAnimatedMeshSceneNodeEmitter^ CreateAnimatedMeshSceneNodeEmitter(AnimatedMeshSceneNode^ particleNode, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex, int minParticlesPerSecond, int maxParticlesPerSecond);
	ParticleAnimatedMeshSceneNodeEmitter^ CreateAnimatedMeshSceneNodeEmitter(AnimatedMeshSceneNode^ particleNode, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex);
	ParticleAnimatedMeshSceneNodeEmitter^ CreateAnimatedMeshSceneNodeEmitter(AnimatedMeshSceneNode^ particleNode, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex);
	ParticleAnimatedMeshSceneNodeEmitter^ CreateAnimatedMeshSceneNodeEmitter(AnimatedMeshSceneNode^ particleNode, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier);
	ParticleAnimatedMeshSceneNodeEmitter^ CreateAnimatedMeshSceneNodeEmitter(AnimatedMeshSceneNode^ particleNode, bool useNormalDirection, Vector3Df^ direction);
	ParticleAnimatedMeshSceneNodeEmitter^ CreateAnimatedMeshSceneNodeEmitter(AnimatedMeshSceneNode^ particleNode, bool useNormalDirection);
	ParticleAnimatedMeshSceneNodeEmitter^ CreateAnimatedMeshSceneNodeEmitter(AnimatedMeshSceneNode^ particleNode);

	ParticleAttractionAffector^ CreateAttractionAffector(Vector3Df^ point, float speed, bool attract, bool affectX, bool affectY, bool affectZ);
	ParticleAttractionAffector^ CreateAttractionAffector(Vector3Df^ point, float speed, bool attract);
	ParticleAttractionAffector^ CreateAttractionAffector(Vector3Df^ point, float speed);
	ParticleAttractionAffector^ CreateAttractionAffector(Vector3Df^ point);

	ParticleBoxEmitter^ CreateBoxEmitter(AABBox^ box, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees, Dimension2Df^ minStartSize, Dimension2Df^ maxStartSize);
	ParticleBoxEmitter^ CreateBoxEmitter(AABBox^ box, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees);
	ParticleBoxEmitter^ CreateBoxEmitter(AABBox^ box, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax);
	ParticleBoxEmitter^ CreateBoxEmitter(AABBox^ box, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor);
	ParticleBoxEmitter^ CreateBoxEmitter(AABBox^ box, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond);
	ParticleBoxEmitter^ CreateBoxEmitter(AABBox^ box, Vector3Df^ direction);
	ParticleBoxEmitter^ CreateBoxEmitter(AABBox^ box);
	ParticleBoxEmitter^ CreateBoxEmitter();

	ParticleCylinderEmitter^ CreateCylinderEmitter(Vector3Df^ center, float radius, Vector3Df^ normal, float length, bool outlineOnly, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees, Dimension2Df^ minStartSize, Dimension2Df^ maxStartSize);
	ParticleCylinderEmitter^ CreateCylinderEmitter(Vector3Df^ center, float radius, Vector3Df^ normal, float length, bool outlineOnly, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees);
	ParticleCylinderEmitter^ CreateCylinderEmitter(Vector3Df^ center, float radius, Vector3Df^ normal, float length, bool outlineOnly, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax);
	ParticleCylinderEmitter^ CreateCylinderEmitter(Vector3Df^ center, float radius, Vector3Df^ normal, float length, bool outlineOnly, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor);
	ParticleCylinderEmitter^ CreateCylinderEmitter(Vector3Df^ center, float radius, Vector3Df^ normal, float length, bool outlineOnly, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond);
	ParticleCylinderEmitter^ CreateCylinderEmitter(Vector3Df^ center, float radius, Vector3Df^ normal, float length, bool outlineOnly, Vector3Df^ direction);
	ParticleCylinderEmitter^ CreateCylinderEmitter(Vector3Df^ center, float radius, Vector3Df^ normal, float length, bool outlineOnly);
	ParticleCylinderEmitter^ CreateCylinderEmitter(Vector3Df^ center, float radius, Vector3Df^ normal, float length);

	ParticleFadeOutAffector^ CreateFadeOutParticleAffector(Video::Color^ targetColor, float timeNeededToFadeOut);
	ParticleFadeOutAffector^ CreateFadeOutParticleAffector(Video::Color^ targetColor);
	ParticleFadeOutAffector^ CreateFadeOutParticleAffector();

	ParticleGravityAffector^ CreateGravityAffector(Vector3Df^ gravity, unsigned int timeForceLost);
	ParticleGravityAffector^ CreateGravityAffector(Vector3Df^ gravity);
	ParticleGravityAffector^ CreateGravityAffector();

	ParticleMeshEmitter^ CreateMeshEmitter(Mesh^ particleMesh, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees, Dimension2Df^ minStartSize, Dimension2Df^ maxStartSize);
	ParticleMeshEmitter^ CreateMeshEmitter(Mesh^ particleMesh, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees);
	ParticleMeshEmitter^ CreateMeshEmitter(Mesh^ particleMesh, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax);
	ParticleMeshEmitter^ CreateMeshEmitter(Mesh^ particleMesh, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor);
	ParticleMeshEmitter^ CreateMeshEmitter(Mesh^ particleMesh, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex, int minParticlesPerSecond, int maxParticlesPerSecond);
	ParticleMeshEmitter^ CreateMeshEmitter(Mesh^ particleMesh, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex, bool everyMeshVertex);
	ParticleMeshEmitter^ CreateMeshEmitter(Mesh^ particleMesh, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier, int meshBufferIndex);
	ParticleMeshEmitter^ CreateMeshEmitter(Mesh^ particleMesh, bool useNormalDirection, Vector3Df^ direction, float normalDirectionModifier);
	ParticleMeshEmitter^ CreateMeshEmitter(Mesh^ particleMesh, bool useNormalDirection, Vector3Df^ direction);
	ParticleMeshEmitter^ CreateMeshEmitter(Mesh^ particleMesh, bool useNormalDirection);
	ParticleMeshEmitter^ CreateMeshEmitter(Mesh^ particleMesh);

	ParticleEmitter^ CreatePointEmitter(Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees, Dimension2Df^ minStartSize, Dimension2Df^ maxStartSize);
	ParticleEmitter^ CreatePointEmitter(Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees);
	ParticleEmitter^ CreatePointEmitter(Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax);
	ParticleEmitter^ CreatePointEmitter(Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor);
	ParticleEmitter^ CreatePointEmitter(Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond);
	ParticleEmitter^ CreatePointEmitter(Vector3Df^ direction);
	ParticleEmitter^ CreatePointEmitter();

	ParticleRingEmitter^ CreateRingEmitter(Vector3Df^ ringCenter, float ringRadius, float ringThickness, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees, Dimension2Df^ minStartSize, Dimension2Df^ maxStartSize);
	ParticleRingEmitter^ CreateRingEmitter(Vector3Df^ ringCenter, float ringRadius, float ringThickness, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees);
	ParticleRingEmitter^ CreateRingEmitter(Vector3Df^ ringCenter, float ringRadius, float ringThickness, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax);
	ParticleRingEmitter^ CreateRingEmitter(Vector3Df^ ringCenter, float ringRadius, float ringThickness, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor);
	ParticleRingEmitter^ CreateRingEmitter(Vector3Df^ ringCenter, float ringRadius, float ringThickness, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond);
	ParticleRingEmitter^ CreateRingEmitter(Vector3Df^ ringCenter, float ringRadius, float ringThickness, Vector3Df^ direction);
	ParticleRingEmitter^ CreateRingEmitter(Vector3Df^ ringCenter, float ringRadius, float ringThickness);

	ParticleRotationAffector^ CreateRotationAffector(Vector3Df^ speed, Vector3Df^ pivot);
	ParticleRotationAffector^ CreateRotationAffector(Vector3Df^ speed);
	ParticleRotationAffector^ CreateRotationAffector();

	ParticleAffector^ CreateScaleParticleAffector(Dimension2Df^ scaleTo);
	ParticleAffector^ CreateScaleParticleAffector();

	ParticleSphereEmitter^ CreateSphereEmitter(Vector3Df^ sphereCenter, float sphereRadius, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees, Dimension2Df^ minStartSize, Dimension2Df^ maxStartSize);
	ParticleSphereEmitter^ CreateSphereEmitter(Vector3Df^ sphereCenter, float sphereRadius, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax, int maxAngleDegrees);
	ParticleSphereEmitter^ CreateSphereEmitter(Vector3Df^ sphereCenter, float sphereRadius, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor, unsigned int lifeTimeMin, unsigned int lifeTimeMax);
	ParticleSphereEmitter^ CreateSphereEmitter(Vector3Df^ sphereCenter, float sphereRadius, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond, Video::Color^ minStartColor, Video::Color^ maxStartColor);
	ParticleSphereEmitter^ CreateSphereEmitter(Vector3Df^ sphereCenter, float sphereRadius, Vector3Df^ direction, int minParticlesPerSecond, int maxParticlesPerSecond);
	ParticleSphereEmitter^ CreateSphereEmitter(Vector3Df^ sphereCenter, float sphereRadius, Vector3Df^ direction);
	ParticleSphereEmitter^ CreateSphereEmitter(Vector3Df^ sphereCenter, float sphereRadius);

	void DoParticleSystem(unsigned int time);

	void RemoveAllAffectors();

	void SetParticlesAreGlobal(bool global);
	void SetParticlesAreGlobal();

	void SetParticleSize(Dimension2Df^ size);
	void SetParticleSize();

	property List<ParticleAffector^>^ AffectorList { List<ParticleAffector^>^ get(); }
	property ParticleEmitter^ Emitter { ParticleEmitter^ get(); void set(ParticleEmitter^ value); }

internal:

	static ParticleSystemSceneNode^ Wrap(scene::IParticleSystemSceneNode* ref);
	ParticleSystemSceneNode(scene::IParticleSystemSceneNode* ref);

	scene::IParticleSystemSceneNode* m_ParticleSystemSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime
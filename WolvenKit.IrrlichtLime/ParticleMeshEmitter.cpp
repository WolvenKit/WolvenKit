#include "stdafx.h"
#include "Mesh.h"
#include "ParticleEmitter.h"
#include "ParticleMeshEmitter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ParticleMeshEmitter^ ParticleMeshEmitter::Wrap(scene::IParticleMeshEmitter* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ParticleMeshEmitter(ref);
}

ParticleMeshEmitter::ParticleMeshEmitter(scene::IParticleMeshEmitter* ref)
	: ParticleEmitter(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ParticleMeshEmitter = ref;
}

bool ParticleMeshEmitter::EveryMeshVertex::get()
{
	return m_ParticleMeshEmitter->getEveryMeshVertex();
}

void ParticleMeshEmitter::EveryMeshVertex::set(bool value)
{
	m_ParticleMeshEmitter->setEveryMeshVertex(value);
}

Mesh^ ParticleMeshEmitter::ParticleMesh::get()
{
	scene::IMesh* m = (scene::IMesh*)m_ParticleMeshEmitter->getMesh(); // !!! cast to non-const pointer
	return Mesh::Wrap(m);
}

void ParticleMeshEmitter::ParticleMesh::set(Mesh^ value)
{
	m_ParticleMeshEmitter->setMesh(LIME_SAFEREF(value,m_Mesh));
}

float ParticleMeshEmitter::NormalDirectionModifier::get()
{
	return m_ParticleMeshEmitter->getNormalDirectionModifier();
}

void ParticleMeshEmitter::NormalDirectionModifier::set(float value)
{
	m_ParticleMeshEmitter->setNormalDirectionModifier(value);
}

bool ParticleMeshEmitter::UseNormalDirection::get()
{
	return m_ParticleMeshEmitter->isUsingNormalDirection();
}

void ParticleMeshEmitter::UseNormalDirection::set(bool value)
{
	m_ParticleMeshEmitter->setUseNormalDirection(value);
}

} // end namespace Scene
} // end namespace IrrlichtLime
#include "stdafx.h"
#include "AnimatedMesh.h"
#include "MeshCache.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

MeshCache^ MeshCache::Wrap(scene::IMeshCache* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew MeshCache(ref);
}

MeshCache::MeshCache(scene::IMeshCache* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_MeshCache = ref;
}

void MeshCache::AddMesh(String^ name, AnimatedMesh^ mesh)
{
	LIME_ASSERT(name != nullptr);

	m_MeshCache->addMesh(
		Lime::StringToPath(name),
		LIME_SAFEREF(mesh, m_AnimatedMesh));
}

void MeshCache::Clear(bool unusedOnly)
{
	if (unusedOnly)
		m_MeshCache->clearUnusedMeshes();
	else
		m_MeshCache->clear();
}

void MeshCache::Clear()
{
	m_MeshCache->clear();
}

AnimatedMesh^ MeshCache::GetMesh(int index)
{
	LIME_ASSERT(index >= 0 && index < MeshCount);

	scene::IAnimatedMesh* m = m_MeshCache->getMeshByIndex(index);
	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ MeshCache::GetMesh(String^ name)
{
	LIME_ASSERT(name != nullptr);

	scene::IAnimatedMesh* m = m_MeshCache->getMeshByName(Lime::StringToPath(name));
	return AnimatedMesh::Wrap(m);
}

int MeshCache::GetMeshIndex(Mesh^ mesh)
{
	LIME_ASSERT(mesh != nullptr);

	return m_MeshCache->getMeshIndex(
		LIME_SAFEREF(mesh, m_Mesh));
}

IO::NamedPath^ MeshCache::GetMeshName(Mesh^ mesh)
{
	LIME_ASSERT(mesh != nullptr);

	io::SNamedPath p = m_MeshCache->getMeshName(LIME_SAFEREF(mesh, m_Mesh));
	return gcnew IO::NamedPath(p);
}

IO::NamedPath^ MeshCache::GetMeshName(int index)
{
	LIME_ASSERT(index >= 0 && index < MeshCount);

	io::SNamedPath p = m_MeshCache->getMeshName(index);
	return gcnew IO::NamedPath(p);
}

bool MeshCache::IsMeshLoaded(String^ name)
{
	LIME_ASSERT(name != nullptr);
	return m_MeshCache->isMeshLoaded(Lime::StringToPath(name));
}

void MeshCache::RemoveMesh(Mesh^ mesh)
{
	LIME_ASSERT(mesh != nullptr);
	m_MeshCache->removeMesh(LIME_SAFEREF(mesh, m_Mesh));
}

bool MeshCache::RenameMesh(Mesh^ mesh, String^ name)
{
	LIME_ASSERT(mesh != nullptr);
	LIME_ASSERT(name != nullptr);

	return m_MeshCache->renameMesh(
		LIME_SAFEREF(mesh, m_Mesh),
		Lime::StringToPath(name));
}

bool MeshCache::RenameMesh(int index, String^ name)
{
	LIME_ASSERT(index >= 0 && index < MeshCount);
	LIME_ASSERT(name != nullptr);

	return m_MeshCache->renameMesh(
		index,
		Lime::StringToPath(name));
}

int MeshCache::MeshCount::get()
{
	return m_MeshCache->getMeshCount();
}

String^ MeshCache::ToString()
{
	return String::Format("MeshCache: MeshCount={0}", MeshCount);
}

} // end namespace Scene
} // end namespace IrrlichtLime
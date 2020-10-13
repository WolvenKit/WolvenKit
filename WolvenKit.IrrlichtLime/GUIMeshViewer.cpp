#include "stdafx.h"
#include "AnimatedMesh.h"
#include "GUIElement.h"
#include "GUIMeshViewer.h"
#include "Material.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIMeshViewer^ GUIMeshViewer::Wrap(gui::IGUIMeshViewer* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIMeshViewer(ref);
}

GUIMeshViewer::GUIMeshViewer(gui::IGUIMeshViewer* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIMeshViewer = ref;
}

Video::Material^ GUIMeshViewer::Material::get()
{
	video::SMaterial* m = &((video::SMaterial&)m_GUIMeshViewer->getMaterial()); // !!! cast to non-const pointer
	return Video::Material::Wrap(m);
}

void GUIMeshViewer::Material::set(Video::Material^ value)
{
	LIME_ASSERT(value != nullptr);
	m_GUIMeshViewer->setMaterial(*value->m_NativeValue);
}

Scene::AnimatedMesh^ GUIMeshViewer::Mesh::get()
{
	scene::IAnimatedMesh* m = m_GUIMeshViewer->getMesh();
	return Scene::AnimatedMesh::Wrap(m);
}

void GUIMeshViewer::Mesh::set(Scene::AnimatedMesh^ value)
{
	m_GUIMeshViewer->setMesh(LIME_SAFEREF(value, m_AnimatedMesh));
}

} // end namespace GUI
} // end namespace IrrlichtLime
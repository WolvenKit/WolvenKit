#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video { ref class Material; }
namespace Scene { ref class AnimatedMesh; }
namespace GUI {

public ref class GUIMeshViewer : GUIElement
{
public:

	property Video::Material^ Material { Video::Material^ get(); void set(Video::Material^ value); }
	property Scene::AnimatedMesh^ Mesh { Scene::AnimatedMesh^ get(); void set(Scene::AnimatedMesh^ value); }

internal:

	static GUIMeshViewer^ Wrap(gui::IGUIMeshViewer* ref);
	GUIMeshViewer(gui::IGUIMeshViewer* ref);

	gui::IGUIMeshViewer* m_GUIMeshViewer;
};

} // end namespace GUI
} // end namespace IrrlichtLime
#pragma once

#include "stdafx.h"
#include "TriangleSelector.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class MetaTriangleSelector : TriangleSelector
{
public:

	void AddTriangleSelector(TriangleSelector^ selector);
	void RemoveAllTriangleSelectors();
	bool RemoveTriangleSelector(TriangleSelector^ selector);

internal:

	static MetaTriangleSelector^ Wrap(scene::IMetaTriangleSelector* ref);
	MetaTriangleSelector(scene::IMetaTriangleSelector* ref);

	scene::IMetaTriangleSelector* m_MetaTriangleSelector;
};

} // end namespace Scene
} // end namespace IrrlichtLime
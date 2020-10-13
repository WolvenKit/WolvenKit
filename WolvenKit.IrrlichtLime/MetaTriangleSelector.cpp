#include "stdafx.h"
#include "MetaTriangleSelector.h"
#include "TriangleSelector.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

MetaTriangleSelector^ MetaTriangleSelector::Wrap(scene::IMetaTriangleSelector* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew MetaTriangleSelector(ref);
}

MetaTriangleSelector::MetaTriangleSelector(scene::IMetaTriangleSelector* ref)
	: TriangleSelector(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_MetaTriangleSelector = ref;
}

void MetaTriangleSelector::AddTriangleSelector(TriangleSelector^ selector)
{
	m_MetaTriangleSelector->addTriangleSelector(
		LIME_SAFEREF(selector, m_TriangleSelector));
}

void MetaTriangleSelector::RemoveAllTriangleSelectors()
{
	m_MetaTriangleSelector->removeAllTriangleSelectors();
}

bool MetaTriangleSelector::RemoveTriangleSelector(TriangleSelector^ selector)
{
	return m_MetaTriangleSelector->removeTriangleSelector(
		LIME_SAFEREF(selector, m_TriangleSelector));
}

} // end namespace Scene
} // end namespace IrrlichtLime
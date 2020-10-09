#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

public ref class MaterialRenderer : ReferenceCounted
{
public:

	//virtual bool OnRender(IMaterialRendererServices *service, E_VERTEX_TYPE vtxtype);
	//virtual void OnSetMaterial(const SMaterial &material, const SMaterial &lastMaterial, bool resetAllRenderstates, IMaterialRendererServices *services);
	//virtual void OnUnsetMaterial();

	property int Capability { int get(); }
	property bool Transparent { bool get(); }

	virtual String^ ToString() override;

internal:

	static MaterialRenderer^ Wrap(video::IMaterialRenderer* ref);
	MaterialRenderer(video::IMaterialRenderer* ref);

	video::IMaterialRenderer* m_MaterialRenderer;
};

} // end namespace Video
} // end namespace IrrlichtLime
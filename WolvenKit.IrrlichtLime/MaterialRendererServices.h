#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

ref class Material;
ref class VideoDriver;

public ref class MaterialRendererServices
{
public:

	void SetBasicRenderStates(Material^ newMaterial, Material^ lastMaterial, bool resetAllRenderStates);

	int GetPixelShaderConstantID(String^ name);
	void SetPixelShaderConstantList(int startRegisterIndex, array<float>^ valueFloats);
	bool SetPixelShaderConstant(int index, array<float>^ valueFloats);
	bool SetPixelShaderConstant(int index, array<int>^ valueInts);

	int GetVertexShaderConstantID(String^ name);
	void SetVertexShaderConstantList(int startRegisterIndex, array<float>^ valueFloats);
	bool SetVertexShaderConstant(int index, array<float>^ valueFloats);
	bool SetVertexShaderConstant(int index, array<int>^ valueInts);

	property Video::VideoDriver^ VideoDriver { Video::VideoDriver^ get(); }

	virtual String^ ToString() override;

internal:

	static MaterialRendererServices^ Wrap(video::IMaterialRendererServices* ref);
	MaterialRendererServices(video::IMaterialRendererServices* ref);

	video::IMaterialRendererServices* m_MaterialRendererServices;
};

} // end namespace Video
} // end namespace IrrlichtLime
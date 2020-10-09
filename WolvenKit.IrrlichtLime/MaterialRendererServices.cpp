#include "stdafx.h"
#include "Material.h"
#include "MaterialRendererServices.h"
#include "VideoDriver.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

MaterialRendererServices^ MaterialRendererServices::Wrap(video::IMaterialRendererServices* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew MaterialRendererServices(ref);
}

MaterialRendererServices::MaterialRendererServices(video::IMaterialRendererServices* ref)
{
	LIME_ASSERT(ref != nullptr);
	m_MaterialRendererServices = ref;
}

void MaterialRendererServices::SetBasicRenderStates(Material^ newMaterial, Material^ lastMaterial, bool resetAllRenderStates)
{
	LIME_ASSERT(newMaterial != nullptr);
	LIME_ASSERT(lastMaterial != nullptr);

	m_MaterialRendererServices->setBasicRenderStates(
		*newMaterial->m_NativeValue,
		*lastMaterial->m_NativeValue,
		resetAllRenderStates);
}

int MaterialRendererServices::GetPixelShaderConstantID(String^ name)
{
	LIME_ASSERT(name != nullptr);
	return m_MaterialRendererServices->getPixelShaderConstantID(LIME_SAFESTRINGTOSTRINGC_C_STR(name));
}

void MaterialRendererServices::SetPixelShaderConstantList(int startRegisterIndex, array<float>^ valueFloats)
{
	LIME_ASSERT(startRegisterIndex >= 0);
	LIME_ASSERT(valueFloats != nullptr);
	LIME_ASSERT(valueFloats->Length >= 4);
	LIME_ASSERT((valueFloats->Length % 4) == 0);

	int c = valueFloats->Length;
	float* f = new float[c];
	Marshal::Copy(valueFloats, 0, IntPtr(f), c);
	m_MaterialRendererServices->setPixelShaderConstant(f, startRegisterIndex, c / 4);

	delete[] f;
}

bool MaterialRendererServices::SetPixelShaderConstant(int index, array<float>^ valueFloats)
{
	LIME_ASSERT(index >= 0);
	LIME_ASSERT(valueFloats != nullptr);

	int c = valueFloats->Length;
	float* f = new float[c];
	Marshal::Copy(valueFloats, 0, IntPtr(f), c);
	bool b = m_MaterialRendererServices->setPixelShaderConstant(index, f, c);

	delete[] f;
	return b;
}

bool MaterialRendererServices::SetPixelShaderConstant(int index, array<int>^ valueInts)
{
	LIME_ASSERT(index >= 0);
	LIME_ASSERT(valueInts != nullptr);

	int c = valueInts->Length;
	int* v = new int[c];
	Marshal::Copy(valueInts, 0, IntPtr(v), c);
	bool b = m_MaterialRendererServices->setPixelShaderConstant(index, v, c);

	delete[] v;
	return b;
}

int MaterialRendererServices::GetVertexShaderConstantID(String^ name)
{
	LIME_ASSERT(name != nullptr);
	return m_MaterialRendererServices->getVertexShaderConstantID(LIME_SAFESTRINGTOSTRINGC_C_STR(name));
}

void MaterialRendererServices::SetVertexShaderConstantList(int startRegisterIndex, array<float>^ valueFloats)
{
	LIME_ASSERT(startRegisterIndex >= 0);
	LIME_ASSERT(valueFloats != nullptr);
	LIME_ASSERT(valueFloats->Length >= 4);
	LIME_ASSERT((valueFloats->Length % 4) == 0);

	int c = valueFloats->Length;
	float* f = new float[c];
	Marshal::Copy(valueFloats, 0, IntPtr(f), c);
	m_MaterialRendererServices->setVertexShaderConstant(f, startRegisterIndex, c / 4);

	delete[] f;
}

bool MaterialRendererServices::SetVertexShaderConstant(int index, array<float>^ valueFloats)
{
	LIME_ASSERT(index >= 0);
	LIME_ASSERT(valueFloats != nullptr);

	int c = valueFloats->Length;
	float* f = new float[c];
	Marshal::Copy(valueFloats, 0, IntPtr(f), c);
	bool b = m_MaterialRendererServices->setVertexShaderConstant(index, f, c);

	delete[] f;
	return b;
}

bool MaterialRendererServices::SetVertexShaderConstant(int index, array<int>^ valueInts)
{
	LIME_ASSERT(index >= 0);
	LIME_ASSERT(valueInts != nullptr);

	int c = valueInts->Length;
	int* v = new int[c];
	Marshal::Copy(valueInts, 0, IntPtr(v), c);
	bool b = m_MaterialRendererServices->setVertexShaderConstant(index,	v, c);

	delete[] v;
	return b;
}

Video::VideoDriver^ MaterialRendererServices::VideoDriver::get()
{
	video::IVideoDriver* d = m_MaterialRendererServices->getVideoDriver();
	return Video::VideoDriver::Wrap(d);
}

String^ MaterialRendererServices::ToString()
{
	return String::Format("MaterialRendererServices: VideoDriver={0}", VideoDriver);
}

} // end namespace Video
} // end namespace IrrlichtLime
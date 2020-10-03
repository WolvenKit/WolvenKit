#pragma once

#include <vcclr.h> // for gcroot
#include "stdafx.h"
#include "GPUProgrammingServices.h"
#include "MaterialRendererServices.h"

namespace IrrlichtLime {
namespace Video {

class ShaderCallBackInheritor : public video::IShaderConstantSetCallBack
{
public:

	gcroot<GPUProgrammingServices::SetConstantsHandler^> m_SetConstantsHandler;
	virtual void OnSetConstants(video::IMaterialRendererServices* services, int userData)
	{
		m_SetConstantsHandler->Invoke(
			MaterialRendererServices::Wrap(services),
			userData);
	}

	gcroot<GPUProgrammingServices::SetMaterialHandler^> m_SetMaterialHandler;
	virtual void OnSetMaterial(const SMaterial& material)
	{
		m_SetMaterialHandler->Invoke(
			Material::Wrap((SMaterial*)&material)); // !!! cast to non-const
	}
};

} // end namespace Video
} // end namespace IrrlichtLime
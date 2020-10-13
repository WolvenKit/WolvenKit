#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

ref class MaterialRendererServices;
class ShaderCallBackInheritor;

public ref class GPUProgrammingServices
{
public:

	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram, MaterialType baseMaterial, int userData);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram, MaterialType baseMaterial);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram);

	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderProgram, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, MaterialType baseMaterial, int userData, GPUShadingLanguage shadingLang);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderProgram, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, MaterialType baseMaterial, int userData);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderProgram, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, MaterialType baseMaterial);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderProgram, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram);

	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram, String^ geometryShaderProgram, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut, MaterialType baseMaterial, int userData);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram, String^ geometryShaderProgram, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut, MaterialType baseMaterial);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram, String^ geometryShaderProgram, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram, String^ geometryShaderProgram, Scene::PrimitiveType inType, Scene::PrimitiveType outType);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram, String^ geometryShaderProgram, Scene::PrimitiveType inType);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram, String^ geometryShaderProgram);

	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderProgram, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderProgram, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut, MaterialType baseMaterial, int userData, GPUShadingLanguage shadingLang);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderProgram, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderProgram, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut, MaterialType baseMaterial, int userData);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderProgram, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderProgram, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut, MaterialType baseMaterial);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderProgram, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderProgram, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderProgram, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderProgram, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget, Scene::PrimitiveType inType, Scene::PrimitiveType outType);
	MaterialType AddHighLevelShaderMaterial(String^ vertexShaderProgram, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderProgram, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderProgram, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget);

	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName, MaterialType baseMaterial, int userData);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName, MaterialType baseMaterial);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName);

	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderFileName, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, MaterialType baseMaterial, int userData, GPUShadingLanguage shadingLang);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderFileName, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, MaterialType baseMaterial, int userData);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderFileName, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, MaterialType baseMaterial);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderFileName, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName);

	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName, String^ geometryShaderFileName, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut, MaterialType baseMaterial, int userData);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName, String^ geometryShaderFileName, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut, MaterialType baseMaterial);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName, String^ geometryShaderFileName, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName, String^ geometryShaderFileName, Scene::PrimitiveType inType, Scene::PrimitiveType outType);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName, String^ geometryShaderFileName, Scene::PrimitiveType inType);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName, String^ geometryShaderFileName);

	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderFileName, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderFileName, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut, MaterialType baseMaterial, int userData, GPUShadingLanguage shadingLang);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderFileName, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderFileName, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut, MaterialType baseMaterial, int userData);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderFileName, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderFileName, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut, MaterialType baseMaterial);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderFileName, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderFileName, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget, Scene::PrimitiveType inType, Scene::PrimitiveType outType, unsigned int verticesOut);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderFileName, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderFileName, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget, Scene::PrimitiveType inType, Scene::PrimitiveType outType);
	MaterialType AddHighLevelShaderMaterialFromFiles(String^ vertexShaderFileName, String^ vertexShaderEntryPoint, VertexShaderType vsCompileTarget, String^ pixelShaderFileName, String^ pixelShaderEntryPoint, PixelShaderType psCompileTarget, String^ geometryShaderFileName, String^ geometryShaderEntryPoint, GeometryShaderType gsCompileTarget);

	MaterialType AddShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram, MaterialType baseMaterial, int userData);
	MaterialType AddShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram, MaterialType baseMaterial);
	MaterialType AddShaderMaterial(String^ vertexShaderProgram, String^ pixelShaderProgram);
	MaterialType AddShaderMaterial(String^ vertexShaderProgram);

	MaterialType AddShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName, MaterialType baseMaterial, int userData);
	MaterialType AddShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName, MaterialType baseMaterial);
	MaterialType AddShaderMaterialFromFiles(String^ vertexShaderFileName, String^ pixelShaderFileName);
	MaterialType AddShaderMaterialFromFiles(String^ vertexShaderFileName);

	delegate void SetConstantsHandler(MaterialRendererServices^ services, int userData);
	event SetConstantsHandler^ OnSetConstants;

	delegate void SetMaterialHandler(Material^ material);
	event SetMaterialHandler^ OnSetMaterial;

internal:

	static GPUProgrammingServices^ Wrap(video::IGPUProgrammingServices* ref);
	GPUProgrammingServices(video::IGPUProgrammingServices* ref);

	void SetConstants(MaterialRendererServices^ services, int userData);
	void SetMaterial(Material^ material);

	video::IGPUProgrammingServices* m_GPUProgrammingServices;
};

} // end namespace Video
} // end namespace IrrlichtLime
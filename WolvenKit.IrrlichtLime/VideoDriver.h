#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene { ref class IndexBuffer; ref class Mesh; ref class MeshBuffer; ref class MeshManipulator; ref class SceneNode; ref class VertexBuffer; }
namespace IO { ref class Attributes; ref class ReadFile; ref class WriteFile; }
namespace Video {

ref class GPUProgrammingServices;
ref class Image;
ref class ImageLoader;
ref class Light;
ref class Material;
ref class MaterialRenderer;
ref class Texture;

public ref class VideoDriver : ReferenceCounted
{
public:

	int AddDynamicLight(Light^ light);

	MaterialType AddMaterialRenderer(MaterialRenderer^ renderer, String^ name);
	MaterialType AddMaterialRenderer(MaterialRenderer^ renderer);

	void AddOcclusionQuery(Scene::SceneNode^ node, Scene::Mesh^ mesh);
	void AddOcclusionQuery(Scene::SceneNode^ node);

	Texture^ AddRenderTargetTexture(Dimension2Di^ size, String^ name, Video::ColorFormat format);
	Texture^ AddRenderTargetTexture(Dimension2Di^ size, String^ name);
	Texture^ AddRenderTargetTexture(Dimension2Di^ size);

	Texture^ AddTexture(Dimension2Di^ size, String^ name, Video::ColorFormat format);
	Texture^ AddTexture(Dimension2Di^ size, String^ name);
	Texture^ AddTexture(String^ name, Image^ image); // 3rd argument "void* mipmapData=0" currently not supported

	// BeginScene

	/// <summary>
	/// Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
	/// </summary>
	/// <param name="clearFlag">A combination of the <see cref="ClearBufferFlag"/> bit-flags. Default is <see cref="ClearBufferFlag::Color"/> | <see cref="ClearBufferFlag::Depth"/>.</param>
	/// <param name="clearColor">The clear color for the color buffer. Default is null (black).</param>
	/// <param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
	/// <param name="clearStencil">The clear value for the stencil buffer. Default is 0.</param>
	/// <param name="videoData">Handle of another window, if you want the bitmap to be displayed on another window.
	/// If this is an empty element, everything will be displayed in the default window.
	/// Note: This feature is not fully implemented for all devices. Default is null.</param>
	/// <param name="sourceRect">Rectangle defining the source rectangle of the area to be presented.
	/// Note: not implemented in all devices. Default is null (present everything).</param>
	/// <returns>False if failed.</returns>
	bool BeginScene(ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth, u8 clearStencil, ExposedVideoData^ videoData, Recti^ sourceRect);

	/// <summary>
	/// Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
	/// </summary>
	/// <param name="clearFlag">A combination of the <see cref="ClearBufferFlag"/> bit-flags. Default is <see cref="ClearBufferFlag::Color"/> | <see cref="ClearBufferFlag::Depth"/>.</param>
	/// <param name="clearColor">The clear color for the color buffer. Default is null (black).</param>
	/// <param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
	/// <param name="clearStencil">The clear value for the stencil buffer. Default is 0.</param>
	/// <param name="videoData">Handle of another window, if you want the bitmap to be displayed on another window.
	/// If this is an empty element, everything will be displayed in the default window.
	/// Note: This feature is not fully implemented for all devices. Default is null.</param>
	/// <returns>False if failed.</returns>
	bool BeginScene(ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth, u8 clearStencil, ExposedVideoData^ videoData);

	/// <summary>
	/// Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
	/// </summary>
	/// <param name="clearFlag">A combination of the <see cref="ClearBufferFlag"/> bit-flags. Default is <see cref="ClearBufferFlag::Color"/> | <see cref="ClearBufferFlag::Depth"/>.</param>
	/// <param name="clearColor">The clear color for the color buffer. Default is null (black).</param>
	/// <param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
	/// <param name="clearStencil">The clear value for the stencil buffer. Default is 0.</param>
	/// <returns>False if failed.</returns>
	bool BeginScene(ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth, u8 clearStencil);

	/// <summary>
	/// Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
	/// </summary>
	/// <param name="clearFlag">A combination of the <see cref="ClearBufferFlag"/> bit-flags. Default is <see cref="ClearBufferFlag::Color"/> | <see cref="ClearBufferFlag::Depth"/>.</param>
	/// <param name="clearColor">The clear color for the color buffer. Default is null (black).</param>
	/// <param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
	/// <returns>False if failed.</returns>
	bool BeginScene(ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth);

	/// <summary>
	/// Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
	/// </summary>
	/// <param name="clearFlag">A combination of the <see cref="ClearBufferFlag"/> bit-flags. Default is <see cref="ClearBufferFlag::Color"/> | <see cref="ClearBufferFlag::Depth"/>.</param>
	/// <param name="clearColor">The clear color for the color buffer. Default is null (black).</param>
	/// <returns>False if failed.</returns>
	bool BeginScene(ClearBufferFlag clearFlag, Color^ clearColor);

	/// <summary>
	/// Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
	/// </summary>
	/// <param name="clearFlag">A combination of the <see cref="ClearBufferFlag"/> bit-flags. Default is <see cref="ClearBufferFlag::Color"/> | <see cref="ClearBufferFlag::Depth"/>.</param>
	/// <returns>False if failed.</returns>
	bool BeginScene(ClearBufferFlag clearFlag);

	/// <summary>
	/// Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
	/// </summary>
	/// <returns>False if failed.</returns>
	bool BeginScene();

	bool CheckDriverReset();

	void ClearBuffers(ClearBufferFlag flag, Color^ color, f32 depth, u8 stencil);
	void ClearBuffers(ClearBufferFlag flag, Color^ color, f32 depth);
	void ClearBuffers(ClearBufferFlag flag, Color^ color);
	void ClearBuffers(ClearBufferFlag flag);

	IO::Attributes^ CreateAttributesFromMaterial(Material^ material);
	IO::Attributes^ CreateAttributesFromMaterial(Material^ material, IO::AttributeReadWriteOptions^ options);

	Image^ CreateImage(Texture^ texture, Vector2Di^ pos, Dimension2Di^ size);
	Image^ CreateImage(Texture^ texture);
	Image^ CreateUncompressedImage(Texture^ texture);

	Image^ CreateImage(Video::ColorFormat format, Dimension2Di^ size);
	Image^ CreateImage(String^ filename);
	Image^ CreateImage(IO::ReadFile^ file);

	Image^ CreateScreenShot();
	Image^ CreateScreenShot(Video::ColorFormat format);
	Image^ CreateScreenShot(Video::ColorFormat format, Video::RenderTarget target);

	void DeleteAllDynamicLights();

	void DisableFeature(VideoDriverFeature feature, bool flag);
	void DisableFeature(VideoDriverFeature feature);

	void Draw2DImage(Texture^ texture, Recti^ destRect, Recti^ sourceRect, Recti^ clipRect, List<Color^>^ colors, bool useAlphaChannelOfTexture);
	void Draw2DImage(Texture^ texture, Recti^ destRect, Recti^ sourceRect, Recti^ clipRect, List<Color^>^ colors);
	void Draw2DImage(Texture^ texture, Recti^ destRect, Recti^ sourceRect, Recti^ clipRect);
	void Draw2DImage(Texture^ texture, Recti^ destRect, Recti^ sourceRect);
	void Draw2DImage(Texture^ texture, Vector2Di^ destPos, Recti^ sourceRect, Recti^ clipRect, Color^ color, bool useAlphaChannelOfTexture);
	void Draw2DImage(Texture^ texture, Vector2Di^ destPos, Recti^ sourceRect, Recti^ clipRect, Color^ color);
	void Draw2DImage(Texture^ texture, Vector2Di^ destPos, Recti^ sourceRect, Recti^ clipRect);
	void Draw2DImage(Texture^ texture, Vector2Di^ destPos, Recti^ sourceRect);
	void Draw2DImage(Texture^ texture, Vector2Di^ destPos);
	
	void Draw2DImageBatch(Texture^ texture, List<Vector2Di^>^ positions, List<Recti^>^ sourceRects, Recti^ clipRect, Color^ color, bool useAlphaChannelOfTexture);
	void Draw2DImageBatch(Texture^ texture, List<Vector2Di^>^ positions, List<Recti^>^ sourceRects, Recti^ clipRect, Color^ color);
	void Draw2DImageBatch(Texture^ texture, List<Vector2Di^>^ positions, List<Recti^>^ sourceRects, Recti^ clipRect);
	void Draw2DImageBatch(Texture^ texture, List<Vector2Di^>^ positions, List<Recti^>^ sourceRects);

	void Draw2DImageBatch(Texture^ texture, Vector2Di^ position, List<Recti^>^ sourceRects, List<int>^ indices, int kerningWidth, Recti^ clipRect, Color^ color, bool useAlphaChannelOfTexture);
	void Draw2DImageBatch(Texture^ texture, Vector2Di^ position, List<Recti^>^ sourceRects, List<int>^ indices, int kerningWidth, Recti^ clipRect, Color^ color);
	void Draw2DImageBatch(Texture^ texture, Vector2Di^ position, List<Recti^>^ sourceRects, List<int>^ indices, int kerningWidth, Recti^ clipRect);
	void Draw2DImageBatch(Texture^ texture, Vector2Di^ position, List<Recti^>^ sourceRects, List<int>^ indices, int kerningWidth);
	void Draw2DImageBatch(Texture^ texture, Vector2Di^ position, List<Recti^>^ sourceRects, List<int>^ indices);

	void Draw2DLine(int x1, int y1, int x2, int y2, Color^ color);
	void Draw2DLine(Vector2Di^ start, Vector2Di^ end, Color^ color);

	void Draw2DPolygon(int x, int y, float radius, Color^ color, int vertexCount);
	void Draw2DPolygon(Vector2Di^ center, float radius, Color^ color, int vertexCount);

	void Draw2DRectangle(Recti^ pos, Color^ colorLeftUp, Color^ colorRightUp, Color^ colorLeftDown, Color^ colorRightDown, Recti^ clip);
	void Draw2DRectangle(Recti^ pos, Color^ colorLeftUp, Color^ colorRightUp, Color^ colorLeftDown, Color^ colorRightDown);
	void Draw2DRectangle(Recti^ pos, Color^ color, Recti^ clip);
	void Draw2DRectangle(Recti^ pos, Color^ color);
	void Draw2DRectangle(int x1, int y1, int x2, int y2, Color^ color);

	void Draw2DRectangleOutline(Recti^ pos, Color^ color);
	void Draw2DRectangleOutline(int x1, int y1, int x2, int y2, Color^ color);

	void Draw2DVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned short>^ indices16bit, Scene::PrimitiveType pType);
	void Draw2DVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned short>^ indices16bit);
	void Draw2DVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned int>^ indices32bit, Scene::PrimitiveType pType);
	void Draw2DVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned int>^ indices32bit);
	void Draw2DVertexPrimitiveList(Scene::VertexBuffer^ vertexBuffer, Scene::IndexBuffer^ indexBuffer, Scene::PrimitiveType pType);
	void Draw2DVertexPrimitiveList(Scene::VertexBuffer^ vertexBuffer, Scene::IndexBuffer^ indexBuffer);

	void Draw3DBox(AABBox^ box, Color^ color);

	void Draw3DLine(float x1, float y1, float z1, float x2, float y2, float z2, Color^ color);
	void Draw3DLine(Vector3Df^ start, Vector3Df^ end, Color^ color);
	void Draw3DLine(Line3Df^ line, Color^ color);

	void Draw3DTriangle(Vector3Df^ pointA, Vector3Df^ pointB, Vector3Df^ pointC, Color^ color);
	void Draw3DTriangle(Triangle3Df^ triangle, Color^ color);

	void DrawMeshBuffer(Scene::MeshBuffer^ mb);

	void DrawMeshBufferNormals(Scene::MeshBuffer^ mb, float length, Color^ color);
	void DrawMeshBufferNormals(Scene::MeshBuffer^ mb, float length);
	void DrawMeshBufferNormals(Scene::MeshBuffer^ mb);

	void DrawPixel(int x, int y, Color^ color);

	void DrawStencilShadow(bool clearStencilBuffer, Color^ leftUpEdge, Color^ rightUpEdge, Color^ leftDownEdge, Color^ rightDownEdge);
	void DrawStencilShadow(bool clearStencilBuffer, Color^ allEdges);
	void DrawStencilShadow(bool clearStencilBuffer);
	void DrawStencilShadow();

	void DrawStencilShadowVolume(List<Vector3Df^>^ triangles, bool zfail, Scene::DebugSceneType debugDataVisible);
	void DrawStencilShadowVolume(List<Vector3Df^>^ triangles, bool zfail);
	void DrawStencilShadowVolume(List<Vector3Df^>^ triangles);

	void DrawVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned short>^ indices16bit, Scene::PrimitiveType pType);
	void DrawVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned short>^ indices16bit);
	void DrawVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned int>^ indices32bit, Scene::PrimitiveType pType);
	void DrawVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned int>^ indices32bit);
	void DrawVertexPrimitiveList(Scene::VertexBuffer^ vertexBuffer, Scene::IndexBuffer^ indexBuffer, Scene::PrimitiveType pType);
	void DrawVertexPrimitiveList(Scene::VertexBuffer^ vertexBuffer, Scene::IndexBuffer^ indexBuffer);

	void EnableClipPlane(int index, bool enable);
	void EnableClipPlane(int index);

	void EnableMaterial2D(bool enable);
	void EnableMaterial2D();

	bool EndScene();

	Texture^ FindTexture(String^ filename);

	Light^ GetDynamicLight(int index);

	ImageLoader^ GetImageLoader(int index);

	Material^ GetMaterialFromAttributes(IO::Attributes^ attributes);

	MaterialRenderer^ GetMaterialRenderer(int index);
	MaterialRenderer^ GetMaterialRenderer(MaterialType material);
	String^ GetMaterialRendererName(int index);
	String^ GetMaterialRendererName(MaterialType material);

	int GetOcclusionQueryResult(Scene::SceneNode^ node);

	Texture^ GetTexture(String^ filename);
	Texture^ GetTexture(IO::ReadFile^ file);
	Texture^ GetTexture(int index);

	bool GetTextureCreationFlag(TextureCreationFlag flag);

	Matrix^ GetTransform(TransformationState state);

	void MakeColorKeyTexture(Texture^ texture, Color^ color);
	void MakeColorKeyTexture(Texture^ texture, Vector2Di^ colorKeyPixelPos);
	void MakeNormalMapTexture(Texture^ texture, float amplitude);
	void MakeNormalMapTexture(Texture^ texture);

	bool QueryFeature(VideoDriverFeature feature);

	void RemoveAllHardwareBuffers();
	void RemoveAllOcclusionQueries();
	void RemoveAllTextures();
	void RemoveHardwareBuffer(Scene::MeshBuffer^ mb);
	void RemoveOcclusionQuery(Scene::SceneNode^ node);
	void RemoveTexture(Texture^ texture);

	void RenameTexture(Texture^ texture, String^ newName);

	void ResizeNotify(Dimension2Di^ size);

	void RunAllOcclusionQueries(bool visible);
	void RunAllOcclusionQueries();
	void RunOcclusionQuery(Scene::SceneNode^ node, bool visible);
	void RunOcclusionQuery(Scene::SceneNode^ node);

	bool SetClipPlane(int index, Plane3Df^ plane, bool enable);
	bool SetClipPlane(int index, Plane3Df^ plane);

	void SetMaterial(Material^ material);

	void SetMaterialRendererName(MaterialType materialType, String^ name);

	void SetMinHardwareBufferVertexCount(int count);

	/// <summary>
	/// Sets a new render target.
	/// This will only work if the driver supports the <see cref="VideoDriverFeature::RenderToTarget"/>, which can be queried with <c>QueryFeature()</c>.
	/// Please note that you cannot render 3D or 2D geometry with a render target as texture on it when you are rendering the scene into this render target
	/// at the same time. It is usually only possible to render into a texture between the <c>BeginScene()</c> and <c>EndScene()</c> calls.
	/// </summary>
	/// <param name="texture">New render target. Must be a texture created with <c>AddRenderTargetTexture()</c>.
	/// If set to <c>null</c>, it sets the previous render target which was set before the last method call.</param>
	/// <param name="clearFlag">A combination of the <see cref="ClearBufferFlag"/> bit-flags. Default is <see cref="ClearBufferFlag::Color"/> | <see cref="ClearBufferFlag::Depth"/>.</param>
	/// <param name="clearColor">The clear color for the color buffer. Default is black.</param>
	/// <param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
	/// <param name="clearStencil">The clear value for the stencil buffer. Default is 0.</param>
	/// <returns>True if successful and false if not.</returns>
	bool SetRenderTarget(Texture^ texture, ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth, u8 clearStencil);

	/// <summary>
	/// Sets a new render target.
	/// This will only work if the driver supports the <see cref="VideoDriverFeature::RenderToTarget"/>, which can be queried with <c>QueryFeature()</c>.
	/// Please note that you cannot render 3D or 2D geometry with a render target as texture on it when you are rendering the scene into this render target
	/// at the same time. It is usually only possible to render into a texture between the <c>BeginScene()</c> and <c>EndScene()</c> calls.
	/// </summary>
	/// <param name="texture">New render target. Must be a texture created with <c>AddRenderTargetTexture()</c>.
	/// If set to <c>null</c>, it sets the previous render target which was set before the last method call.</param>
	/// <param name="clearFlag">A combination of the <see cref="ClearBufferFlag"/> bit-flags. Default is <see cref="ClearBufferFlag::Color"/> | <see cref="ClearBufferFlag::Depth"/>.</param>
	/// <param name="clearColor">The clear color for the color buffer. Default is black.</param>
	/// <param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
	/// <returns>True if successful and false if not.</returns>
	bool SetRenderTarget(Texture^ texture, ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth);

	/// <summary>
	/// Sets a new render target.
	/// This will only work if the driver supports the <see cref="VideoDriverFeature::RenderToTarget"/>, which can be queried with <c>QueryFeature()</c>.
	/// Please note that you cannot render 3D or 2D geometry with a render target as texture on it when you are rendering the scene into this render target
	/// at the same time. It is usually only possible to render into a texture between the <c>BeginScene()</c> and <c>EndScene()</c> calls.
	/// </summary>
	/// <param name="texture">New render target. Must be a texture created with <c>AddRenderTargetTexture()</c>.
	/// If set to <c>null</c>, it sets the previous render target which was set before the last method call.</param>
	/// <param name="clearFlag">A combination of the <see cref="ClearBufferFlag"/> bit-flags. Default is <see cref="ClearBufferFlag::Color"/> | <see cref="ClearBufferFlag::Depth"/>.</param>
	/// <param name="clearColor">The clear color for the color buffer. Default is black.</param>
	/// <returns>True if successful and false if not.</returns>
	bool SetRenderTarget(Texture^ texture, ClearBufferFlag clearFlag, Color^ clearColor);

	/// <summary>
	/// Sets a new render target.
	/// This will only work if the driver supports the <see cref="VideoDriverFeature::RenderToTarget"/>, which can be queried with <c>QueryFeature()</c>.
	/// Please note that you cannot render 3D or 2D geometry with a render target as texture on it when you are rendering the scene into this render target
	/// at the same time. It is usually only possible to render into a texture between the <c>BeginScene()</c> and <c>EndScene()</c> calls.
	/// </summary>
	/// <param name="texture">New render target. Must be a texture created with <c>AddRenderTargetTexture()</c>.
	/// If set to <c>null</c>, it sets the previous render target which was set before the last method call.</param>
	/// <param name="clearFlag">A combination of the <see cref="ClearBufferFlag"/> bit-flags. Default is <see cref="ClearBufferFlag::Color"/> | <see cref="ClearBufferFlag::Depth"/>.</param>
	/// <returns>True if successful and false if not.</returns>
	bool SetRenderTarget(Texture^ texture, ClearBufferFlag clearFlag);

	/// <summary>
	/// Sets a new render target.
	/// This will only work if the driver supports the <see cref="VideoDriverFeature::RenderToTarget"/>, which can be queried with <c>QueryFeature()</c>.
	/// Please note that you cannot render 3D or 2D geometry with a render target as texture on it when you are rendering the scene into this render target
	/// at the same time. It is usually only possible to render into a texture between the <c>BeginScene()</c> and <c>EndScene()</c> calls.
	/// </summary>
	/// <param name="texture">New render target. Must be a texture created with <c>AddRenderTargetTexture()</c>.
	/// If set to <c>null</c>, it sets the previous render target which was set before the last method call.</param>
	/// <returns>True if successful and false if not.</returns>
	bool SetRenderTarget(Texture^ texture);

	void SetTextureCreationFlag(TextureCreationFlag flag, bool enabled);

	void SetTransform(TransformationState state, Matrix^ mat);

	void TurnLight(int index, bool turnOn);

	void UpdateAllOcclusionQueries(bool block);
	void UpdateAllOcclusionQueries();
	void UpdateOcclusionQuery(Scene::SceneNode^ node, bool block);
	void UpdateOcclusionQuery(Scene::SceneNode^ node);

	bool WriteImage(Image^ image, String^ filename, unsigned int param);
	bool WriteImage(Image^ image, String^ filename);
	bool WriteImage(Image^ image, IO::WriteFile^ file, unsigned int param);
	bool WriteImage(Image^ image, IO::WriteFile^ file);

	property IO::Attributes^ Attributes { IO::Attributes^ get(); }
	property Video::ColorFormat ColorFormat { Video::ColorFormat get(); }
	property Dimension2Di^ CurrentRenderTargetSize { Dimension2Di^ get(); }
	property Video::DriverType DriverType { Video::DriverType get(); }
	property int DynamicLightCount { int get(); }
	property Video::ExposedVideoData^ ExposedVideoData { Video::ExposedVideoData^ get(); }
	property List<VideoDriverFeature>^ FeatureList { List<VideoDriverFeature>^ get(); }
	property Video::Fog^ Fog { Video::Fog^ get(); void set(Video::Fog^ value); }
	property int FPS { int get(); }
	property Video::GPUProgrammingServices^ GPUProgrammingServices { Video::GPUProgrammingServices^ get(); }
	property int ImageLoaderCount { int get(); }
	property Material^ Material2D { Material^ get(); }
	property int MaterialRendererCount { int get(); }
	property int MaxDynamicLightCount { int get(); }
	property int MaxPrimitiveCount { int get(); }
	property Dimension2Di^ MaxTextureSize { Dimension2Di^ get(); }
	property Scene::MeshManipulator^ MeshManipulator { Scene::MeshManipulator^ get(); }
	property String^ Name { String^ get(); }
	property int PrimitiveCountDrawn { int get(); }
	property Dimension2Di^ ScreenSize { Dimension2Di^ get(); }
	property int TextureCount { int get(); }
	property List<Texture^>^ TextureList { List<Texture^>^ get(); }
	property String^ VendorInfo { String^ get(); }
	property Recti^ ViewPort { Recti^ get(); void set(Recti^ value); }

	virtual String^ ToString() override;

internal:

	static VideoDriver^ Wrap(video::IVideoDriver* ref);
	VideoDriver(video::IVideoDriver* ref);

	video::IVideoDriver* m_VideoDriver;

	static unsigned int calculatePrimitiveCount(unsigned int indexCount, Scene::PrimitiveType pType);
};

} // end namespace Video
} // end namespace IrrlichtLime

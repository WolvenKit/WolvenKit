// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_VIDEO_NULL_H_INCLUDED__
#define __C_VIDEO_NULL_H_INCLUDED__

#include "IVideoDriver.h"
#include "IFileSystem.h"
#include "IImagePresenter.h"
#include "IGPUProgrammingServices.h"
#include "irrArray.h"
#include "irrString.h"
#include "irrMap.h"
#include "IAttributes.h"
#include "IMesh.h"
#include "IMeshBuffer.h"
#include "IMeshSceneNode.h"
#include "CFPSCounter.h"
#include "S3DVertex.h"
#include "SVertexIndex.h"
#include "SLight.h"
#include "SExposedVideoData.h"

#ifdef _MSC_VER
#pragma warning( disable: 4996)
#endif

namespace irr
{
namespace io
{
	class IWriteFile;
	class IReadFile;
} // end namespace io
namespace video
{
	class IImageLoader;
	class IImageWriter;

	class CNullDriver : public IVideoDriver, public IGPUProgrammingServices
	{
	public:

		//! constructor
		CNullDriver(io::IFileSystem* io, const core::dimension2d<u32>& screenSize);

		//! destructor
		~CNullDriver();

		bool beginScene(u16 clearFlag, SColor clearColor = SColor(255,0,0,0), f32 clearDepth = 1.f, u8 clearStencil = 0,
			const SExposedVideoData& videoData = SExposedVideoData(), core::rect<s32>* sourceRect = 0) _IRR_OVERRIDE_;

		bool endScene() _IRR_OVERRIDE_;

		//! Disable a feature of the driver.
		void disableFeature(E_VIDEO_DRIVER_FEATURE feature, bool flag=true) _IRR_OVERRIDE_;

		//! queries the features of the driver, returns true if feature is available
		bool queryFeature(E_VIDEO_DRIVER_FEATURE feature) const _IRR_OVERRIDE_;

		//! Get attributes of the actual video driver
		const io::IAttributes& getDriverAttributes() const _IRR_OVERRIDE_;

		//! sets transformation
		void setTransform(E_TRANSFORMATION_STATE state, const core::matrix4& mat) _IRR_OVERRIDE_;

		//! Retrieve the number of image loaders
		u32 getImageLoaderCount() const _IRR_OVERRIDE_;

		//! Retrieve the given image loader
		IImageLoader* getImageLoader(u32 n) _IRR_OVERRIDE_;

		//! Retrieve the number of image writers
		u32 getImageWriterCount() const _IRR_OVERRIDE_;

		//! Retrieve the given image writer
		IImageWriter* getImageWriter(u32 n) _IRR_OVERRIDE_;

		//! sets a material
		void setMaterial(const SMaterial& material) _IRR_OVERRIDE_;

		//! loads a Texture
		ITexture* getTexture(const io::path& filename) _IRR_OVERRIDE_;

		//! loads a Texture
		ITexture* getTexture(io::IReadFile* file) _IRR_OVERRIDE_;

		//! Returns a texture by index
		ITexture* getTextureByIndex(u32 index) _IRR_OVERRIDE_;

		//! Returns amount of textures currently loaded
		u32 getTextureCount() const _IRR_OVERRIDE_;

		//! Renames a texture
		void renameTexture(ITexture* texture, const io::path& newName) _IRR_OVERRIDE_;

		ITexture* addTexture(const core::dimension2d<u32>& size, const io::path& name, ECOLOR_FORMAT format = ECF_A8R8G8B8) _IRR_OVERRIDE_;

		ITexture* addTexture(const io::path& name, IImage* image) _IRR_OVERRIDE_;

		ITexture* addTextureCubemap(const io::path& name, IImage* imagePosX, IImage* imageNegX, IImage* imagePosY,
			IImage* imageNegY, IImage* imagePosZ, IImage* imageNegZ) _IRR_OVERRIDE_;

		ITexture* addTextureCubemap(const irr::u32 sideLen, const io::path& name, ECOLOR_FORMAT format = ECF_A8R8G8B8) _IRR_OVERRIDE_;

		bool setRenderTargetEx(IRenderTarget* target, u16 clearFlag, SColor clearColor = SColor(255,0,0,0),
			f32 clearDepth = 1.f, u8 clearStencil = 0) _IRR_OVERRIDE_;

		bool setRenderTarget(ITexture* texture, u16 clearFlag, SColor clearColor = SColor(255,0,0,0),
			f32 clearDepth = 1.f, u8 clearStencil = 0) _IRR_OVERRIDE_;

		//! sets a viewport
		void setViewPort(const core::rect<s32>& area) _IRR_OVERRIDE_;

		//! gets the area of the current viewport
		const core::rect<s32>& getViewPort() const _IRR_OVERRIDE_;

		//! draws a vertex primitive list
		void drawVertexPrimitiveList(const void* vertices, u32 vertexCount,
				const void* indexList, u32 primitiveCount,
				E_VERTEX_TYPE vType=EVT_STANDARD, scene::E_PRIMITIVE_TYPE pType=scene::EPT_TRIANGLES,
				E_INDEX_TYPE iType=EIT_16BIT) _IRR_OVERRIDE_;

		//! draws a vertex primitive list in 2d
		void draw2DVertexPrimitiveList(const void* vertices, u32 vertexCount,
				const void* indexList, u32 primitiveCount,
				E_VERTEX_TYPE vType=EVT_STANDARD, scene::E_PRIMITIVE_TYPE pType=scene::EPT_TRIANGLES,
				E_INDEX_TYPE iType=EIT_16BIT) _IRR_OVERRIDE_;

		//! Draws a 3d line.
		void draw3DLine(const core::vector3df& start,
			const core::vector3df& end, SColor color = SColor(255,255,255,255)) _IRR_OVERRIDE_;

		//! Draws a 3d triangle.
		void draw3DTriangle(const core::triangle3df& triangle,
			SColor color = SColor(255,255,255,255)) _IRR_OVERRIDE_;

		//! Draws a 3d axis aligned box.
		void draw3DBox(const core::aabbox3d<f32>& box,
			SColor color = SColor(255,255,255,255)) _IRR_OVERRIDE_;

		//! draws an 2d image
		void draw2DImage(const video::ITexture* texture, const core::position2d<s32>& destPos) _IRR_OVERRIDE_;

		//! draws a set of 2d images, using a color and the alpha
		/** channel of the texture if desired. The images are drawn
		beginning at pos and concatenated in one line. All drawings
		are clipped against clipRect (if != 0).
		The subtextures are defined by the array of sourceRects
		and are chosen by the indices given.
		\param texture: Texture to be drawn.
		\param pos: Upper left 2d destination position where the image will be drawn.
		\param sourceRects: Source rectangles of the image.
		\param indices: List of indices which choose the actual rectangle used each time.
		\param kerningWidth: offset on position
		\param clipRect: Pointer to rectangle on the screen where the image is clipped to.
		This pointer can be 0. Then the image is not clipped.
		\param color: Color with which the image is colored.
		Note that the alpha component is used: If alpha is other than 255, the image will be transparent.
		\param useAlphaChannelOfTexture: If true, the alpha channel of the texture is
		used to draw the image. */
		void draw2DImageBatch(const video::ITexture* texture,
				const core::position2d<s32>& pos,
				const core::array<core::rect<s32> >& sourceRects,
				const core::array<s32>& indices,
				s32 kerningWidth = 0,
				const core::rect<s32>* clipRect = 0,
				SColor color=SColor(255,255,255,255),
				bool useAlphaChannelOfTexture=false) _IRR_OVERRIDE_;

		//! Draws a set of 2d images, using a color and the alpha channel of the texture.
		/** All drawings are clipped against clipRect (if != 0).
		The subtextures are defined by the array of sourceRects and are
		positioned using the array of positions.
		\param texture Texture to be drawn.
		\param pos Array of upper left 2d destinations where the images
		will be drawn.
		\param sourceRects Source rectangles of the image.
		\param clipRect Pointer to rectangle on the screen where the
		images are clipped to.
		If this pointer is 0 then the image is not clipped.
		\param color Color with which the image is drawn.
		Note that the alpha component is used. If alpha is other than
		255, the image will be transparent.
		\param useAlphaChannelOfTexture: If true, the alpha channel of
		the texture is used to draw the image. */
		void draw2DImageBatch(const video::ITexture* texture,
				const core::array<core::position2d<s32> >& positions,
				const core::array<core::rect<s32> >& sourceRects,
				const core::rect<s32>* clipRect=0,
				SColor color=SColor(255,255,255,255),
				bool useAlphaChannelOfTexture=false) _IRR_OVERRIDE_;

		//! Draws a 2d image, using a color (if color is other then Color(255,255,255,255)) and the alpha channel of the texture if wanted.
		void draw2DImage(const video::ITexture* texture, const core::position2d<s32>& destPos,
			const core::rect<s32>& sourceRect, const core::rect<s32>* clipRect = 0,
			SColor color=SColor(255,255,255,255), bool useAlphaChannelOfTexture=false) _IRR_OVERRIDE_;

		//! Draws a part of the texture into the rectangle.
		void draw2DImage(const video::ITexture* texture, const core::rect<s32>& destRect,
			const core::rect<s32>& sourceRect, const core::rect<s32>* clipRect = 0,
			const video::SColor* const colors=0, bool useAlphaChannelOfTexture=false) _IRR_OVERRIDE_;

		//! Draws a 2d rectangle
		void draw2DRectangle(SColor color, const core::rect<s32>& pos, const core::rect<s32>* clip = 0) _IRR_OVERRIDE_;

		//! Draws a 2d rectangle with a gradient.
		void draw2DRectangle(const core::rect<s32>& pos,
			SColor colorLeftUp, SColor colorRightUp, SColor colorLeftDown, SColor colorRightDown,
			const core::rect<s32>* clip = 0) _IRR_OVERRIDE_;

		//! Draws the outline of a 2d rectangle
		void draw2DRectangleOutline(const core::recti& pos, SColor color=SColor(255,255,255,255)) _IRR_OVERRIDE_;

		//! Draws a 2d line.
		void draw2DLine(const core::position2d<s32>& start,
					const core::position2d<s32>& end,
					SColor color=SColor(255,255,255,255)) _IRR_OVERRIDE_;

		//! Draws a pixel
		void drawPixel(u32 x, u32 y, const SColor & color) _IRR_OVERRIDE_;

		//! Draws a non filled concyclic reqular 2d polygon.
		void draw2DPolygon(core::position2d<s32> center,
			f32 radius, video::SColor Color, s32 vertexCount) _IRR_OVERRIDE_;

		void setFog(SColor color=SColor(0,255,255,255),
				E_FOG_TYPE fogType=EFT_FOG_LINEAR,
				f32 start=50.0f, f32 end=100.0f, f32 density=0.01f,
				bool pixelFog=false, bool rangeFog=false) _IRR_OVERRIDE_;

		void getFog(SColor& color, E_FOG_TYPE& fogType,
				f32& start, f32& end, f32& density,
				bool& pixelFog, bool& rangeFog) _IRR_OVERRIDE_;

		//! get color format of the current color buffer
		ECOLOR_FORMAT getColorFormat() const _IRR_OVERRIDE_;

		//! get screen size
		const core::dimension2d<u32>& getScreenSize() const _IRR_OVERRIDE_;

		//! get current render target
		IRenderTarget* getCurrentRenderTarget() const;

		//! get render target size
		const core::dimension2d<u32>& getCurrentRenderTargetSize() const _IRR_OVERRIDE_;

		// get current frames per second value
		s32 getFPS() const _IRR_OVERRIDE_;

		//! returns amount of primitives (mostly triangles) were drawn in the last frame.
		//! very useful method for statistics.
		u32 getPrimitiveCountDrawn( u32 param = 0 ) const _IRR_OVERRIDE_;

		//! deletes all dynamic lights there are
		void deleteAllDynamicLights() _IRR_OVERRIDE_;

		//! adds a dynamic light, returning an index to the light
		//! \param light: the light data to use to create the light
		//! \return An index to the light, or -1 if an error occurs
		s32 addDynamicLight(const SLight& light) _IRR_OVERRIDE_;

		//! Turns a dynamic light on or off
		//! \param lightIndex: the index returned by addDynamicLight
		//! \param turnOn: true to turn the light on, false to turn it off
		void turnLightOn(s32 lightIndex, bool turnOn) _IRR_OVERRIDE_;

		//! returns the maximal amount of dynamic lights the device can handle
		u32 getMaximalDynamicLightAmount() const _IRR_OVERRIDE_;

		//! \return Returns the name of the video driver. Example: In case of the DIRECT3D8
		//! driver, it would return "Direct3D8.1".
		const wchar_t* getName() const _IRR_OVERRIDE_;

		//! Sets the dynamic ambient light color. The default color is
		//! (0,0,0,0) which means it is dark.
		//! \param color: New color of the ambient light.
		void setAmbientLight(const SColorf& color) _IRR_OVERRIDE_;

		//! Adds an external image loader to the engine.
		void addExternalImageLoader(IImageLoader* loader) _IRR_OVERRIDE_;

		//! Adds an external image writer to the engine.
		void addExternalImageWriter(IImageWriter* writer) _IRR_OVERRIDE_;

		//! Draws a shadow volume into the stencil buffer. To draw a stencil shadow, do
		//! this: Frist, draw all geometry. Then use this method, to draw the shadow
		//! volume. Then, use IVideoDriver::drawStencilShadow() to visualize the shadow.
		void drawStencilShadowVolume(const core::array<core::vector3df>& triangles,
			bool zfail=true, u32 debugDataVisible=0) _IRR_OVERRIDE_;

		//! Fills the stencil shadow with color. After the shadow volume has been drawn
		//! into the stencil buffer using IVideoDriver::drawStencilShadowVolume(), use this
		//! to draw the color of the shadow.
		void drawStencilShadow(bool clearStencilBuffer=false,
			video::SColor leftUpEdge = video::SColor(0,0,0,0),
			video::SColor rightUpEdge = video::SColor(0,0,0,0),
			video::SColor leftDownEdge = video::SColor(0,0,0,0),
			video::SColor rightDownEdge = video::SColor(0,0,0,0)) _IRR_OVERRIDE_;

		//! Returns current amount of dynamic lights set
		//! \return Current amount of dynamic lights set
		u32 getDynamicLightCount() const _IRR_OVERRIDE_;

		//! Returns light data which was previously set with IVideDriver::addDynamicLight().
		//! \param idx: Zero based index of the light. Must be greater than 0 and smaller
		//! than IVideoDriver()::getDynamicLightCount.
		//! \return Light data.
		const SLight& getDynamicLight(u32 idx) const _IRR_OVERRIDE_;

		//! Removes a texture from the texture cache and deletes it, freeing lot of
		//! memory.
		void removeTexture(ITexture* texture) _IRR_OVERRIDE_;

		//! Removes all texture from the texture cache and deletes them, freeing lot of
		//! memory.
		void removeAllTextures() _IRR_OVERRIDE_;

		//! Creates a render target texture.
		ITexture* addRenderTargetTexture(const core::dimension2d<u32>& size,
			const io::path& name, const ECOLOR_FORMAT format = ECF_UNKNOWN) _IRR_OVERRIDE_;

		//! Creates a render target texture for a cubemap
		ITexture* addRenderTargetTextureCubemap(const irr::u32 sideLen,
				const io::path& name, const ECOLOR_FORMAT format) _IRR_OVERRIDE_;

		//! Creates an 1bit alpha channel of the texture based of an color key.
		void makeColorKeyTexture(video::ITexture* texture, video::SColor color, bool zeroTexels) const _IRR_OVERRIDE_;

		//! Creates an 1bit alpha channel of the texture based of an color key position.
		void makeColorKeyTexture(video::ITexture* texture, core::position2d<s32> colorKeyPixelPos,
			bool zeroTexels) const _IRR_OVERRIDE_;

		//! Creates a normal map from a height map texture.
		//! \param amplitude: Constant value by which the height information is multiplied.
		void makeNormalMapTexture(video::ITexture* texture, f32 amplitude=1.0f) const _IRR_OVERRIDE_;

		//! Returns the maximum amount of primitives (mostly vertices) which
		//! the device is able to render with one drawIndexedTriangleList
		//! call.
		u32 getMaximalPrimitiveCount() const _IRR_OVERRIDE_;

		//! Enables or disables a texture creation flag.
		void setTextureCreationFlag(E_TEXTURE_CREATION_FLAG flag, bool enabled) _IRR_OVERRIDE_;

		//! Returns if a texture creation flag is enabled or disabled.
		bool getTextureCreationFlag(E_TEXTURE_CREATION_FLAG flag) const _IRR_OVERRIDE_;

		core::array<IImage*> createImagesFromFile(const io::path& filename, E_TEXTURE_TYPE* type = 0) _IRR_OVERRIDE_;

		core::array<IImage*> createImagesFromFile(io::IReadFile* file, E_TEXTURE_TYPE* type = 0) _IRR_OVERRIDE_;

		//! Creates a software image from a byte array.
		/** \param useForeignMemory: If true, the image will use the data pointer
		directly and own it from now on, which means it will also try to delete [] the
		data when the image will be destructed. If false, the memory will by copied. */
		IImage* createImageFromData(ECOLOR_FORMAT format,
			const core::dimension2d<u32>& size, void *data, bool ownForeignMemory = false,
			bool deleteMemory = true) _IRR_OVERRIDE_;

		//! Creates an empty software image.
		IImage* createImage(ECOLOR_FORMAT format, const core::dimension2d<u32>& size) _IRR_OVERRIDE_;

		//! Creates a software image from another image.
		IImage* createImage(ECOLOR_FORMAT format, IImage *imageToCopy) _IRR_OVERRIDE_;

		//! Creates a software image from part of another image.
		IImage* createImage(IImage* imageToCopy,
				const core::position2d<s32>& pos,
				const core::dimension2d<u32>& size) _IRR_OVERRIDE_;

		//! Creates a software image from part of a texture.
		IImage* createImage(ITexture* texture,
				const core::position2d<s32>& pos,
				const core::dimension2d<u32>& size) _IRR_OVERRIDE_;

        IImage* createUncompressedImage(ITexture* texture,
            const core::position2d<s32>& pos,
            const core::dimension2d<u32>& size) _IRR_OVERRIDE_;

		//! Draws a mesh buffer
		void drawMeshBuffer(const scene::IMeshBuffer* mb) _IRR_OVERRIDE_;

		//! Draws the normals of a mesh buffer
		void drawMeshBufferNormals(const scene::IMeshBuffer* mb, f32 length=10.f,
			SColor color=0xffffffff) _IRR_OVERRIDE_;

		//! Check if the driver supports creating textures with the given color format
		bool queryTextureFormat(ECOLOR_FORMAT format) const _IRR_OVERRIDE_
		{
			return false;
		}

	protected:
		struct SHWBufferLink
		{
			SHWBufferLink(const scene::IMeshBuffer *_MeshBuffer)
				:MeshBuffer(_MeshBuffer),
				ChangedID_Vertex(0),ChangedID_Index(0),LastUsed(0),
				Mapped_Vertex(scene::EHM_NEVER),Mapped_Index(scene::EHM_NEVER)
			{
				if (MeshBuffer)
					MeshBuffer->grab();
			}

			virtual ~SHWBufferLink()
			{
				if (MeshBuffer)
					MeshBuffer->drop();
			}

			const scene::IMeshBuffer *MeshBuffer;
			u32 ChangedID_Vertex;
			u32 ChangedID_Index;
			u32 LastUsed;
			scene::E_HARDWARE_MAPPING Mapped_Vertex;
			scene::E_HARDWARE_MAPPING Mapped_Index;
		};

		//! Gets hardware buffer link from a meshbuffer (may create or update buffer)
		virtual SHWBufferLink *getBufferLink(const scene::IMeshBuffer* mb);

		//! updates hardware buffer if needed  (only some drivers can)
		virtual bool updateHardwareBuffer(SHWBufferLink *HWBuffer) noexcept {return false;}

		//! Draw hardware buffer (only some drivers can)
		virtual void drawHardwareBuffer(SHWBufferLink *HWBuffer) noexcept {}

		//! Delete hardware buffer
		virtual void deleteHardwareBuffer(SHWBufferLink *HWBuffer);

		//! Create hardware buffer from mesh (only some drivers can)
		virtual SHWBufferLink *createHardwareBuffer(const scene::IMeshBuffer* mb) noexcept {return nullptr;}

	public:
		//! Remove hardware buffer
		void removeHardwareBuffer(const scene::IMeshBuffer* mb) _IRR_OVERRIDE_;

		//! Remove all hardware buffers
		void removeAllHardwareBuffers() _IRR_OVERRIDE_;

		//! Update all hardware buffers, remove unused ones
		virtual void updateAllHardwareBuffers();

		//! is vbo recommended on this mesh?
		virtual bool isHardwareBufferRecommend(const scene::IMeshBuffer* mb);

		//! Create occlusion query.
		/** Use node for identification and mesh for occlusion test. */
		void addOcclusionQuery(scene::ISceneNode* node,
				const scene::IMesh* mesh=0) _IRR_OVERRIDE_;

		//! Remove occlusion query.
		void removeOcclusionQuery(scene::ISceneNode* node) _IRR_OVERRIDE_;

		//! Remove all occlusion queries.
		void removeAllOcclusionQueries() _IRR_OVERRIDE_;

		//! Run occlusion query. Draws mesh stored in query.
		/** If the mesh shall not be rendered visible, use
		overrideMaterial to disable the color and depth buffer. */
		void runOcclusionQuery(scene::ISceneNode* node, bool visible=false) _IRR_OVERRIDE_;

		//! Run all occlusion queries. Draws all meshes stored in queries.
		/** If the meshes shall not be rendered visible, use
		overrideMaterial to disable the color and depth buffer. */
		void runAllOcclusionQueries(bool visible=false) _IRR_OVERRIDE_;

		//! Update occlusion query. Retrieves results from GPU.
		/** If the query shall not block, set the flag to false.
		Update might not occur in this case, though */
		void updateOcclusionQuery(scene::ISceneNode* node, bool block=true) _IRR_OVERRIDE_;

		//! Update all occlusion queries. Retrieves results from GPU.
		/** If the query shall not block, set the flag to false.
		Update might not occur in this case, though */
		void updateAllOcclusionQueries(bool block=true) _IRR_OVERRIDE_;

		//! Return query result.
		/** Return value is the number of visible pixels/fragments.
		The value is a safe approximation, i.e. can be larger than the
		actual value of pixels. */
		u32 getOcclusionQueryResult(scene::ISceneNode* node) const _IRR_OVERRIDE_;

		//! Create render target.
		IRenderTarget* addRenderTarget() _IRR_OVERRIDE_;

		//! Remove render target.
		void removeRenderTarget(IRenderTarget* renderTarget) _IRR_OVERRIDE_;

		//! Remove all render targets.
		void removeAllRenderTargets() _IRR_OVERRIDE_;

		//! Only used by the engine internally.
		/** Used to notify the driver that the window was resized. */
		void OnResize(const core::dimension2d<u32>& size) _IRR_OVERRIDE_;

		//! Adds a new material renderer to the video device.
		s32 addMaterialRenderer(IMaterialRenderer* renderer,
				const char* name = 0) _IRR_OVERRIDE_;

		//! Returns driver and operating system specific data about the IVideoDriver.
		const SExposedVideoData& getExposedVideoData() _IRR_OVERRIDE_;

		//! Returns type of video driver
		E_DRIVER_TYPE getDriverType() const _IRR_OVERRIDE_;

		//! Returns the transformation set by setTransform
		const core::matrix4& getTransform(E_TRANSFORMATION_STATE state) const _IRR_OVERRIDE_;

		//! Returns pointer to the IGPUProgrammingServices interface.
		IGPUProgrammingServices* getGPUProgrammingServices() _IRR_OVERRIDE_;

		//! Adds a new material renderer to the VideoDriver, using pixel and/or
		//! vertex shaders to render geometry.
		s32 addShaderMaterial(const c8* vertexShaderProgram = 0,
			const c8* pixelShaderProgram = 0,
			IShaderConstantSetCallBack* callback = 0,
			E_MATERIAL_TYPE baseMaterial = video::EMT_SOLID,
			s32 userData=0) _IRR_OVERRIDE_;

		//! Like IGPUProgrammingServices::addShaderMaterial(), but tries to load the
		//! programs from files.
		s32 addShaderMaterialFromFiles(io::IReadFile* vertexShaderProgram = 0,
			io::IReadFile* pixelShaderProgram = 0,
			IShaderConstantSetCallBack* callback = 0,
			E_MATERIAL_TYPE baseMaterial = video::EMT_SOLID,
			s32 userData=0) _IRR_OVERRIDE_;

		//! Like IGPUProgrammingServices::addShaderMaterial(), but tries to load the
		//! programs from files.
		s32 addShaderMaterialFromFiles(const io::path& vertexShaderProgramFileName,
			const io::path& pixelShaderProgramFileName,
			IShaderConstantSetCallBack* callback = 0,
			E_MATERIAL_TYPE baseMaterial = video::EMT_SOLID,
			s32 userData=0) _IRR_OVERRIDE_;

		//! Returns pointer to material renderer or null
		IMaterialRenderer* getMaterialRenderer(u32 idx) _IRR_OVERRIDE_;

		//! Returns amount of currently available material renderers.
		u32 getMaterialRendererCount() const _IRR_OVERRIDE_;

		//! Returns name of the material renderer
		const char* getMaterialRendererName(u32 idx) const _IRR_OVERRIDE_;

		//! Adds a new material renderer to the VideoDriver, based on a high level shading
		//! language. Currently only HLSL in D3D9 is supported.
		s32 addHighLevelShaderMaterial(
			const c8* vertexShaderProgram,
			const c8* vertexShaderEntryPointName = 0,
			E_VERTEX_SHADER_TYPE vsCompileTarget = EVST_VS_1_1,
			const c8* pixelShaderProgram = 0,
			const c8* pixelShaderEntryPointName = 0,
			E_PIXEL_SHADER_TYPE psCompileTarget = EPST_PS_1_1,
			const c8* geometryShaderProgram = 0,
			const c8* geometryShaderEntryPointName = "main",
			E_GEOMETRY_SHADER_TYPE gsCompileTarget = EGST_GS_4_0,
			scene::E_PRIMITIVE_TYPE inType = scene::EPT_TRIANGLES,
			scene::E_PRIMITIVE_TYPE outType = scene::EPT_TRIANGLE_STRIP,
			u32 verticesOut = 0,
			IShaderConstantSetCallBack* callback = 0,
			E_MATERIAL_TYPE baseMaterial = video::EMT_SOLID,
			s32 userData = 0, E_GPU_SHADING_LANGUAGE shadingLang = EGSL_DEFAULT) _IRR_OVERRIDE_;

		//! Like IGPUProgrammingServices::addShaderMaterial() (look there for a detailed description),
		//! but tries to load the programs from files.
		s32 addHighLevelShaderMaterialFromFiles(
			const io::path& vertexShaderProgramFile,
			const c8* vertexShaderEntryPointName = "main",
			E_VERTEX_SHADER_TYPE vsCompileTarget = EVST_VS_1_1,
			const io::path& pixelShaderProgramFile = "",
			const c8* pixelShaderEntryPointName = "main",
			E_PIXEL_SHADER_TYPE psCompileTarget = EPST_PS_1_1,
			const io::path& geometryShaderProgramFileName="",
			const c8* geometryShaderEntryPointName = "main",
			E_GEOMETRY_SHADER_TYPE gsCompileTarget = EGST_GS_4_0,
			scene::E_PRIMITIVE_TYPE inType = scene::EPT_TRIANGLES,
			scene::E_PRIMITIVE_TYPE outType = scene::EPT_TRIANGLE_STRIP,
			u32 verticesOut = 0,
			IShaderConstantSetCallBack* callback = 0,
			E_MATERIAL_TYPE baseMaterial = video::EMT_SOLID,
			s32 userData = 0, E_GPU_SHADING_LANGUAGE shadingLang = EGSL_DEFAULT) _IRR_OVERRIDE_;

		//! Like IGPUProgrammingServices::addShaderMaterial() (look there for a detailed description),
		//! but tries to load the programs from files.
		s32 addHighLevelShaderMaterialFromFiles(
			io::IReadFile* vertexShaderProgram,
			const c8* vertexShaderEntryPointName = "main",
			E_VERTEX_SHADER_TYPE vsCompileTarget = EVST_VS_1_1,
			io::IReadFile* pixelShaderProgram = 0,
			const c8* pixelShaderEntryPointName = "main",
			E_PIXEL_SHADER_TYPE psCompileTarget = EPST_PS_1_1,
			io::IReadFile* geometryShaderProgram= 0,
			const c8* geometryShaderEntryPointName = "main",
			E_GEOMETRY_SHADER_TYPE gsCompileTarget = EGST_GS_4_0,
			scene::E_PRIMITIVE_TYPE inType = scene::EPT_TRIANGLES,
			scene::E_PRIMITIVE_TYPE outType = scene::EPT_TRIANGLE_STRIP,
			u32 verticesOut = 0,
			IShaderConstantSetCallBack* callback = 0,
			E_MATERIAL_TYPE baseMaterial = video::EMT_SOLID,
			s32 userData = 0, E_GPU_SHADING_LANGUAGE shadingLang = EGSL_DEFAULT) _IRR_OVERRIDE_;

		//! Returns a pointer to the mesh manipulator.
		scene::IMeshManipulator* getMeshManipulator() _IRR_OVERRIDE_;

		void clearBuffers(u16 flag, SColor color = SColor(255,0,0,0), f32 depth = 1.f, u8 stencil = 0) _IRR_OVERRIDE_;

		//! Returns an image created from the last rendered frame.
		IImage* createScreenShot(video::ECOLOR_FORMAT format=video::ECF_UNKNOWN, video::E_RENDER_TARGET target=video::ERT_FRAME_BUFFER) _IRR_OVERRIDE_;

		//! Writes the provided image to disk file
		bool writeImageToFile(IImage* image, const io::path& filename, u32 param = 0) _IRR_OVERRIDE_;

		//! Writes the provided image to a file.
		bool writeImageToFile(IImage* image, io::IWriteFile * file, u32 param = 0) _IRR_OVERRIDE_;

		//! Sets the name of a material renderer.
		void setMaterialRendererName(s32 idx, const char* name) _IRR_OVERRIDE_;

		//! Swap the material renderers used for certain id's
		void swapMaterialRenderers(u32 idx1, u32 idx2, bool swapNames) _IRR_OVERRIDE_;

		//! Creates material attributes list from a material, usable for serialization and more.
		io::IAttributes* createAttributesFromMaterial(const video::SMaterial& material,
			io::SAttributeReadWriteOptions* options=0) _IRR_OVERRIDE_;

		//! Fills an SMaterial structure from attributes.
		void fillMaterialStructureFromAttributes(video::SMaterial& outMaterial, io::IAttributes* attributes) _IRR_OVERRIDE_;

		//! looks if the image is already loaded
		video::ITexture* findTexture(const io::path& filename) _IRR_OVERRIDE_;

		//! Set/unset a clipping plane.
		//! There are at least 6 clipping planes available for the user to set at will.
		//! \param index: The plane index. Must be between 0 and MaxUserClipPlanes.
		//! \param plane: The plane itself.
		//! \param enable: If true, enable the clipping plane else disable it.
		bool setClipPlane(u32 index, const core::plane3df& plane, bool enable=false) _IRR_OVERRIDE_;

		//! Enable/disable a clipping plane.
		//! There are at least 6 clipping planes available for the user to set at will.
		//! \param index: The plane index. Must be between 0 and MaxUserClipPlanes.
		//! \param enable: If true, enable the clipping plane else disable it.
		void enableClipPlane(u32 index, bool enable) _IRR_OVERRIDE_;

		//! Returns the graphics card vendor name.
		core::stringc getVendorInfo() _IRR_OVERRIDE_ {return "Not available on this driver.";}

		//! Set the minimum number of vertices for which a hw buffer will be created
		/** \param count Number of vertices to set as minimum. */
		void setMinHardwareBufferVertexCount(u32 count) _IRR_OVERRIDE_;

		//! Get the global Material, which might override local materials.
		/** Depending on the enable flags, values from this Material
		are used to override those of local materials of some
		meshbuffer being rendered. */
		SOverrideMaterial& getOverrideMaterial() _IRR_OVERRIDE_;

		//! Get the 2d override material for altering its values
		SMaterial& getMaterial2D() _IRR_OVERRIDE_;

		//! Enable the 2d override material
		void enableMaterial2D(bool enable=true) _IRR_OVERRIDE_;

		//! Only used by the engine internally.
		void setAllowZWriteOnTransparent(bool flag) noexcept  _IRR_OVERRIDE_
		{ AllowZWriteOnTransparent=flag; }

		//! Returns the maximum texture size supported.
		core::dimension2du getMaxTextureSize() const _IRR_OVERRIDE_;

		//! Color conversion convenience function
		/** Convert an image (as array of pixels) from source to destination
		array, thereby converting the color format. The pixel size is
		determined by the color formats.
		\param sP Pointer to source
		\param sF Color format of source
		\param sN Number of pixels to convert, both array must be large enough
		\param dP Pointer to destination
		\param dF Color format of destination
		*/
		void convertColor(const void* sP, ECOLOR_FORMAT sF, s32 sN,
				void* dP, ECOLOR_FORMAT dF) const _IRR_OVERRIDE_;

		//! deprecated method
		virtual ITexture* createRenderTargetTexture(const core::dimension2d<u32>& size,
				const c8* name=0);

		bool checkDriverReset() noexcept _IRR_OVERRIDE_ {return false;}
	protected:

		//! deletes all textures
		void deleteAllTextures();

		//! opens the file and loads it into the surface
		video::ITexture* loadTextureFromFile(io::IReadFile* file, const io::path& hashName = "");

		//! adds a surface, not loaded or created by the Irrlicht Engine
		void addTexture(video::ITexture* surface);

		virtual ITexture* createDeviceDependentTexture(const io::path& name, IImage* image);

		virtual ITexture* createDeviceDependentTextureCubemap(const io::path& name, const core::array<IImage*>& image);

		//! checks triangle count and print warning if wrong
		bool checkPrimitiveCount(u32 prmcnt) const;

		bool checkImage(const core::array<IImage*>& image) const;

		// adds a material renderer and drops it afterwards. To be used for internal creation
		s32 addAndDropMaterialRenderer(IMaterialRenderer* m);

		//! deletes all material renderers
		void deleteMaterialRenders();

		// prints renderer version
		void printVersion();

		//! normal map lookup 32 bit version
		inline f32 nml32(int x, int y, int pitch, int height, const s32 *p) const
		{
			if (x < 0)
				x = pitch-1;
			if (x >= pitch)
				x = 0;
			if (y < 0)
				y = height-1;
			if (y >= height)
				y = 0;
			return (f32)(((p[(y * pitch) + x])>>16) & 0xff);
		}

		//! normal map lookup 16 bit version
		inline f32 nml16(int x, int y, int pitch, int height, const s16 *p) const
		{
			if (x < 0)
				x = pitch-1;
			if (x >= pitch)
				x = 0;
			if (y < 0)
				y = height-1;
			if (y >= height)
				y = 0;

			return (f32) getAverage ( p[(y * pitch) + x] );
		}

		inline bool getWriteZBuffer(const SMaterial&material) const
		{
			if (material.ZWriteEnable)
			{
				if (!AllowZWriteOnTransparent)
				{
					switch (material.ZWriteFineControl)
					{
					case EZI_ONLY_NON_TRANSPARENT:
						return !material.isTransparent();
					case EZI_ZBUFFER_FLAG:
						return true;
					}
				}
				else
					return true;
			}
			return false;
		}

		struct SSurface
		{
			video::ITexture* Surface;

			bool operator < (const SSurface& other) const
			{
				return Surface->getName() < other.Surface->getName();
			}
		};

		struct SMaterialRenderer
		{
			core::stringc Name;
			IMaterialRenderer* Renderer;
		};

		struct SDummyTexture : public ITexture
		{
			SDummyTexture(const io::path& name, E_TEXTURE_TYPE type) : ITexture(name, type) {};

			void* lock(E_TEXTURE_LOCK_MODE mode = ETLM_READ_WRITE, u32 mipmapLevel=0, u32 layer = 0, E_TEXTURE_LOCK_FLAGS lockFlags = ETLF_FLIP_Y_UP_RTT) noexcept _IRR_OVERRIDE_ { return 0; }
			void unlock() noexcept _IRR_OVERRIDE_ {}
			void regenerateMipMapLevels(void* data = nullptr, u32 layer = 0) noexcept _IRR_OVERRIDE_ {}
		};
		core::array<SSurface> Textures;

		struct SOccQuery
		{
			SOccQuery(scene::ISceneNode* node, const scene::IMesh* mesh=nullptr) : Node(node), Mesh(mesh), PID(0), Result(0xffffffff), Run(0xffffffff)
			{
				if (Node)
					Node->grab();
				if (Mesh)
					Mesh->grab();
			}

			SOccQuery(const SOccQuery& other) : Node(other.Node), Mesh(other.Mesh), PID(other.PID), Result(other.Result), Run(other.Run)
			{
				if (Node)
					Node->grab();
				if (Mesh)
					Mesh->grab();
			}

			~SOccQuery()
			{
				if (Node)
					Node->drop();
				if (Mesh)
					Mesh->drop();
			}

			SOccQuery& operator=(const SOccQuery& other)
			{
				Node=other.Node;
				Mesh=other.Mesh;
				PID=other.PID;
				Result=other.Result;
				Run=other.Run;
				if (Node)
					Node->grab();
				if (Mesh)
					Mesh->grab();
				return *this;
			}

			bool operator==(const SOccQuery& other) const noexcept
			{
				return other.Node==Node;
			}

			scene::ISceneNode* Node;
			const scene::IMesh* Mesh;
			union
			{
				void* PID;
				unsigned int UID;
			};
			u32 Result;
			u32 Run;
		};
		core::array<SOccQuery> OcclusionQueries;

		core::array<IRenderTarget*> RenderTargets;

		// Shared objects used with simplified IVideoDriver::setRenderTarget method with ITexture* param.
		IRenderTarget* SharedRenderTarget;
		core::array<ITexture*> SharedDepthTextures;

		IRenderTarget* CurrentRenderTarget;
		core::dimension2d<u32> CurrentRenderTargetSize;

		core::array<video::IImageLoader*> SurfaceLoader;
		core::array<video::IImageWriter*> SurfaceWriter;
		core::array<SLight> Lights;
		core::array<SMaterialRenderer> MaterialRenderers;

		//core::array<SHWBufferLink*> HWBufferLinks;
		core::map< const scene::IMeshBuffer* , SHWBufferLink* > HWBufferMap;

		io::IFileSystem* FileSystem;

		//! mesh manipulator
		scene::IMeshManipulator* MeshManipulator;

		core::rect<s32> ViewPort;
		core::dimension2d<u32> ScreenSize;
		core::matrix4 TransformationMatrix;

		CFPSCounter FPSCounter;

		u32 PrimitivesDrawn;
		u32 MinVertexCountForVBO;

		u32 TextureCreationFlags;

		f32 FogStart;
		f32 FogEnd;
		f32 FogDensity;
		SColor FogColor;
		SExposedVideoData ExposedData;

		io::IAttributes* DriverAttributes;

		SOverrideMaterial OverrideMaterial;
		SMaterial OverrideMaterial2D;
		SMaterial InitMaterial2D;
		bool OverrideMaterial2DEnabled;

		E_FOG_TYPE FogType;
		bool PixelFog;
		bool RangeFog;
		bool AllowZWriteOnTransparent;

		bool FeatureEnabled[video::EVDF_COUNT];
	};

} // end namespace video
} // end namespace irr


#endif

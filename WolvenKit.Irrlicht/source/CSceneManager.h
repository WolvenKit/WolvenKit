// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_SCENE_MANAGER_H_INCLUDED__
#define __C_SCENE_MANAGER_H_INCLUDED__

#include "ISceneManager.h"
#include "ISceneNode.h"
#include "ICursorControl.h"
#include "irrString.h"
#include "irrArray.h"
#include "IMeshLoader.h"
#include "CAttributes.h"
#include "ILightManager.h"

namespace irr
{
namespace io
{
	class IFileSystem;
}
namespace scene
{
	class IMeshCache;
	class IGeometryCreator;

	/*!
		The Scene Manager manages scene nodes, mesh resources, cameras and all the other stuff.
	*/
	class CSceneManager : public ISceneManager, public ISceneNode
	{
	public:

		//! constructor
		CSceneManager(video::IVideoDriver* driver, io::IFileSystem* fs,
			gui::ICursorControl* cursorControl, IMeshCache* cache = 0,
			gui::IGUIEnvironment *guiEnvironment = 0);

		//! destructor
		virtual ~CSceneManager();

		//! gets an animateable mesh. loads it if needed. returned pointer must not be dropped.
		virtual IAnimatedMesh* getMesh(const io::path& filename, const io::path& alternativeCacheName) _IRR_OVERRIDE_;

		//! gets an animateable mesh. loads it if needed. returned pointer must not be dropped.
		virtual IAnimatedMesh* getMesh(io::IReadFile* file) _IRR_OVERRIDE_;

		//! Returns an interface to the mesh cache which is shared between all existing scene managers.
		virtual IMeshCache* getMeshCache() _IRR_OVERRIDE_;

		//! returns the video driver
		virtual video::IVideoDriver* getVideoDriver() _IRR_OVERRIDE_;

		//! return the gui environment
		virtual gui::IGUIEnvironment* getGUIEnvironment() _IRR_OVERRIDE_;

		//! return the filesystem
		virtual io::IFileSystem* getFileSystem() _IRR_OVERRIDE_;

		//! adds Volume Lighting Scene Node.
		//! the returned pointer must not be dropped.
		virtual IVolumeLightSceneNode* addVolumeLightSceneNode(ISceneNode* parent=0, s32 id=-1,
			const u32 subdivU = 32, const u32 subdivV = 32,
			const video::SColor foot = video::SColor(51, 0, 230, 180),
			const video::SColor tail = video::SColor(0, 0, 0, 0),
			const core::vector3df& position = core::vector3df(0,0,0),
			const core::vector3df& rotation = core::vector3df(0,0,0),
			const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f)) _IRR_OVERRIDE_;

		//! adds a cube scene node to the scene. It is a simple cube of (1,1,1) size.
		//! the returned pointer must not be dropped.
		virtual IMeshSceneNode* addCubeSceneNode(f32 size=10.0f, ISceneNode* parent=0, s32 id=-1,
			const core::vector3df& position = core::vector3df(0,0,0),
			const core::vector3df& rotation = core::vector3df(0,0,0),
			const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f)) _IRR_OVERRIDE_;

		//! Adds a sphere scene node to the scene.
		virtual IMeshSceneNode* addSphereSceneNode(f32 radius=5.0f, s32 polyCount=16, ISceneNode* parent=0, s32 id=-1,
			const core::vector3df& position = core::vector3df(0,0,0),
			const core::vector3df& rotation = core::vector3df(0,0,0),
			const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f)) _IRR_OVERRIDE_;

		//! adds a scene node for rendering an animated mesh model
		virtual IAnimatedMeshSceneNode* addAnimatedMeshSceneNode(IAnimatedMesh* mesh, ISceneNode* parent=0, s32 id=-1,
			const core::vector3df& position = core::vector3df(0,0,0),
			const core::vector3df& rotation = core::vector3df(0,0,0),
			const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f),
			bool alsoAddIfMeshPointerZero=false) _IRR_OVERRIDE_;

		//! adds a scene node for rendering a static mesh
		//! the returned pointer must not be dropped.
		virtual IMeshSceneNode* addMeshSceneNode(IMesh* mesh, ISceneNode* parent=0, s32 id=-1,
			const core::vector3df& position = core::vector3df(0,0,0),
			const core::vector3df& rotation = core::vector3df(0,0,0),
			const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f),
			bool alsoAddIfMeshPointerZero=false) _IRR_OVERRIDE_;

		//! Adds a scene node for rendering a animated water surface mesh.
		virtual ISceneNode* addWaterSurfaceSceneNode(IMesh* mesh, f32 waveHeight, f32 waveSpeed, f32 wlength, ISceneNode* parent=0, s32 id=-1,
			const core::vector3df& position = core::vector3df(0,0,0),
			const core::vector3df& rotation = core::vector3df(0,0,0),
			const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f)) _IRR_OVERRIDE_;

		//! renders the node.
		virtual void render() _IRR_OVERRIDE_;

		//! returns the axis aligned bounding box of this node
		virtual const core::aabbox3d<f32>& getBoundingBox() const _IRR_OVERRIDE_;

		//! registers a node for rendering it at a specific time.
		virtual u32 registerNodeForRendering(ISceneNode* node, E_SCENE_NODE_RENDER_PASS pass = ESNRP_AUTOMATIC) _IRR_OVERRIDE_;

		//! Clear all nodes which are currently registered for rendering
		virtual void clearAllRegisteredNodesForRendering() _IRR_OVERRIDE_;

		//! draws all scene nodes
		virtual void drawAll() _IRR_OVERRIDE_;

		//! Adds a scene node for rendering using a octree to the scene graph. This a good method for rendering
		//! scenes with lots of geometry. The Octree is built on the fly from the mesh, much
		//! faster then a bsp tree.
		virtual IOctreeSceneNode* addOctreeSceneNode(IAnimatedMesh* mesh, ISceneNode* parent=0,
			s32 id=-1, s32 minimalPolysPerNode=512, bool alsoAddIfMeshPointerZero=false) _IRR_OVERRIDE_;

		//! Adss a scene node for rendering using a octree. This a good method for rendering
		//! scenes with lots of geometry. The Octree is built on the fly from the mesh, much
		//! faster then a bsp tree.
		virtual IOctreeSceneNode* addOctreeSceneNode(IMesh* mesh, ISceneNode* parent=0,
			s32 id=-1, s32 minimalPolysPerNode=128, bool alsoAddIfMeshPointerZero=false) _IRR_OVERRIDE_;

		//! Adds a camera scene node to the tree and sets it as active camera.
		//! \param position: Position of the space relative to its parent where the camera will be placed.
		//! \param lookat: Position where the camera will look at. Also known as target.
		//! \param parent: Parent scene node of the camera. Can be null. If the parent moves,
		//! the camera will move too.
		//! \return Pointer to interface to camera
		virtual ICameraSceneNode* addCameraSceneNode(ISceneNode* parent = 0,
			const core::vector3df& position = core::vector3df(0,0,0),
			const core::vector3df& lookat = core::vector3df(0,0,100),
			s32 id=-1, bool makeActive=true) _IRR_OVERRIDE_;

		//! Adds a camera scene node which is able to be controlle with the mouse similar
		//! like in the 3D Software Maya by Alias Wavefront.
		//! The returned pointer must not be dropped.
		virtual ICameraSceneNode* addCameraSceneNodeMaya(ISceneNode* parent=0,
			f32 rotateSpeed=-1500.f, f32 zoomSpeed=200.f,
			f32 translationSpeed=1500.f, s32 id=-1, f32 distance=70.f,
			bool makeActive=true) _IRR_OVERRIDE_;

		//! Adds a camera scene node which is able to be controled with the mouse and keys
		//! like in most first person shooters (FPS):
		virtual ICameraSceneNode* addCameraSceneNodeFPS(ISceneNode* parent = 0,
			f32 rotateSpeed = 100.0f, f32 moveSpeed = .5f, s32 id=-1,
			SKeyMap* keyMapArray=0, s32 keyMapSize=0,
			bool noVerticalMovement=false, f32 jumpSpeed = 0.f,
			bool invertMouseY=false, bool makeActive=true) _IRR_OVERRIDE_;

		//! Adds a dynamic light scene node. The light will cast dynamic light on all
		//! other scene nodes in the scene, which have the material flag video::MTF_LIGHTING
		//! turned on. (This is the default setting in most scene nodes).
		virtual ILightSceneNode* addLightSceneNode(ISceneNode* parent = 0,
			const core::vector3df& position = core::vector3df(0,0,0),
			video::SColorf color = video::SColorf(1.0f, 1.0f, 1.0f),
			f32 range=100.0f, s32 id=-1) _IRR_OVERRIDE_;

		//! Adds a billboard scene node to the scene. A billboard is like a 3d sprite: A 2d element,
		//! which always looks to the camera. It is usually used for things like explosions, fire,
		//! lensflares and things like that.
		virtual IBillboardSceneNode* addBillboardSceneNode(ISceneNode* parent = 0,
			const core::dimension2d<f32>& size = core::dimension2d<f32>(10.0f, 10.0f),
			const core::vector3df& position = core::vector3df(0,0,0), s32 id=-1,
			video::SColor shadeTop = 0xFFFFFFFF, video::SColor shadeBottom = 0xFFFFFFFF) _IRR_OVERRIDE_;

		//! Adds a skybox scene node. A skybox is a big cube with 6 textures on it and
		//! is drawn around the camera position.
		virtual ISceneNode* addSkyBoxSceneNode(video::ITexture* top, video::ITexture* bottom,
			video::ITexture* left, video::ITexture* right, video::ITexture* front,
			video::ITexture* back, ISceneNode* parent = 0, s32 id=-1) _IRR_OVERRIDE_;

		//! Adds a skydome scene node. A skydome is a large (half-) sphere with a
		//! panoramic texture on it and is drawn around the camera position.
		virtual ISceneNode* addSkyDomeSceneNode(video::ITexture* texture,
			u32 horiRes=16, u32 vertRes=8,
			f32 texturePercentage=0.9, f32 spherePercentage=2.0,f32 radius = 1000.f,
			ISceneNode* parent=0, s32 id=-1) _IRR_OVERRIDE_;

		//! Adds a text scene node, which is able to display
		//! 2d text at a position in three dimensional space
		virtual ITextSceneNode* addTextSceneNode(gui::IGUIFont* font, const wchar_t* text,
			video::SColor color=video::SColor(100,255,255,255),
			ISceneNode* parent = 0,	const core::vector3df& position = core::vector3df(0,0,0),
			s32 id=-1) _IRR_OVERRIDE_;

		//! Adds a text scene node, which uses billboards
		virtual IBillboardTextSceneNode* addBillboardTextSceneNode(gui::IGUIFont* font, const wchar_t* text,
			ISceneNode* parent = 0,
			const core::dimension2d<f32>& size = core::dimension2d<f32>(10.0f, 10.0f),
			const core::vector3df& position = core::vector3df(0,0,0), s32 id=-1,
			video::SColor colorTop = 0xFFFFFFFF, video::SColor colorBottom = 0xFFFFFFFF) _IRR_OVERRIDE_;

		//! Adds a scene node, which can render a quake3 shader
		virtual IMeshSceneNode* addQuake3SceneNode(const IMeshBuffer* meshBuffer, const quake3::IShader * shader,
			ISceneNode* parent=0, s32 id=-1) _IRR_OVERRIDE_;


		//! Adds a Hill Plane mesh to the mesh pool. The mesh is
		//! generated on the fly and looks like a plane with some hills
		//! on it. You can specify how many hills should be on the plane
		//! and how high they should be. Also you must specify a name
		//! for the mesh because the mesh is added to the mesh pool and
		//! can be retrieved back using ISceneManager::getMesh with the
		//! name as parameter.
		virtual IAnimatedMesh* addHillPlaneMesh(const io::path& name,
			const core::dimension2d<f32>& tileSize, const core::dimension2d<u32>& tileCount,
			video::SMaterial* material = 0,	f32 hillHeight = 0.0f,
			const core::dimension2d<f32>& countHills = core::dimension2d<f32>(1.0f, 1.0f),
			const core::dimension2d<f32>& textureRepeatCount = core::dimension2d<f32>(1.0f, 1.0f)) _IRR_OVERRIDE_;

		//! Adds a terrain mesh to the mesh pool.
		virtual IAnimatedMesh* addTerrainMesh(const io::path& meshname,	video::IImage* texture, video::IImage* heightmap,
			const core::dimension2d<f32>& stretchSize = core::dimension2d<f32>(10.0f,10.0f),
			f32 maxHeight=200.0f,
			const core::dimension2d<u32>& defaultVertexBlockSize = core::dimension2d<u32>(64,64)) _IRR_OVERRIDE_;

		//! Add a arrow mesh to the mesh pool
		virtual IAnimatedMesh* addArrowMesh(const io::path& name,
				video::SColor vtxColor0, video::SColor vtxColor1,
				u32 tesselationCylinder, u32 tesselationCone,
				f32 height, f32 cylinderHeight, f32 width0,
				f32 width1) _IRR_OVERRIDE_;

		//! Adds a static sphere mesh to the mesh pool.
		virtual IAnimatedMesh* addSphereMesh(const io::path& name,
				f32 radius=5.f, u32 polyCountX=16, u32 polyCountY=16) _IRR_OVERRIDE_;

		//! Adds a static volume light mesh to the mesh pool.
		virtual IAnimatedMesh* addVolumeLightMesh(const io::path& name,
			const u32 SubdivideU = 32, const u32 SubdivideV = 32,
			const video::SColor FootColor = video::SColor(51, 0, 230, 180),
			const video::SColor TailColor = video::SColor(0, 0, 0, 0)) _IRR_OVERRIDE_;

		//! Adds a particle system scene node.
		virtual IParticleSystemSceneNode* addParticleSystemSceneNode(
			bool withDefaultEmitter=true, ISceneNode* parent=0, s32 id=-1,
			const core::vector3df& position = core::vector3df(0,0,0),
			const core::vector3df& rotation = core::vector3df(0,0,0),
			const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f)) _IRR_OVERRIDE_;

		//! Adds a terrain scene node to the scene graph.
		virtual ITerrainSceneNode* addTerrainSceneNode(
			const io::path& heightMapFileName,
			ISceneNode* parent=0, s32 id=-1,
			const core::vector3df& position = core::vector3df(0.0f,0.0f,0.0f),
			const core::vector3df& rotation = core::vector3df(0.0f,0.0f,0.0f),
			const core::vector3df& scale = core::vector3df(1.0f,1.0f,1.0f),
			video::SColor vertexColor = video::SColor(255,255,255,255),
			s32 maxLOD=4, E_TERRAIN_PATCH_SIZE patchSize=ETPS_17,s32 smoothFactor=0,
			bool addAlsoIfHeightmapEmpty = false) _IRR_OVERRIDE_;

		//! Adds a terrain scene node to the scene graph.
		virtual ITerrainSceneNode* addTerrainSceneNode(
			io::IReadFile* heightMap,
			ISceneNode* parent=0, s32 id=-1,
			const core::vector3df& position = core::vector3df(0.0f,0.0f,0.0f),
			const core::vector3df& rotation = core::vector3df(0.0f,0.0f,0.0f),
			const core::vector3df& scale = core::vector3df(1.0f,1.0f,1.0f),
			video::SColor vertexColor = video::SColor(255,255,255,255),
			s32 maxLOD=4, E_TERRAIN_PATCH_SIZE patchSize=ETPS_17,s32 smoothFactor=0,
			bool addAlsoIfHeightmapEmpty=false) _IRR_OVERRIDE_;

		//! Adds a dummy transformation scene node to the scene graph.
		virtual IDummyTransformationSceneNode* addDummyTransformationSceneNode(
			ISceneNode* parent=0, s32 id=-1) _IRR_OVERRIDE_;

		//! Adds an empty scene node.
		virtual ISceneNode* addEmptySceneNode(ISceneNode* parent, s32 id=-1) _IRR_OVERRIDE_;

		//! Returns the root scene node. This is the scene node which is parent
		//! of all scene nodes. The root scene node is a special scene node which
		//! only exists to manage all scene nodes. It is not rendered and cannot
		//! be removed from the scene.
		//! \return Pointer to the root scene node.
		virtual ISceneNode* getRootSceneNode() _IRR_OVERRIDE_;

		//! Returns the current active camera.
		//! \return The active camera is returned. Note that this can be NULL, if there
		//! was no camera created yet.
		virtual ICameraSceneNode* getActiveCamera() const _IRR_OVERRIDE_;

		//! Sets the active camera. The previous active camera will be deactivated.
		//! \param camera: The new camera which should be active.
		virtual void setActiveCamera(ICameraSceneNode* camera) _IRR_OVERRIDE_;

		//! creates a rotation animator, which rotates the attached scene node around itself.
		//! \param rotationPerSecond: Specifies the speed of the animation
		//! \return The animator. Attach it to a scene node with ISceneNode::addAnimator()
		//! and the animator will animate it.
		virtual ISceneNodeAnimator* createRotationAnimator(const core::vector3df& rotationPerSecond) _IRR_OVERRIDE_;

		//! creates a fly circle animator
		/** Lets the attached scene node fly around a center.
		\param center Center relative to node origin
		\param speed: The orbital speed, in radians per millisecond.
		\param direction: Specifies the upvector used for alignment of the mesh.
		\param startPosition: The position on the circle where the animator will
		begin. Value is in multiples  of a circle, i.e. 0.5 is half way around.
		\return The animator. Attach it to a scene node with ISceneNode::addAnimator()
		*/
		virtual ISceneNodeAnimator* createFlyCircleAnimator(
				const core::vector3df& center=core::vector3df(0.f, 0.f, 0.f),
				f32 radius=100.f, f32 speed=0.001f,
				const core::vector3df& direction=core::vector3df(0.f, 1.f, 0.f),
				f32 startPosition = 0.f,
				f32 radiusEllipsoid = 0.f) _IRR_OVERRIDE_;

		//! Creates a fly straight animator, which lets the attached scene node
		//! fly or move along a line between two points.
		virtual ISceneNodeAnimator* createFlyStraightAnimator(const core::vector3df& startPoint,
			const core::vector3df& endPoint, u32 timeForWay, bool loop=false,bool pingpong = false) _IRR_OVERRIDE_;

		//! Creates a texture animator, which switches the textures of the target scene
		//! node based on a list of textures.
		virtual ISceneNodeAnimator* createTextureAnimator(const core::array<video::ITexture*>& textures,
			s32 timePerFrame, bool loop) _IRR_OVERRIDE_;

		//! Creates a scene node animator, which deletes the scene node after
		//! some time automatically.
		virtual ISceneNodeAnimator* createDeleteAnimator(u32 timeMS) _IRR_OVERRIDE_;


		//! Creates a special scene node animator for doing automatic collision detection
		//! and response.
		virtual ISceneNodeAnimatorCollisionResponse* createCollisionResponseAnimator(
			ITriangleSelector* world, ISceneNode* sceneNode,
			const core::vector3df& ellipsoidRadius = core::vector3df(30,60,30),
			const core::vector3df& gravityPerSecond = core::vector3df(0,-1.0f,0),
			const core::vector3df& ellipsoidTranslation = core::vector3df(0,0,0),
			f32 slidingValue = 0.0005f) _IRR_OVERRIDE_;

		//! Creates a follow spline animator.
		virtual ISceneNodeAnimator* createFollowSplineAnimator(s32 startTime,
			const core::array< core::vector3df >& points,
			f32 speed, f32 tightness, bool loop, bool pingpong) _IRR_OVERRIDE_;


		//! Creates a simple ITriangleSelector, based on a mesh.
		virtual ITriangleSelector* createTriangleSelector(IMesh* mesh, ISceneNode* node, bool separateMeshbuffers) _IRR_OVERRIDE_;

		//! Creates a simple ITriangleSelector, based on a meshbuffer.
		virtual ITriangleSelector* createTriangleSelector(const IMeshBuffer* meshBuffer, irr::u32 materialIndex, ISceneNode* node) _IRR_OVERRIDE_;

		//! Creates a simple ITriangleSelector, based on an animated mesh scene node.
		//! Details of the mesh associated with the node will be extracted internally.
		//! Call ITriangleSelector::update() to have the triangle selector updated based
		//! on the current frame of the animated mesh scene node.
		//! \param: The animated mesh scene node from which to build the selector
		virtual ITriangleSelector* createTriangleSelector(IAnimatedMeshSceneNode* node, bool separateMeshbuffers) _IRR_OVERRIDE_;

		//! Creates a simple ITriangleSelector, based on a mesh.
		virtual ITriangleSelector* createOctreeTriangleSelector(IMesh* mesh,
			ISceneNode* node, s32 minimalPolysPerNode) _IRR_OVERRIDE_;

		//! Creates a simple ITriangleSelector, based on a meshbuffer.
		virtual ITriangleSelector* createOctreeTriangleSelector(IMeshBuffer* meshBuffer, irr::u32 materialIndex,
			ISceneNode* node, s32 minimalPolysPerNode=32) _IRR_OVERRIDE_;

		//! Creates a simple dynamic ITriangleSelector, based on a axis aligned bounding box.
		virtual ITriangleSelector* createTriangleSelectorFromBoundingBox(
			ISceneNode* node) _IRR_OVERRIDE_;

		//! Creates a meta triangle selector.
		virtual IMetaTriangleSelector* createMetaTriangleSelector() _IRR_OVERRIDE_;

		//! Creates a triangle selector which can select triangles from a terrain scene node
		//! \param: Pointer to the created terrain scene node
		//! \param: Level of detail, 0 for highest detail.
		virtual ITriangleSelector* createTerrainTriangleSelector(
			ITerrainSceneNode* node, s32 LOD=0) _IRR_OVERRIDE_;

		//! Adds an external mesh loader.
		virtual void addExternalMeshLoader(IMeshLoader* externalLoader) _IRR_OVERRIDE_;

		//! Returns the number of mesh loaders supported by Irrlicht at this time
		virtual u32 getMeshLoaderCount() const _IRR_OVERRIDE_;

		//! Retrieve the given mesh loader
		virtual IMeshLoader* getMeshLoader(u32 index) const _IRR_OVERRIDE_;

		//! Adds an external scene loader.
		virtual void addExternalSceneLoader(ISceneLoader* externalLoader) _IRR_OVERRIDE_;

		//! Returns the number of scene loaders supported by Irrlicht at this time
		virtual u32 getSceneLoaderCount() const _IRR_OVERRIDE_;

		//! Retrieve the given scene loader
		virtual ISceneLoader* getSceneLoader(u32 index) const _IRR_OVERRIDE_;

		//! Returns a pointer to the scene collision manager.
		virtual ISceneCollisionManager* getSceneCollisionManager() _IRR_OVERRIDE_;

		//! Returns a pointer to the mesh manipulator.
		virtual IMeshManipulator* getMeshManipulator() _IRR_OVERRIDE_;

		//! Sets the color of stencil buffers shadows drawn by the scene manager.
		virtual void setShadowColor(video::SColor color) _IRR_OVERRIDE_;

		//! Returns the current color of shadows.
		virtual video::SColor getShadowColor() const _IRR_OVERRIDE_;

		//! Adds a scene node to the deletion queue.
		virtual void addToDeletionQueue(ISceneNode* node) _IRR_OVERRIDE_;

		//! Returns the first scene node with the specified id.
		virtual ISceneNode* getSceneNodeFromId(s32 id, ISceneNode* start=0) _IRR_OVERRIDE_;

		//! Returns the first scene node with the specified name.
		virtual ISceneNode* getSceneNodeFromName(const c8* name, ISceneNode* start=0) _IRR_OVERRIDE_;

		//! Returns the first scene node with the specified type.
		virtual ISceneNode* getSceneNodeFromType(scene::ESCENE_NODE_TYPE type, ISceneNode* start=0) _IRR_OVERRIDE_;

		//! returns scene nodes by type.
		virtual void getSceneNodesFromType(ESCENE_NODE_TYPE type, core::array<scene::ISceneNode*>& outNodes, ISceneNode* start=0) _IRR_OVERRIDE_;

		//! Posts an input event to the environment. Usually you do not have to
		//! use this method, it is used by the internal engine.
		virtual bool postEventFromUser(const SEvent& event) _IRR_OVERRIDE_;

		//! Clears the whole scene. All scene nodes are removed.
		virtual void clear() _IRR_OVERRIDE_;

		//! Removes all children of this scene node
		virtual void removeAll() _IRR_OVERRIDE_;

		//! Returns interface to the parameters set in this scene.
		virtual io::IAttributes* getParameters() _IRR_OVERRIDE_;

		//! Returns current render pass.
		virtual E_SCENE_NODE_RENDER_PASS getSceneNodeRenderPass() const _IRR_OVERRIDE_;

		//! Creates a new scene manager.
		virtual ISceneManager* createNewSceneManager(bool cloneContent) _IRR_OVERRIDE_;

		//! Returns type of the scene node
		virtual ESCENE_NODE_TYPE getType() const _IRR_OVERRIDE_ { return ESNT_SCENE_MANAGER; }

		//! Returns the default scene node factory which can create all built in scene nodes
		virtual ISceneNodeFactory* getDefaultSceneNodeFactory() _IRR_OVERRIDE_;

		//! Adds a scene node factory to the scene manager.
		/** Use this to extend the scene manager with new scene node types which it should be
		able to create automatically, for example when loading data from xml files. */
		virtual void registerSceneNodeFactory(ISceneNodeFactory* factoryToAdd) _IRR_OVERRIDE_;

		//! Returns amount of registered scene node factories.
		virtual u32 getRegisteredSceneNodeFactoryCount() const _IRR_OVERRIDE_;

		//! Returns a scene node factory by index
		virtual ISceneNodeFactory* getSceneNodeFactory(u32 index) _IRR_OVERRIDE_;

		//! Returns a typename from a scene node type or null if not found
		virtual const c8* getSceneNodeTypeName(ESCENE_NODE_TYPE type) _IRR_OVERRIDE_;

		//! Returns a typename from a scene node animator type or null if not found
		virtual const c8* getAnimatorTypeName(ESCENE_NODE_ANIMATOR_TYPE type) _IRR_OVERRIDE_;

		//! Adds a scene node to the scene by name
		virtual ISceneNode* addSceneNode(const char* sceneNodeTypeName, ISceneNode* parent=0) _IRR_OVERRIDE_;

		//! creates a scene node animator based on its type name
		virtual ISceneNodeAnimator* createSceneNodeAnimator(const char* typeName, ISceneNode* target=0) _IRR_OVERRIDE_;

		//! Returns the default scene node animator factory which can create all built-in scene node animators
		virtual ISceneNodeAnimatorFactory* getDefaultSceneNodeAnimatorFactory() _IRR_OVERRIDE_;

		//! Adds a scene node animator factory to the scene manager.
		virtual void registerSceneNodeAnimatorFactory(ISceneNodeAnimatorFactory* factoryToAdd) _IRR_OVERRIDE_;

		//! Returns amount of registered scene node animator factories.
		virtual u32 getRegisteredSceneNodeAnimatorFactoryCount() const _IRR_OVERRIDE_;

		//! Returns a scene node animator factory by index
		virtual ISceneNodeAnimatorFactory* getSceneNodeAnimatorFactory(u32 index) _IRR_OVERRIDE_;

		//! Saves the current scene into a file.
		virtual bool saveScene(const io::path& filename, ISceneUserDataSerializer* userDataSerializer=0, ISceneNode* node=0) _IRR_OVERRIDE_;

		//! Saves the current scene into a file.
		virtual bool saveScene(io::IWriteFile* file, ISceneUserDataSerializer* userDataSerializer=0, ISceneNode* node=0) _IRR_OVERRIDE_;

		//! Saves the current scene into a file.
		virtual bool saveScene(io::IXMLWriter* writer, const io::path& currentPath, ISceneUserDataSerializer* userDataSerializer=0, ISceneNode* node=0) _IRR_OVERRIDE_;

		//! Loads a scene. Note that the current scene is not cleared before.
		virtual bool loadScene(const io::path& filename, ISceneUserDataSerializer* userDataSerializer=0, ISceneNode* rootNode=0) _IRR_OVERRIDE_;

		//! Loads a scene. Note that the current scene is not cleared before.
		virtual bool loadScene(io::IReadFile* file, ISceneUserDataSerializer* userDataSerializer=0, ISceneNode* rootNode=0) _IRR_OVERRIDE_;

		//! Writes attributes of the scene node.
		virtual void serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options=0) const _IRR_OVERRIDE_;

		//! Reads attributes of the scene node.
		virtual void deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options=0) _IRR_OVERRIDE_;

		//! Returns a mesh writer implementation if available
		virtual IMeshWriter* createMeshWriter(EMESH_WRITER_TYPE type) _IRR_OVERRIDE_;

		//! Get a skinned mesh, which is not available as header-only code
		virtual ISkinnedMesh* createSkinnedMesh() _IRR_OVERRIDE_;

		//! Sets ambient color of the scene
		virtual void setAmbientLight(const video::SColorf &ambientColor) _IRR_OVERRIDE_;

		//! Returns ambient color of the scene
		virtual const video::SColorf& getAmbientLight() const _IRR_OVERRIDE_;

		//! Register a custom callbacks manager which gets callbacks during scene rendering.
		virtual void setLightManager(ILightManager* lightManager) _IRR_OVERRIDE_;

		//! Get current render time.
		virtual E_SCENE_NODE_RENDER_PASS getCurrentRenderPass() const _IRR_OVERRIDE_ { return CurrentRenderPass; }

		//! Set current render time.
		virtual void setCurrentRenderPass(E_SCENE_NODE_RENDER_PASS nextPass) _IRR_OVERRIDE_ { CurrentRenderPass = nextPass; }

		//! Get an instance of a geometry creator.
		virtual const IGeometryCreator* getGeometryCreator(void) const _IRR_OVERRIDE_ { return GeometryCreator; }

		//! returns if node is culled
		virtual bool isCulled(const ISceneNode* node) const _IRR_OVERRIDE_;

	private:

		// load and create a mesh which we know already isn't in the cache and put it in there
		IAnimatedMesh* getUncachedMesh(io::IReadFile* file, const io::path& filename, const io::path& cachename);

		//! clears the deletion list
		void clearDeletionList();

		//! writes a scene node
		void writeSceneNode(io::IXMLWriter* writer, ISceneNode* node, ISceneUserDataSerializer* userDataSerializer, const fschar_t* currentPath=0, bool init=false);

		struct DefaultNodeEntry
		{
			DefaultNodeEntry(ISceneNode* n) :
				Node(n), TextureValue(0)
			{
				if (n->getMaterialCount())
					TextureValue = (n->getMaterial(0).getTexture(0));
			}

			bool operator < (const DefaultNodeEntry& other) const
			{
				return (TextureValue < other.TextureValue);
			}

			ISceneNode* Node;
			private:
			void* TextureValue;
		};

		//! sort on distance (center) to camera
		struct TransparentNodeEntry
		{
			TransparentNodeEntry(ISceneNode* n, const core::vector3df& camera)
				: Node(n)
			{
				Distance = Node->getAbsoluteTransformation().getTranslation().getDistanceFromSQ(camera);
			}

			bool operator < (const TransparentNodeEntry& other) const
			{
				return Distance > other.Distance;
			}

			ISceneNode* Node;
			private:
				f64 Distance;
		};

		//! sort on distance (sphere) to camera
		struct DistanceNodeEntry
		{
			DistanceNodeEntry(ISceneNode* n, const core::vector3df& cameraPos)
				: Node(n)
			{
				setNodeAndDistanceFromPosition(n, cameraPos);
			}

			bool operator < (const DistanceNodeEntry& other) const
			{
				return Distance < other.Distance;
			}

			void setNodeAndDistanceFromPosition(ISceneNode* n, const core::vector3df & fromPosition)
			{
				Node = n;
				Distance = Node->getAbsoluteTransformation().getTranslation().getDistanceFromSQ(fromPosition);
				Distance -= Node->getBoundingBox().getExtent().getLengthSQ() * 0.5;
			}

			ISceneNode* Node;
			private:
			f64 Distance;
		};

		//! video driver
		video::IVideoDriver* Driver;

		//! file system
		io::IFileSystem* FileSystem;

		//! GUI Enviroment ( Debug Purpose )
		gui::IGUIEnvironment* GUIEnvironment;

		//! cursor control
		gui::ICursorControl* CursorControl;

		//! collision manager
		ISceneCollisionManager* CollisionManager;

		//! render pass lists
		core::array<ISceneNode*> CameraList;
		core::array<ISceneNode*> LightList;
		core::array<ISceneNode*> ShadowNodeList;
		core::array<ISceneNode*> SkyBoxList;
		core::array<DefaultNodeEntry> SolidNodeList;
		core::array<TransparentNodeEntry> TransparentNodeList;
		core::array<TransparentNodeEntry> TransparentEffectNodeList;

		core::array<IMeshLoader*> MeshLoaderList;
		core::array<ISceneLoader*> SceneLoaderList;
		core::array<ISceneNode*> DeletionList;
		core::array<ISceneNodeFactory*> SceneNodeFactoryList;
		core::array<ISceneNodeAnimatorFactory*> SceneNodeAnimatorFactoryList;

		//! current active camera
		ICameraSceneNode* ActiveCamera;
		core::vector3df camWorldPos; // Position of camera for transparent nodes.

		video::SColor ShadowColor;
		video::SColorf AmbientLight;

		//! String parameters
		// NOTE: Attributes are slow and should only be used for debug-info and not in release
		io::CAttributes* Parameters;

		//! Mesh cache
		IMeshCache* MeshCache;

		E_SCENE_NODE_RENDER_PASS CurrentRenderPass;

		//! An optional callbacks manager to allow the user app finer control
		//! over the scene lighting and rendering.
		ILightManager* LightManager;

		//! constants for reading and writing XML.
		//! Not made static due to portability problems.
		const core::stringw IRR_XML_FORMAT_SCENE;
		const core::stringw IRR_XML_FORMAT_NODE;
		const core::stringw IRR_XML_FORMAT_NODE_ATTR_TYPE;

		IGeometryCreator* GeometryCreator;
	};

} // end namespace video
} // end namespace scene

#endif


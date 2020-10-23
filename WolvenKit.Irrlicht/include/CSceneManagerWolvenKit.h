#ifndef __C_SCENE_MANAGER_WOLVENKIT_H_INCLUDED__
#define __C_SCENE_MANAGER_WOLVENKIT_H_INCLUDED__

#include "ISceneManager.h"
#include "ISceneNode.h"
#include "ICursorControl.h"
#include "irrString.h"
#include "irrArray.h"
#include "IMeshLoader.h"

//#include "Janua/JanuaRuntime/JanuaRuntime.h"

namespace irr
{
namespace io
{
	class IFileSystem;
	class CAttributes;
}
namespace scene
{
	/*!
		The Scene Manager manages scene nodes, mesh resources, cameras and all the other stuff.
	*/
	class CSceneManagerWolvenKit : public ISceneManager, public ISceneNode
	{
	public:

		//! constructor
		CSceneManagerWolvenKit(video::IVideoDriver* driver, io::IFileSystem* fs,
            gui::ICursorControl* cursorControl);

		//! destructor
		~CSceneManagerWolvenKit();

		IAnimatedMesh* getMesh(const io::path& filename, const io::path& alternativeCacheName) _IRR_OVERRIDE_;
        IMesh* getStaticMesh(const io::path& filename) _IRR_OVERRIDE_;

		//! adds a scene node for rendering a static mesh
		//! the returned pointer must not be dropped.
		IMeshSceneNode* addMeshSceneNode(IMesh* mesh, ISceneNode* parent=0, s32 id=-1,
			const core::vector3df& position = core::vector3df(0,0,0),
            const core::vector3df& rotation = core::vector3df(0, 0, 0),
            const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f),
            bool alsoAddIfMeshPointerZero = false) _IRR_OVERRIDE_;

		//! Adds a scene node for rendering a animated water surface mesh.
		ISceneNode* addWaterSurfaceSceneNode(IMesh* mesh, f32 waveHeight, f32 waveSpeed, f32 wlength, ISceneNode* parent=0, s32 id=-1,
			const core::vector3df& position = core::vector3df(0,0,0),
			const core::vector3df& rotation = core::vector3df(0,0,0),
			const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f)) _IRR_OVERRIDE_;

        //! Adds a camera scene node which is able to be control with the mouse similar
		//! like in the 3D Software Maya by Alias Wavefront.
		//! The returned pointer must not be dropped.
        ICameraSceneNode* addCameraSceneNodeWolvenKit(ISceneNode* parent = 0,
            f32 rotateSpeed = -1500.f, f32 zoomSpeed = 200.f,
            f32 translationSpeed = 100.f, s32 id = -1, f32 distance = 70.f,
            bool makeActive = true) _IRR_OVERRIDE_;

		//! Adds a skydome scene node. A skydome is a large (half-) sphere with a
		//! panoramic texture on it and is drawn around the camera position.
		ISceneNode* addSkyDomeSceneNode(video::ITexture* texture,
			u32 horiRes=16, u32 vertRes=8,
			f32 texturePercentage=0.9, f32 spherePercentage=2.0,f32 radius = 1000.f,
			ISceneNode* parent=0, s32 id=-1) _IRR_OVERRIDE_;

		ITerrainSceneNodeWolvenKit* addTerrainSceneNodeWolvenKit(
			const io::path& heightMapFileName,
            ISceneNode* parent, s32 id,
            s32 dimension, f32 maxHeight, f32 minHeight, f32 tileSize,
			const core::vector3df& anchor) _IRR_OVERRIDE_;

        ILightSceneNode* addLightSceneNode(ISceneNode* parent = 0,
            const core::vector3df& position = core::vector3df(0, 0, 0),
            video::SColorf color = video::SColorf(1.0f, 1.0f, 1.0f),
            f32 range = 100.0f, s32 id = -1) _IRR_OVERRIDE_;

		//! Adds an empty scene node.
		ISceneNode* addEmptySceneNode(ISceneNode* parent, s32 id=-1) _IRR_OVERRIDE_;

		//! Returns the current active camera.
		//! \return The active camera is returned. Note that this can be NULL, if there
		//! was no camera created yet.
		ICameraSceneNode* getActiveCamera() const _IRR_OVERRIDE_;

		//! Sets the active camera. The previous active camera will be deactivated.
		//! \param camera: The new camera which should be active.
		void setActiveCamera(ICameraSceneNode* camera) _IRR_OVERRIDE_;

		//! Returns a mesh writer implementation if available
		IMeshWriter* createMeshWriter(EMESH_WRITER_TYPE type) _IRR_OVERRIDE_;

        void SelectNode(ISceneNode* node) _IRR_OVERRIDE_;
        void DeselectNode() _IRR_OVERRIDE_;

		//! draws all scene nodes
		void drawAll() _IRR_OVERRIDE_;
		
		IMeshManipulator* getMeshManipulator() _IRR_OVERRIDE_;

		//! Posts an input event to the environment. Usually you do not have to
		//! use this method, it is used by the internal engine.
		bool postEventFromUser(const SEvent& event) _IRR_OVERRIDE_;

		video::IVideoDriver* getVideoDriver() _IRR_OVERRIDE_;
        io::IFileSystem* getFileSystem() _IRR_OVERRIDE_;

        //! Get a skinned mesh, which is not available as header-only code
        ISkinnedMesh* createSkinnedMesh() _IRR_OVERRIDE_;

        //! Returns interface to the parameters set in this scene.
        io::IAttributes* getParameters() _IRR_OVERRIDE_;

        // for ISceneNode interface
        void render() _IRR_OVERRIDE_ {}
        const core::aabbox3d<f32>& getBoundingBox() const _IRR_OVERRIDE_;

		// unused bloat functions
		IAnimatedMesh* getMesh(io::IReadFile* file) _IRR_OVERRIDE_;
		IMeshCache* getMeshCache() _IRR_OVERRIDE_;
		gui::IGUIEnvironment* getGUIEnvironment() _IRR_OVERRIDE_;
        IVolumeLightSceneNode* addVolumeLightSceneNode(ISceneNode* parent = 0, s32 id = -1,
            const u32 subdivU = 32, const u32 subdivV = 32,
            const video::SColor foot = video::SColor(51, 0, 230, 180),
            const video::SColor tail = video::SColor(0, 0, 0, 0),
            const core::vector3df& position = core::vector3df(0, 0, 0),
            const core::vector3df& rotation = core::vector3df(0, 0, 0),
            const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f)) _IRR_OVERRIDE_;
        IMeshSceneNode* addCubeSceneNode(f32 size = 10.0f, ISceneNode* parent = 0, s32 id = -1,
            const core::vector3df& position = core::vector3df(0, 0, 0),
            const core::vector3df& rotation = core::vector3df(0, 0, 0),
            const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f)) _IRR_OVERRIDE_;
        IMeshSceneNode* addSphereSceneNode(f32 radius = 5.0f, s32 polyCount = 16, ISceneNode* parent = 0, s32 id = -1,
            const core::vector3df& position = core::vector3df(0, 0, 0),
            const core::vector3df& rotation = core::vector3df(0, 0, 0),
            const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f)) _IRR_OVERRIDE_;
        IAnimatedMeshSceneNode* addAnimatedMeshSceneNode(IAnimatedMesh* mesh, ISceneNode* parent = 0, s32 id = -1,
            const core::vector3df& position = core::vector3df(0, 0, 0),
            const core::vector3df& rotation = core::vector3df(0, 0, 0),
            const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f),
            bool alsoAddIfMeshPointerZero = false) _IRR_OVERRIDE_;
        IOctreeSceneNode* addOctreeSceneNode(IAnimatedMesh* mesh, ISceneNode* parent = 0,
            s32 id = -1, s32 minimalPolysPerNode = 512, bool alsoAddIfMeshPointerZero = false) _IRR_OVERRIDE_;
        IOctreeSceneNode* addOctreeSceneNode(IMesh* mesh, ISceneNode* parent = 0,
            s32 id = -1, s32 minimalPolysPerNode = 128, bool alsoAddIfMeshPointerZero = false) _IRR_OVERRIDE_;
        ICameraSceneNode* addCameraSceneNode(ISceneNode* parent = 0,
            const core::vector3df& position = core::vector3df(0, 0, 0),
            const core::vector3df& lookat = core::vector3df(0, 0, 100),
            s32 id = -1, bool makeActive = true) _IRR_OVERRIDE_;
        ICameraSceneNode* addCameraSceneNodeMaya(ISceneNode* parent = 0,
            f32 rotateSpeed = -1500.f, f32 zoomSpeed = 200.f,
            f32 translationSpeed = 1500.f, s32 id = -1, f32 distance = 70.f,
            bool makeActive = true) _IRR_OVERRIDE_;
        ICameraSceneNode* addCameraSceneNodeFPS(ISceneNode* parent = 0,
            f32 rotateSpeed = 100.0f, f32 moveSpeed = .5f, s32 id = -1,
            SKeyMap* keyMapArray = 0, s32 keyMapSize = 0,
            bool noVerticalMovement = false, f32 jumpSpeed = 0.f,
            bool invertMouseY = false, bool makeActive = true) _IRR_OVERRIDE_;
        IBillboardSceneNode* addBillboardSceneNode(ISceneNode* parent = 0,
            const core::dimension2d<f32>& size = core::dimension2d<f32>(10.0f, 10.0f),
            const core::vector3df& position = core::vector3df(0, 0, 0), s32 id = -1,
            video::SColor shadeTop = 0xFFFFFFFF, video::SColor shadeBottom = 0xFFFFFFFF) _IRR_OVERRIDE_;
        ISceneNode* addSkyBoxSceneNode(video::ITexture* top, video::ITexture* bottom,
            video::ITexture* left, video::ITexture* right, video::ITexture* front,
            video::ITexture* back, ISceneNode* parent = 0, s32 id = -1) _IRR_OVERRIDE_;
        ITextSceneNode* addTextSceneNode(gui::IGUIFont* font, const wchar_t* text,
            video::SColor color = video::SColor(100, 255, 255, 255),
            ISceneNode* parent = 0, const core::vector3df& position = core::vector3df(0, 0, 0),
            s32 id = -1) _IRR_OVERRIDE_;
        IBillboardTextSceneNode* addBillboardTextSceneNode(gui::IGUIFont* font, const wchar_t* text,
            ISceneNode* parent = 0,
            const core::dimension2d<f32>& size = core::dimension2d<f32>(10.0f, 10.0f),
            const core::vector3df& position = core::vector3df(0, 0, 0), s32 id = -1,
            video::SColor colorTop = 0xFFFFFFFF, video::SColor colorBottom = 0xFFFFFFFF) _IRR_OVERRIDE_;
        IMeshSceneNode* addQuake3SceneNode(const IMeshBuffer* meshBuffer, const quake3::IShader* shader,
            ISceneNode* parent = 0, s32 id = -1) _IRR_OVERRIDE_;
        IAnimatedMesh* addHillPlaneMesh(const io::path& name,
            const core::dimension2d<f32>& tileSize, const core::dimension2d<u32>& tileCount,
            video::SMaterial* material = 0, f32 hillHeight = 0.0f,
            const core::dimension2d<f32>& countHills = core::dimension2d<f32>(1.0f, 1.0f),
            const core::dimension2d<f32>& textureRepeatCount = core::dimension2d<f32>(1.0f, 1.0f)) _IRR_OVERRIDE_;
        IAnimatedMesh* addTerrainMesh(const io::path& meshname, video::IImage* texture, video::IImage* heightmap,
            const core::dimension2d<f32>& stretchSize = core::dimension2d<f32>(10.0f, 10.0f),
            f32 maxHeight = 200.0f,
            const core::dimension2d<u32>& defaultVertexBlockSize = core::dimension2d<u32>(64, 64)) _IRR_OVERRIDE_;
        IAnimatedMesh* addArrowMesh(const io::path& name,
            video::SColor vtxColor0, video::SColor vtxColor1,
            u32 tesselationCylinder, u32 tesselationCone,
            f32 height, f32 cylinderHeight, f32 width0,
            f32 width1) _IRR_OVERRIDE_;
        IAnimatedMesh* addSphereMesh(const io::path& name,
            f32 radius = 5.f, u32 polyCountX = 16, u32 polyCountY = 16) _IRR_OVERRIDE_;
        IAnimatedMesh* addVolumeLightMesh(const io::path& name,
            const u32 SubdivideU = 32, const u32 SubdivideV = 32,
            const video::SColor FootColor = video::SColor(51, 0, 230, 180),
            const video::SColor TailColor = video::SColor(0, 0, 0, 0)) _IRR_OVERRIDE_;
        IParticleSystemSceneNode* addParticleSystemSceneNode(
            bool withDefaultEmitter = true, ISceneNode* parent = 0, s32 id = -1,
            const core::vector3df& position = core::vector3df(0, 0, 0),
            const core::vector3df& rotation = core::vector3df(0, 0, 0),
            const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f)) _IRR_OVERRIDE_;
        ITerrainSceneNode* addTerrainSceneNode(
            const io::path& heightMapFileName,
            ISceneNode* parent = 0, s32 id = -1,
            const core::vector3df& position = core::vector3df(0.0f, 0.0f, 0.0f),
            const core::vector3df& rotation = core::vector3df(0.0f, 0.0f, 0.0f),
            const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f),
            video::SColor vertexColor = video::SColor(255, 255, 255, 255),
            s32 maxLOD = 4, E_TERRAIN_PATCH_SIZE patchSize = ETPS_17, s32 smoothFactor = 0,
            bool addAlsoIfHeightmapEmpty = false) _IRR_OVERRIDE_;
        ITerrainSceneNode* addTerrainSceneNode(
            io::IReadFile* heightMap,
            ISceneNode* parent = 0, s32 id = -1,
            const core::vector3df& position = core::vector3df(0.0f, 0.0f, 0.0f),
            const core::vector3df& rotation = core::vector3df(0.0f, 0.0f, 0.0f),
            const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f),
            video::SColor vertexColor = video::SColor(255, 255, 255, 255),
            s32 maxLOD = 4, E_TERRAIN_PATCH_SIZE patchSize = ETPS_17, s32 smoothFactor = 0,
            bool addAlsoIfHeightmapEmpty = false) _IRR_OVERRIDE_;
        IDummyTransformationSceneNode* addDummyTransformationSceneNode(
            ISceneNode* parent = 0, s32 id = -1) _IRR_OVERRIDE_;
        ISceneNode* getRootSceneNode() _IRR_OVERRIDE_;
        ISceneNode* getSceneNodeFromId(s32 id, ISceneNode* start = 0) _IRR_OVERRIDE_;
        ISceneNode* getSceneNodeFromName(const c8* name, ISceneNode* start = 0) _IRR_OVERRIDE_;
        ISceneNode* getSceneNodeFromType(scene::ESCENE_NODE_TYPE type, ISceneNode* start = 0) _IRR_OVERRIDE_;
        void getSceneNodesFromType(ESCENE_NODE_TYPE type, core::array<scene::ISceneNode*>& outNodes, ISceneNode* start = 0) _IRR_OVERRIDE_;
        void setShadowColor(video::SColor color) _IRR_OVERRIDE_;
        video::SColor getShadowColor() const _IRR_OVERRIDE_;
        u32 registerNodeForRendering(ISceneNode* node, E_SCENE_NODE_RENDER_PASS pass = ESNRP_AUTOMATIC) _IRR_OVERRIDE_;
        void clearAllRegisteredNodesForRendering() _IRR_OVERRIDE_;

		ISceneNodeAnimator* createRotationAnimator(const core::vector3df& rotationPerSecond) _IRR_OVERRIDE_;
		ISceneNodeAnimator* createFlyCircleAnimator(
			const core::vector3df& center = core::vector3df(0.f, 0.f, 0.f),
			f32 radius = 100.f, f32 speed = 0.001f,
			const core::vector3df& direction = core::vector3df(0.f, 1.f, 0.f),
			f32 startPosition = 0.f,
			f32 radiusEllipsoid = 0.f) _IRR_OVERRIDE_;
		ISceneNodeAnimator* createFlyStraightAnimator(const core::vector3df& startPoint,
			const core::vector3df& endPoint, u32 timeForWay, bool loop = false, bool pingpong = false) _IRR_OVERRIDE_;
		ISceneNodeAnimator* createTextureAnimator(const core::array<video::ITexture*>& textures,
			s32 timePerFrame, bool loop) _IRR_OVERRIDE_;
		ISceneNodeAnimator* createDeleteAnimator(u32 timeMS) _IRR_OVERRIDE_;
		ISceneNodeAnimatorCollisionResponse* createCollisionResponseAnimator(
			ITriangleSelector* world, ISceneNode* sceneNode,
			const core::vector3df& ellipsoidRadius = core::vector3df(30, 60, 30),
			const core::vector3df& gravityPerSecond = core::vector3df(0, -1.0f, 0),
			const core::vector3df& ellipsoidTranslation = core::vector3df(0, 0, 0),
			f32 slidingValue = 0.0005f) _IRR_OVERRIDE_;
		ISceneNodeAnimator* createFollowSplineAnimator(s32 startTime,
			const core::array< core::vector3df >& points,
			f32 speed, f32 tightness, bool loop, bool pingpong) _IRR_OVERRIDE_;
		ITriangleSelector* createTriangleSelector(IMesh* mesh, ISceneNode* node, bool separateMeshbuffers) _IRR_OVERRIDE_;
		ITriangleSelector* createTriangleSelector(const IMeshBuffer* meshBuffer, irr::u32 materialIndex, ISceneNode* node) _IRR_OVERRIDE_;
		ITriangleSelector* createTriangleSelector(IAnimatedMeshSceneNode* node, bool separateMeshbuffers) _IRR_OVERRIDE_;
		ITriangleSelector* createOctreeTriangleSelector(IMesh* mesh,
			ISceneNode* node, s32 minimalPolysPerNode) _IRR_OVERRIDE_;
		ITriangleSelector* createOctreeTriangleSelector(IMeshBuffer* meshBuffer, irr::u32 materialIndex,
			ISceneNode* node, s32 minimalPolysPerNode = 32) _IRR_OVERRIDE_;
		ITriangleSelector* createTriangleSelectorFromBoundingBox(
			ISceneNode* node) _IRR_OVERRIDE_;
		IMetaTriangleSelector* createMetaTriangleSelector() _IRR_OVERRIDE_;
		ITriangleSelector* createTerrainTriangleSelector(
			ITerrainSceneNode* node, s32 LOD = 0) _IRR_OVERRIDE_;
		void addExternalMeshLoader(IMeshLoader* externalLoader) _IRR_OVERRIDE_;
		u32 getMeshLoaderCount() const _IRR_OVERRIDE_;
		IMeshLoader* getMeshLoader(u32 index) const _IRR_OVERRIDE_;
		void addExternalSceneLoader(ISceneLoader* externalLoader) _IRR_OVERRIDE_;
		u32 getSceneLoaderCount() const _IRR_OVERRIDE_;
		ISceneLoader* getSceneLoader(u32 index) const _IRR_OVERRIDE_;
		ISceneCollisionManager* getSceneCollisionManager() _IRR_OVERRIDE_;
        void addToDeletionQueue(ISceneNode* node) _IRR_OVERRIDE_;
        void clear() _IRR_OVERRIDE_;
        E_SCENE_NODE_RENDER_PASS getSceneNodeRenderPass() const _IRR_OVERRIDE_;
        ISceneNodeFactory* getDefaultSceneNodeFactory() _IRR_OVERRIDE_;
        void registerSceneNodeFactory(ISceneNodeFactory* factoryToAdd) _IRR_OVERRIDE_;
        u32 getRegisteredSceneNodeFactoryCount() const _IRR_OVERRIDE_;
        ISceneNodeFactory* getSceneNodeFactory(u32 index) _IRR_OVERRIDE_;
        const c8* getSceneNodeTypeName(ESCENE_NODE_TYPE type) _IRR_OVERRIDE_;
        const c8* getAnimatorTypeName(ESCENE_NODE_ANIMATOR_TYPE type) _IRR_OVERRIDE_;
        ISceneNodeAnimatorFactory* getDefaultSceneNodeAnimatorFactory() _IRR_OVERRIDE_;
        void registerSceneNodeAnimatorFactory(ISceneNodeAnimatorFactory* factoryToAdd) _IRR_OVERRIDE_;
        u32 getRegisteredSceneNodeAnimatorFactoryCount() const _IRR_OVERRIDE_;
        ISceneNodeAnimatorFactory* getSceneNodeAnimatorFactory(u32 index) _IRR_OVERRIDE_;
        bool saveScene(const io::path& filename, ISceneUserDataSerializer* userDataSerializer = 0, ISceneNode* node = 0) _IRR_OVERRIDE_;
        bool saveScene(io::IWriteFile* file, ISceneUserDataSerializer* userDataSerializer = 0, ISceneNode* node = 0) _IRR_OVERRIDE_;
        bool saveScene(io::IXMLWriter* writer, const io::path& currentPath, ISceneUserDataSerializer* userDataSerializer = 0, ISceneNode* node = 0) _IRR_OVERRIDE_;
        bool loadScene(const io::path& filename, ISceneUserDataSerializer* userDataSerializer = 0, ISceneNode* rootNode = 0) _IRR_OVERRIDE_;
        bool loadScene(io::IReadFile* file, ISceneUserDataSerializer* userDataSerializer = 0, ISceneNode* rootNode = 0) _IRR_OVERRIDE_;
        void setAmbientLight(const video::SColorf& ambientColor) _IRR_OVERRIDE_;
        const video::SColorf& getAmbientLight() const _IRR_OVERRIDE_;
        void setLightManager(ILightManager* lightManager) _IRR_OVERRIDE_;
        E_SCENE_NODE_RENDER_PASS getCurrentRenderPass() const _IRR_OVERRIDE_ { return E_SCENE_NODE_RENDER_PASS::ESNRP_NONE; }
        void setCurrentRenderPass(E_SCENE_NODE_RENDER_PASS) _IRR_OVERRIDE_ { }
        const IGeometryCreator* getGeometryCreator(void) const _IRR_OVERRIDE_ { return nullptr; }
        bool isCulled(const ISceneNode* node) const _IRR_OVERRIDE_;
        ISceneNode* addSceneNode(const char* sceneNodeTypeName, ISceneNode* parent = 0) _IRR_OVERRIDE_;
        ISceneNodeAnimator* createSceneNodeAnimator(const char* typeName, ISceneNode* target = 0) _IRR_OVERRIDE_;
        ISceneManager* createNewSceneManager(bool cloneContent) _IRR_OVERRIDE_;

	private:

		//! video driver
		video::IVideoDriver* Driver;

		//! file system
		io::IFileSystem* FileSystem;

		//! render pass lists
        ISceneNode* Light;
		ISceneNode* SkyDome;
		ISceneNode* WaterNode;
        IMeshSceneNode* HighlightNode;
		core::array<ISceneNode*> SolidNodeList;

        gui::ICursorControl* CursorControl;
		IMeshLoader* MeshLoader;

		//! current active camera
		ICameraSceneNode* ActiveCamera;
        video::SColorf AmbientLight;

        // NOTE: Attributes are slow and should only be used for debug-info and not in release
        io::CAttributes* Parameters;

		//janua_handler PVSHandler;
	};

} // end namespace video
} // end namespace scene

#endif


#define USE_CULLING 1

#include "IrrCompileConfig.h"
#include "CSceneManagerWolvenKit.h"
#include "IVideoDriver.h"
#include "IFileSystem.h"
#include "SAnimatedMesh.h"
#include "IMaterialRenderer.h"
#include "IReadFile.h"
#include "IWriteFile.h"
#include "ISceneLoader.h"
#include "CAttributes.h"
#include "CW3EntLoader.h"

#include "os.h"
#include "debug.h"

#ifdef _IRR_COMPILE_WITH_SKINNED_MESH_SUPPORT_
#include "CSkinnedMesh.h"
#endif


#ifdef _IRR_COMPILE_WITH_OBJ_WRITER_
#include "COBJMeshWriter.h"
#endif

#ifdef _IRR_COMPILE_WITH_FBX_WRITER_
#include "CFBXMeshWriter.h"
#endif

#include "CLightSceneNode.h"
#include "CCameraSceneNode.h"
#include "CMeshSceneNode.h"
#ifdef _IRR_COMPILE_WITH_SKYDOME_SCENENODE_
#include "CSkyDomeSceneNode.h"
#endif // _IRR_COMPILE_WITH_SKYDOME_SCENENODE_

#ifdef _IRR_COMPILE_WITH_WATER_SURFACE_SCENENODE_
#include "CWaterSurfaceSceneNode.h"
#endif // _IRR_COMPILE_WITH_WATER_SURFACE_SCENENODE_
#include "CEmptySceneNode.h"
#include "CTerrainSceneNodeWolvenKit.h"
#include "CSceneNodeAnimatorCameraWolvenKit.h"

#include <locale.h>

namespace irr
{
namespace scene
{

//! constructor
CSceneManagerWolvenKit::CSceneManagerWolvenKit(video::IVideoDriver* driver, io::IFileSystem* fs,
	gui::ICursorControl* cursorControl)
: ISceneNode(nullptr, 0)
,Driver(driver)
,FileSystem(fs)
,CursorControl(cursorControl)
,Light(nullptr)
,SkyDome(nullptr)
,WaterNode(nullptr)
,HighlightNode(nullptr)
,MeshLoader(nullptr)
,ActiveCamera(nullptr)
,AmbientLight(1.0f, 1.0f, 1.0f, 1.0f)
{
	SceneManager = this;

	if (Driver)
		Driver->grab();

	if (FileSystem)
		FileSystem->grab();

    if (CursorControl)
        CursorControl->grab();


	MeshLoader = DBG_NEW CW3EntLoader(this, FileSystem);


    Parameters = DBG_NEW io::CAttributes();

	//TODO: fill buffer with pvs data
	//janua_handler_load_database(&handler, databaseBuffer);
}

//! destructor
CSceneManagerWolvenKit::~CSceneManagerWolvenKit()
{

	//! force to remove hardwareTextures from the driver
	//! because Scenes may hold internally data bounded to sceneNodes
	//! which may be destroyed twice
	if (Driver)
		Driver->removeAllHardwareBuffers();

	if (FileSystem)
		FileSystem->drop();

    if (CursorControl)
        CursorControl->drop();

	if (Light)
		Light->drop();

	if(SkyDome)
		SkyDome->drop();
	
	if(WaterNode)
		WaterNode->drop();
	
	MeshLoader->drop();

    if (Parameters)
        Parameters->drop();

	if (ActiveCamera)
		ActiveCamera->drop();
	ActiveCamera = nullptr;

    SolidNodeList.clear();

    removeAll();

	if (Driver)
		Driver->drop();
}


//! gets an animatable mesh. loads it if needed. returned pointer must not be dropped.
IAnimatedMesh* CSceneManagerWolvenKit::getMesh(const io::path& filename, const io::path& alternativeCacheName)
{
	return nullptr;
}

IMesh* CSceneManagerWolvenKit::getStaticMesh(const io::path& filename)
{
    io::IReadFile* file = FileSystem->createAndOpenFile(filename);
    if (!file)
    {
        os::Printer::log("Could not load mesh, because file could not be opened: ", filename, ELL_ERROR);
        return 0;
    }

    IMesh* m = ((CW3EntLoader*)MeshLoader)->createStaticMesh(file);
    IMesh* msh = Driver->getMeshManipulator()->createMeshWithTangents(m); // need normal maps!
    m->drop();

    for (u32 i = 0; i < msh->getMeshBufferCount(); ++i)
    {
        msh->getMeshBuffer(i)->setHardwareMappingHint(EHM_STATIC);
    }

    file->drop();

    return msh;
}


//! adds a scene node for rendering a static mesh
//! the returned pointer must not be dropped.
IMeshSceneNode* CSceneManagerWolvenKit::addMeshSceneNode(IMesh* mesh, ISceneNode* parent, s32 id,
	const core::vector3df& position, const core::vector3df& rotation, const core::vector3df&, bool)
{
	IMeshSceneNode* node = DBG_NEW CMeshSceneNode(mesh, parent, this, id, position, rotation);
	node->setAutomaticCulling(E_CULLING_TYPE::EAC_FRUSTUM_BOX);
	node->setMaterialFlag(irr::video::E_MATERIAL_FLAG::EMF_BACK_FACE_CULLING, true);
	node->setMaterialFlag(irr::video::E_MATERIAL_FLAG::EMF_LIGHTING, false);
    node->setVisible(false);
	node->drop();
	    
	SolidNodeList.push_back(node);

	return node;
}


//! Adds a scene node for rendering a animated water surface mesh.
ISceneNode* CSceneManagerWolvenKit::addWaterSurfaceSceneNode(IMesh* mesh, f32 waveHeight, f32 waveSpeed, f32 waveLength,
	ISceneNode* parent, s32 id, const core::vector3df& position,
	const core::vector3df& rotation, const core::vector3df& scale)
{
#ifdef _IRR_COMPILE_WITH_WATER_SURFACE_SCENENODE_
    if (!parent)
        parent = this;

	ISceneNode* node = DBG_NEW CWaterSurfaceSceneNode(waveHeight, waveSpeed, waveLength,
		mesh, parent, this, id, position, rotation, scale);

	node->drop();

	WaterNode = node;
	WaterNode->grab();
	
	return node;
#else
	return nullptr;
#endif
}


//! Adds a camera scene node which is able to be controlled with the mouse similar
//! to in the 3D Software Maya by Alias Wavefront.
//! The returned pointer must not be dropped.
ICameraSceneNode* CSceneManagerWolvenKit::addCameraSceneNodeWolvenKit(ISceneNode* parent,
    f32 rotateSpeed, f32 zoomSpeed, f32 translationSpeed, s32 id, f32 distance,
    bool makeActive)
{
    if (!parent)
        parent = this;

	ICameraSceneNode* node = DBG_NEW CCameraSceneNode(parent, this, id, core::vector3df(), core::vector3df(0, 0, 100));

	if (makeActive)
		setActiveCamera(node);
	node->drop();
	
    if (node)
    {
        ISceneNodeAnimator* anm = DBG_NEW CSceneNodeAnimatorCameraWolvenKit(CursorControl,
            rotateSpeed, zoomSpeed, translationSpeed, distance);

        node->addAnimator(anm);
        anm->drop();
    }

    return node;
}


//! Adds a skydome scene node. A skydome is a large (half-) sphere with a
//! panoramic texture on it and is drawn around the camera position.
ISceneNode* CSceneManagerWolvenKit::addSkyDomeSceneNode(video::ITexture* texture,
	u32 horiRes, u32 vertRes, f32 texturePercentage,f32 spherePercentage, f32 radius,
	ISceneNode* parent, s32 id)
{
#ifdef _IRR_COMPILE_WITH_SKYDOME_SCENENODE_
    if (!parent)
        parent = this;

	ISceneNode* node = DBG_NEW CSkyDomeSceneNode(texture, horiRes, vertRes,
		texturePercentage, spherePercentage, radius, parent, this, id);

	node->drop();
	
	SkyDome = node;
	SkyDome->grab();
	
	return node;
#else
	return 0;
#endif
}

ITerrainSceneNodeWolvenKit* CSceneManagerWolvenKit::addTerrainSceneNodeWolvenKit(
    const io::path& heightMapFileName,
    ISceneNode* parent, s32 id,
    u32 dimension, f32 maxHeight, f32 minHeight, f32 tileSize,
    const core::vector3df& anchor)
{
    if (!parent)
        parent = this;

    io::IReadFile* file = FileSystem->createAndOpenFile(heightMapFileName);

    if (!file)
    {
        os::Printer::log("Could not load terrain, because file could not be opened.",
            heightMapFileName, ELL_ERROR);
        return 0;
    }

    core::vector3df pt = anchor;
    pt.X *= -1.0f; // flip this
    CTerrainSceneNodeWolvenKit* node = DBG_NEW CTerrainSceneNodeWolvenKit(parent, this, id, pt);

    if (!node->loadHeightMap(file, dimension, maxHeight, minHeight, tileSize))
    {
		if (file)
			file->drop();
		
		node->remove();
        node->drop();
        return nullptr;
    }

	if (file)
		file->drop();

    node->setVisible(false);
    node->setAutomaticCulling(E_CULLING_TYPE::EAC_FRUSTUM_BOX);
    node->setMaterialFlag(irr::video::E_MATERIAL_FLAG::EMF_BACK_FACE_CULLING, true);
    node->setMaterialFlag(irr::video::E_MATERIAL_FLAG::EMF_LIGHTING, false);

    node->drop();

#if defined(MAKE_SCENE)
    // add to pvs scene 
	u32 numVerts = node->getMesh()->getMeshBuffer(0)->getVertexCount();
	video::S3DVertex* vertices = static_cast<video::S3DVertex*>(node->getMesh()->getMeshBuffer(0)->getVertices());
    
    f32* verts = new f32[numVerts * 3];
	s32 triangleCount = (dimension - 1) * (dimension - 1) * 2;
	s32* indices = new s32[triangleCount * 3];

	f32* pVert = verts;
	video::S3DVertex* pVertex = vertices;

	// Positions
	for (u32 i = 0; i < numVerts; ++i, ++pVertex)
	{
		*pVert++ = pVertex->Pos.X;
		*pVert++ = pVertex->Pos.Y;
		*pVert++ = pVertex->Pos.Z;
	}

	// Faces
    s32 row0Index = 0;
    s32 row1Index = dimension;
	s32* pFace = indices;

	for (s32 y = 0; y < dimension - 1; ++y)
	{
		for (s32 x = 0; x < dimension - 1; ++x)
		{
			// one row of triangles, two at a time
			*pFace++ = row0Index++;
			*pFace++ = row1Index;
			*pFace++ = row0Index;

            *pFace++ = row0Index;
            *pFace++ = row1Index++;
            *pFace++ = row1Index;
		}
	}

    Janua::Model* ocModel = new Janua::Model(verts, numVerts, indices, triangleCount);
    ocScene.addModelInstance((*ocModel), id, Janua::Matrix4x4(), OCCLUDER);
#endif

	SolidNodeList.push_back(node);

    return node;
}

//! Adds an empty scene node.
ISceneNode* CSceneManagerWolvenKit::addEmptySceneNode(ISceneNode* parent, s32 id)
{
	if (parent == nullptr)
		parent = this;

	ISceneNode* node = DBG_NEW CEmptySceneNode(parent, this, id);
	node->drop();

	return node;
}

//! Returns the current active camera.
//! \return The active camera is returned. Note that this can be NULL, if there
//! was no camera created yet.
ICameraSceneNode* CSceneManagerWolvenKit::getActiveCamera() const
{
	return ActiveCamera;
}


//! Sets the active camera. The previous active camera will be deactivated.
//! \param camera: The new camera which should be active.
void CSceneManagerWolvenKit::setActiveCamera(ICameraSceneNode* camera)
{
	if (camera)
		camera->grab();
	if (ActiveCamera)
		ActiveCamera->drop();

	ActiveCamera = camera;
}

//! Adds a dynamic light scene node. The light will cast dynamic light on all
//! other scene nodes in the scene, which have the material flag video::MTF_LIGHTING
//! turned on. (This is the default setting in most scene nodes).
ILightSceneNode* CSceneManagerWolvenKit::addLightSceneNode(ISceneNode* parent,
    const core::vector3df& position, video::SColorf color, f32 range, s32 id)
{
    if (!parent)
        parent = this;

    ILightSceneNode* node = DBG_NEW CLightSceneNode(parent, this, id, position, color, range);
    node->drop();

    Light = node;
	Light->grab();

    return node;
}

void CSceneManagerWolvenKit::SelectNode(ISceneNode* node)
{
    HighlightNode = (IMeshSceneNode*)node;
}

void CSceneManagerWolvenKit::DeselectNode()
{
    HighlightNode = nullptr;
}

//! This method is called just before the rendering process of the whole scene.
//! draws all scene nodes
void CSceneManagerWolvenKit::drawAll()
{
	// reset all transforms
	Driver->setMaterial(video::SMaterial());
	Driver->setTransform ( video::ETS_PROJECTION, core::IdentityMatrix );
	Driver->setTransform ( video::ETS_VIEW, core::IdentityMatrix );
	Driver->setTransform ( video::ETS_WORLD, core::IdentityMatrix );
	for (s32 i=video::ETS_COUNT-1; i>=video::ETS_TEXTURE_0; --i)
		Driver->setTransform ( (video::E_TRANSFORMATION_STATE)i, core::IdentityMatrix );

	OnAnimate(os::Timer::getTime());

	/*!
		First Scene Node for prerendering should be the active camera
		consistent Camera is needed for culling
	*/
	if (ActiveCamera)
	{
		ActiveCamera->render();
	}

	Driver->deleteAllDynamicLights();
	Driver->setAmbientLight(AmbientLight);

	if (Light)
	{
		Light->render();
	}

	// render skyboxes
	if(SkyDome)
	{
		SkyDome->render();
	}

	// render default objects
	{
		//TODO: use PVSHandler to get visible set
		/*
		janua_query_result result;
		janua_query_visibility_from_position( &PVSHandler, camWorldPos.X, camWorldPos.Y, camWorldPos.Z, &result );
	
		for (u32 i=0; i<result.model_ids_count; ++i)
		{
			SolidNodeList[ result.model_ids[i] ]->render();
		}
		*/
#if USE_CULLING
        const SViewFrustum* frust = ActiveCamera->getViewFrustum();

        for (u32 i = 0; i < SolidNodeList.size(); ++i)
        {
            ISceneNode* node = SolidNodeList[i];

            bool isCulled = false;
			if (node->isVisible())
			{
                core::vector3df edges[8];
                node->getTransformedBoundingBox().getEdges(edges);

                for (s32 i = 0; i < scene::SViewFrustum::VF_PLANE_COUNT; ++i)
                {
                    bool boxInFrustum = false;
                    for (u32 j = 0; j < 8; ++j)
                    {
                        if (frust->planes[i].classifyPointRelation(edges[j]) != core::ISREL3D_FRONT)
                        {
                            boxInFrustum = true;
                            break;
                        }
                    }

                    if (!boxInFrustum)
                    {
                        isCulled = true;
                        break;
                    }
                }

                if (!isCulled)
                {
                    node->render();
                }
			}
        }
#else
        for (u32 i = 0; i < SolidNodeList.size(); ++i)
        {
            SolidNodeList[i]->render();
        }
#endif

        if (HighlightNode)
        {
            video::SMaterial m;
            m.Lighting = false;
            m.AntiAliasing = 1;
            Driver->setTransform(video::ETS_WORLD, HighlightNode->getAbsoluteTransformation());
            Driver->setMaterial(m);
            Driver->draw3DBox(HighlightNode->getBoundingBox(), video::SColor(255, 255, 255, 0));
        }
    }
}

//! Returns a pointer to the mesh manipulator.
IMeshManipulator* CSceneManagerWolvenKit::getMeshManipulator()
{
	return Driver->getMeshManipulator();
}

//! Posts an input event to the environment. Usually you do not have to
//! use this method, it is used by the internal engine.
bool CSceneManagerWolvenKit::postEventFromUser(const SEvent& event)
{
	bool ret = false;
	ICameraSceneNode* cam = getActiveCamera();
	if (cam)
		ret = cam->OnEvent(event);

	return ret;
}

//! Get a skinned mesh, which is not available as header-only code
ISkinnedMesh* CSceneManagerWolvenKit::createSkinnedMesh()
{
#ifdef _IRR_COMPILE_WITH_SKINNED_MESH_SUPPORT_
    return DBG_NEW CSkinnedMesh();
#else
    return 0;
#endif
}

//! Returns interface to the parameters set in this scene.
io::IAttributes* CSceneManagerWolvenKit::getParameters()
{
    return Parameters;
}

//! returns the video driver
video::IVideoDriver* CSceneManagerWolvenKit::getVideoDriver()
{
    return Driver;
}

io::IFileSystem* CSceneManagerWolvenKit::getFileSystem()
{
    return FileSystem;
}

//! Returns a mesh writer implementation if available
IMeshWriter* CSceneManagerWolvenKit::createMeshWriter(EMESH_WRITER_TYPE type)
{
	switch(type)
	{
	case EMWT_OBJ:
#ifdef _IRR_COMPILE_WITH_OBJ_WRITER_
		return DBG_NEW COBJMeshWriter(this, FileSystem);
#else
		return nullptr;
#endif

	case EMWT_FBX:
#ifdef _IRR_COMPILE_WITH_FBX_WRITER_
		return DBG_NEW CFBXMeshWriter(this, Driver, FileSystem);
#else
		return nullptr;
#endif
	case EMWT_GLTF:
		return nullptr;

	}

	return nullptr;
}

const core::aabbox3d<f32>& CSceneManagerWolvenKit::getBoundingBox() const
{
    _IRR_DEBUG_BREAK_IF(true) // Bounding Box of Scene Manager should never be used.

    static const core::aabbox3d<f32> dummy;
    return dummy;
}


// not used but must implement
IAnimatedMesh* CSceneManagerWolvenKit::getMesh(io::IReadFile* file)
{
	return nullptr;
}

IMeshCache* CSceneManagerWolvenKit::getMeshCache()
{
	return nullptr;
}

gui::IGUIEnvironment* CSceneManagerWolvenKit::getGUIEnvironment()
{
	return nullptr;
}

IVolumeLightSceneNode* CSceneManagerWolvenKit::addVolumeLightSceneNode(ISceneNode* parent, s32 id,
    const u32 subdivU, const u32 subdivV,
    const video::SColor foot,
    const video::SColor tail,
    const core::vector3df& position,
    const core::vector3df& rotation,
    const core::vector3df& scale)
{
	return nullptr;
}

IMeshSceneNode* CSceneManagerWolvenKit::addCubeSceneNode(f32 size, ISceneNode* parent, s32 id,
	const core::vector3df& position,
	const core::vector3df& rotation,
	const core::vector3df& scale)
{
	return nullptr;
}

IMeshSceneNode* CSceneManagerWolvenKit::addSphereSceneNode(f32 radius, s32 polyCount, ISceneNode* parent, s32 id,
	const core::vector3df& position,
	const core::vector3df& rotation,
	const core::vector3df& scale)
{
	return nullptr;
}

IAnimatedMeshSceneNode* CSceneManagerWolvenKit::addAnimatedMeshSceneNode(IAnimatedMesh* mesh, ISceneNode* parent, s32 id,
	const core::vector3df& position,
	const core::vector3df& rotation,
	const core::vector3df& scale,
	bool alsoAddIfMeshPointerZero)
{
	return nullptr;
}

IOctreeSceneNode* CSceneManagerWolvenKit::addOctreeSceneNode(IAnimatedMesh* mesh, ISceneNode* parent,
	s32 id, s32 minimalPolysPerNode, bool alsoAddIfMeshPointerZero)
{
	return nullptr;
}

IOctreeSceneNode* CSceneManagerWolvenKit::addOctreeSceneNode(IMesh* mesh, ISceneNode* parent,
    s32 id, s32 minimalPolysPerNode, bool alsoAddIfMeshPointerZero)
{
    return nullptr;
}

ICameraSceneNode* CSceneManagerWolvenKit::addCameraSceneNode(ISceneNode* parent,
    const core::vector3df& position, const core::vector3df& lookat, s32 id, bool makeActive)
{
    return nullptr;
}

ICameraSceneNode* CSceneManagerWolvenKit::addCameraSceneNodeMaya(ISceneNode* parent,
    f32 rotateSpeed, f32 zoomSpeed, f32 translationSpeed, s32 id, f32 distance, bool makeActive)
{
    return nullptr;
}

ICameraSceneNode* CSceneManagerWolvenKit::addCameraSceneNodeFPS(ISceneNode* parent,
    f32 rotateSpeed, f32 moveSpeed, s32 id,
    SKeyMap* keyMapArray, s32 keyMapSize,
    bool noVerticalMovement, f32 jumpSpeed,
    bool invertMouseY, bool makeActive)
{
    return nullptr;
}

IBillboardSceneNode* CSceneManagerWolvenKit::addBillboardSceneNode(ISceneNode* parent,
    const core::dimension2d<f32>& size,
    const core::vector3df& position, s32 id,
    video::SColor shadeTop, video::SColor shadeBottom)
{
    return nullptr;
}

ISceneNode* CSceneManagerWolvenKit::addSkyBoxSceneNode(video::ITexture* top, video::ITexture* bottom,
    video::ITexture* left, video::ITexture* right, video::ITexture* front,
    video::ITexture* back, ISceneNode* parent, s32 id)
{
    return nullptr;
}

ITextSceneNode* CSceneManagerWolvenKit::addTextSceneNode(gui::IGUIFont* font, const wchar_t* text,
    video::SColor color,
    ISceneNode* parent, const core::vector3df& position, s32 id)
{
    return nullptr;
}

IBillboardTextSceneNode* CSceneManagerWolvenKit::addBillboardTextSceneNode(gui::IGUIFont* font, const wchar_t* text,
    ISceneNode* parent,
    const core::dimension2d<f32>& size,
    const core::vector3df& position, s32 id,
    video::SColor colorTop, video::SColor colorBottom)
{
    return nullptr;
}

IMeshSceneNode* CSceneManagerWolvenKit::addQuake3SceneNode(const IMeshBuffer* meshBuffer, const quake3::IShader* shader,
    ISceneNode* parent, s32 id)
{
    return nullptr;
}

IAnimatedMesh* CSceneManagerWolvenKit::addHillPlaneMesh(const io::path& name,
    const core::dimension2d<f32>& tileSize, const core::dimension2d<u32>& tileCount,
    video::SMaterial* material, f32 hillHeight,
    const core::dimension2d<f32>& countHills,
    const core::dimension2d<f32>& textureRepeatCount)
{
    return nullptr;
}

IAnimatedMesh* CSceneManagerWolvenKit::addTerrainMesh(const io::path& meshname, video::IImage* texture, video::IImage* heightmap,
    const core::dimension2d<f32>& stretchSize,
    f32 maxHeight,
    const core::dimension2d<u32>& defaultVertexBlockSize)
{
    return nullptr;
}

IAnimatedMesh* CSceneManagerWolvenKit::addArrowMesh(const io::path& name,
    video::SColor vtxColor0, video::SColor vtxColor1,
    u32 tesselationCylinder, u32 tesselationCone,
    f32 height, f32 cylinderHeight, f32 width0,
    f32 width1)
{
    return nullptr;
}

IAnimatedMesh* CSceneManagerWolvenKit::addSphereMesh(const io::path& name,
    f32 radius, u32 polyCountX, u32 polyCountY)
{
    return nullptr;
}

IAnimatedMesh* CSceneManagerWolvenKit::addVolumeLightMesh(const io::path& name,
    const u32 SubdivideU, const u32 SubdivideV,
    const video::SColor FootColor,
    const video::SColor TailColor)
{
    return nullptr;
}

IParticleSystemSceneNode* CSceneManagerWolvenKit::addParticleSystemSceneNode(
    bool withDefaultEmitter, ISceneNode* parent, s32 id,
    const core::vector3df& position,
    const core::vector3df& rotation,
    const core::vector3df& scale)
{
    return nullptr;
}

ITerrainSceneNode* CSceneManagerWolvenKit::addTerrainSceneNode(
    const io::path& heightMapFileName,
    ISceneNode* parent, s32 id,
    const core::vector3df& position,
    const core::vector3df& rotation,
    const core::vector3df& scale,
    video::SColor vertexColor,
    s32 maxLOD, E_TERRAIN_PATCH_SIZE patchSize, s32 smoothFactor,
    bool addAlsoIfHeightmapEmpty)
{
    return nullptr;
}

ITerrainSceneNode* CSceneManagerWolvenKit::addTerrainSceneNode(
    io::IReadFile* heightMap,
    ISceneNode* parent, s32 id,
    const core::vector3df& position,
    const core::vector3df& rotation,
    const core::vector3df& scale,
    video::SColor vertexColor,
    s32 maxLOD, E_TERRAIN_PATCH_SIZE patchSize, s32 smoothFactor,
    bool addAlsoIfHeightmapEmpty)
{
    return nullptr;
}

IDummyTransformationSceneNode* CSceneManagerWolvenKit::addDummyTransformationSceneNode(
    ISceneNode* parent, s32 id)
{
    return nullptr;
}

ISceneNode* CSceneManagerWolvenKit::getRootSceneNode()
{
	return nullptr;
}

ISceneNode* CSceneManagerWolvenKit::getSceneNodeFromId(s32 id, ISceneNode* start)
{
    return nullptr;
}

ISceneNode* CSceneManagerWolvenKit::getSceneNodeFromName(const c8* name, ISceneNode* start)
{
    return nullptr;
}

ISceneNode* CSceneManagerWolvenKit::getSceneNodeFromType(scene::ESCENE_NODE_TYPE type, ISceneNode* start)
{
    return nullptr;
}

void CSceneManagerWolvenKit::getSceneNodesFromType(ESCENE_NODE_TYPE type, core::array<scene::ISceneNode*>& outNodes, ISceneNode* start)
{    
}

void CSceneManagerWolvenKit::setShadowColor(video::SColor color)
{
}

video::SColor CSceneManagerWolvenKit::getShadowColor() const
{
	return video::SColor(255);
}

u32 CSceneManagerWolvenKit::registerNodeForRendering(ISceneNode* node, E_SCENE_NODE_RENDER_PASS pass)
{
	return 0;
}

void CSceneManagerWolvenKit::clearAllRegisteredNodesForRendering()
{

}

ISceneNodeAnimator* CSceneManagerWolvenKit::createRotationAnimator(const core::vector3df& rotationPerSecond)
{
    return nullptr;
}

ISceneNodeAnimator* CSceneManagerWolvenKit::createFlyCircleAnimator(
    const core::vector3df& center,
    f32 radius, f32 speed,
    const core::vector3df& direction,
    f32 startPosition,
    f32 radiusEllipsoid)
{
    return nullptr;
}

ISceneNodeAnimator* CSceneManagerWolvenKit::createFlyStraightAnimator(const core::vector3df& startPoint,
    const core::vector3df& endPoint, u32 timeForWay, bool loop, bool pingpong)
{
    return nullptr;
}

ISceneNodeAnimator* CSceneManagerWolvenKit::createTextureAnimator(const core::array<video::ITexture*>& textures,
    s32 timePerFrame, bool loop)
{
    return nullptr;
}

ISceneNodeAnimator* CSceneManagerWolvenKit::createDeleteAnimator(u32 timeMS)
{
    return nullptr;
}

ISceneNodeAnimatorCollisionResponse* CSceneManagerWolvenKit::createCollisionResponseAnimator(
    ITriangleSelector* world, ISceneNode* sceneNode,
    const core::vector3df& ellipsoidRadius,
    const core::vector3df& gravityPerSecond,
    const core::vector3df& ellipsoidTranslation,
    f32 slidingValue)
{
    return nullptr;
}

ISceneNodeAnimator* CSceneManagerWolvenKit::createFollowSplineAnimator(s32 startTime,
    const core::array< core::vector3df >& points,
    f32 speed, f32 tightness, bool loop, bool pingpong)
{
    return nullptr;
}

ITriangleSelector* CSceneManagerWolvenKit::createTriangleSelector(IMesh* mesh, ISceneNode* node, bool separateMeshbuffers)
{
    return nullptr;
}

ITriangleSelector* CSceneManagerWolvenKit::createTriangleSelector(const IMeshBuffer* meshBuffer, irr::u32 materialIndex, ISceneNode* node)
{
    return nullptr;
}

ITriangleSelector* CSceneManagerWolvenKit::createTriangleSelector(IAnimatedMeshSceneNode* node, bool separateMeshbuffers)
{
    return nullptr;
}

ITriangleSelector* CSceneManagerWolvenKit::createOctreeTriangleSelector(IMesh* mesh,
    ISceneNode* node, s32 minimalPolysPerNode)
{
    return nullptr;
}

ITriangleSelector* CSceneManagerWolvenKit::createOctreeTriangleSelector(IMeshBuffer* meshBuffer, irr::u32 materialIndex,
    ISceneNode* node, s32 minimalPolysPerNode)
{
    return nullptr;
}

ITriangleSelector* CSceneManagerWolvenKit::createTriangleSelectorFromBoundingBox(
    ISceneNode* node)
{
    return nullptr;
}

IMetaTriangleSelector* CSceneManagerWolvenKit::createMetaTriangleSelector()
{
    return nullptr;
}

ITriangleSelector* CSceneManagerWolvenKit::createTerrainTriangleSelector(
    ITerrainSceneNode* node, s32 LOD)
{
    return nullptr;
}

void CSceneManagerWolvenKit::addExternalMeshLoader(IMeshLoader* externalLoader)
{
}

u32 CSceneManagerWolvenKit::getMeshLoaderCount() const
{
    return 0;
}

IMeshLoader* CSceneManagerWolvenKit::getMeshLoader(u32 index) const
{
    return nullptr;
}

void CSceneManagerWolvenKit::addExternalSceneLoader(ISceneLoader* externalLoader)
{
}

u32 CSceneManagerWolvenKit::getSceneLoaderCount() const
{
    return 0;
}

ISceneLoader* CSceneManagerWolvenKit::getSceneLoader(u32 index) const
{
    return nullptr;
}

ISceneCollisionManager* CSceneManagerWolvenKit::getSceneCollisionManager()
{
    return nullptr;
}

void CSceneManagerWolvenKit::addToDeletionQueue(ISceneNode* node)
{

}

void CSceneManagerWolvenKit::clear()
{

}

E_SCENE_NODE_RENDER_PASS CSceneManagerWolvenKit::getSceneNodeRenderPass() const
{
	return E_SCENE_NODE_RENDER_PASS::ESNRP_NONE;
}

ISceneNodeFactory* CSceneManagerWolvenKit::getDefaultSceneNodeFactory()
{
	return nullptr;
}

void CSceneManagerWolvenKit::registerSceneNodeFactory(ISceneNodeFactory* factoryToAdd)
{

}

u32 CSceneManagerWolvenKit::getRegisteredSceneNodeFactoryCount() const
{
	return 0;
}

ISceneNodeFactory* CSceneManagerWolvenKit::getSceneNodeFactory(u32 index)
{
	return nullptr;
}

const c8* CSceneManagerWolvenKit::getSceneNodeTypeName(ESCENE_NODE_TYPE type)
{
	return nullptr;
}

const c8* CSceneManagerWolvenKit::getAnimatorTypeName(ESCENE_NODE_ANIMATOR_TYPE type)
{
	return nullptr;
}

ISceneNodeAnimatorFactory* CSceneManagerWolvenKit::getDefaultSceneNodeAnimatorFactory()
{
    return nullptr;
}

void CSceneManagerWolvenKit::registerSceneNodeAnimatorFactory(ISceneNodeAnimatorFactory* factoryToAdd)
{
}

u32 CSceneManagerWolvenKit::getRegisteredSceneNodeAnimatorFactoryCount() const
{
    return 0;
}

ISceneNodeAnimatorFactory* CSceneManagerWolvenKit::getSceneNodeAnimatorFactory(u32 index)
{
    return nullptr;
}

bool CSceneManagerWolvenKit::saveScene(const io::path& filename, ISceneUserDataSerializer* userDataSerializer, ISceneNode* node)
{
/*
    core::stringc outputPath = (core::stringc)filename;
    Janua::PVSGenerator generator = Janua::PVSGenerator(ocScene);
    printf("generating database...");
    shared_ptr<Janua::PVSDatabase> ocDatabase = generator.generatePVSDatabase();
    printf("done\n");

    //Export to file
    Janua::PVSDatabaseExporter dbExporter(*ocDatabase);
    int allocatedSize = dbExporter.getBufferSize();
    char* buffer = new char[allocatedSize];
    printf("saving to buffer...");
    dbExporter.saveToBuffer(buffer);
    printf("done\n");
    FILE* file = fopen(outputPath.c_str(), "wb");
    fwrite(buffer, 1, allocatedSize, file);
    fclose(file);
    printf("wrote %s\n",outputPath.c_str());
    delete[] buffer;
*/
    return false;
}

bool CSceneManagerWolvenKit::saveScene(io::IWriteFile* file, ISceneUserDataSerializer* userDataSerializer, ISceneNode* node)
{
    return false;
}

bool CSceneManagerWolvenKit::saveScene(io::IXMLWriter* writer, const io::path& currentPath, ISceneUserDataSerializer* userDataSerializer, ISceneNode* node)
{
    return false;
}

bool CSceneManagerWolvenKit::loadScene(const io::path& filename, ISceneUserDataSerializer* userDataSerializer, ISceneNode* rootNode)
{
    return false;
}

bool CSceneManagerWolvenKit::loadScene(io::IReadFile* file, ISceneUserDataSerializer* userDataSerializer, ISceneNode* rootNode)
{
    return false;
}

void CSceneManagerWolvenKit::setAmbientLight(const video::SColorf& ambientColor)
{
	AmbientLight = ambientColor;
}

const video::SColorf& CSceneManagerWolvenKit::getAmbientLight() const
{
	return AmbientLight;
}

void CSceneManagerWolvenKit::setLightManager(ILightManager* lightManager)
{

}

bool CSceneManagerWolvenKit::isCulled(const ISceneNode* node) const
{
	return false;
}

ISceneNode* CSceneManagerWolvenKit::addSceneNode(const char* sceneNodeTypeName, ISceneNode* parent)
{
	return nullptr;
}

ISceneNodeAnimator* CSceneManagerWolvenKit::createSceneNodeAnimator(const char* typeName, ISceneNode* target)
{
	return nullptr;
}

ISceneManager* CSceneManagerWolvenKit::createNewSceneManager(bool cloneContent)
{
	return nullptr;
}

} // end namespace scene
} // end namespace irr


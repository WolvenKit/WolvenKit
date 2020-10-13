// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

// TODO: second UV-coordinates currently ignored in textures

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_COLLADA_WRITER_

#include "CColladaMeshWriter.h"
#include "os.h"
#include "IFileSystem.h"
#include "IWriteFile.h"
#include "IXMLWriter.h"
#include "IMesh.h"
#include "IAttributes.h"
#include "IAnimatedMeshSceneNode.h"
#include "IMeshSceneNode.h"
#include "ITerrainSceneNode.h"
#include "ILightSceneNode.h"
#include "ICameraSceneNode.h"
#include "ISceneManager.h"
#include "debug.h"

namespace irr
{
namespace scene
{

//! Which lighting model should be used in the technique (FX) section when exporting effects (materials)
E_COLLADA_TECHNIQUE_FX CColladaMeshWriterProperties::getTechniqueFx(const video::SMaterial& material) const
{
	return ECTF_BLINN;
}

//! Which texture index should be used when writing the texture of the given sampler color.
s32 CColladaMeshWriterProperties::getTextureIdx(const video::SMaterial & material, E_COLLADA_COLOR_SAMPLER cs) const
{
	// So far we just export in a way which is similar to how we import colladas.
	// There might be better ways to do this, but I suppose it depends a lot for which target
	// application we export, so in most cases it will have to be done in user-code anyway.
	switch ( cs )
	{
		case ECCS_DIFFUSE:
			return 2;
		case ECCS_AMBIENT:
			return 1;
		case ECCS_EMISSIVE:
			return 0;
		case ECCS_SPECULAR:
			return 3;
		case ECCS_TRANSPARENT:
			return -1;
		case ECCS_REFLECTIVE:
			return -1;
	};
	return -1;
}

E_COLLADA_IRR_COLOR CColladaMeshWriterProperties::getColorMapping(const video::SMaterial & material, E_COLLADA_COLOR_SAMPLER cs) const
{
	switch ( cs )
	{
		case ECCS_DIFFUSE:
			return ECIC_DIFFUSE;
		case ECCS_AMBIENT:
			return ECIC_AMBIENT;
		case ECCS_EMISSIVE:
			return ECIC_EMISSIVE;
		case ECCS_SPECULAR:
			return ECIC_SPECULAR;
		case ECCS_TRANSPARENT:
			return ECIC_NONE;
		case ECCS_REFLECTIVE:
			return ECIC_CUSTOM;
	};

	return ECIC_NONE;
}

//! Return custom colors for certain color types requested by collada.
video::SColor CColladaMeshWriterProperties::getCustomColor(const video::SMaterial & material, E_COLLADA_COLOR_SAMPLER cs) const
{
	return video::SColor(255, 0, 0, 0);
}


//! Return the settings for transparence
E_COLLADA_TRANSPARENT_FX CColladaMeshWriterProperties::getTransparentFx(const video::SMaterial& material) const
{
	// TODO: figure out best default mapping
	return ECOF_A_ONE;
}

//! Transparency value for the material.
f32 CColladaMeshWriterProperties::getTransparency(const video::SMaterial& material) const
{
	// TODO: figure out best default mapping
	return -1.f;
}

//! Reflectivity value for that material
f32 CColladaMeshWriterProperties::getReflectivity(const video::SMaterial& material) const
{
	// TODO: figure out best default mapping
	return 0.f;
}

//! Return index of refraction for that material
f32 CColladaMeshWriterProperties::getIndexOfRefraction(const video::SMaterial& material) const
{
	return -1.f;
}

bool CColladaMeshWriterProperties::isExportable(const irr::scene::ISceneNode * node) const
{
	return node && node->isVisible();
}

IMesh* CColladaMeshWriterProperties::getMesh(irr::scene::ISceneNode * node)
{
	if ( !node )
		return 0;
	if ( node->getType() == ESNT_ANIMATED_MESH )
		return static_cast<IAnimatedMeshSceneNode*>(node)->getMesh()->getMesh(0);
	// TODO: we need some ISceneNode::hasType() function to get rid of those checks
	if (	node->getType() == ESNT_MESH
		||	node->getType() == ESNT_CUBE
		||	node->getType() == ESNT_SPHERE
		||	node->getType() == ESNT_WATER_SURFACE
		||	node->getType() == ESNT_Q3SHADER_SCENE_NODE
		)
		return static_cast<IMeshSceneNode*>(node)->getMesh();
	if ( node->getType() == ESNT_TERRAIN )
		return static_cast<ITerrainSceneNode*>(node)->getMesh();
	return 0;
}

// Check if the node has it's own material overwriting the mesh-materials
bool CColladaMeshWriterProperties::useNodeMaterial(const scene::ISceneNode* node) const
{
	if ( !node )
		return false;

	// TODO: we need some ISceneNode::hasType() function to get rid of those checks
	bool useMeshMaterial =	(	(node->getType() == ESNT_MESH ||
								node->getType() == ESNT_CUBE ||
								node->getType() == ESNT_SPHERE ||
								node->getType() == ESNT_WATER_SURFACE ||
								node->getType() == ESNT_Q3SHADER_SCENE_NODE)
								&& static_cast<const IMeshSceneNode*>(node)->isReadOnlyMaterials())

							||	(node->getType() == ESNT_ANIMATED_MESH
								&& static_cast<const IAnimatedMeshSceneNode*>(node)->isReadOnlyMaterials() );

	return !useMeshMaterial;
}



CColladaMeshWriterNames::CColladaMeshWriterNames(IColladaMeshWriter * writer)
	: ColladaMeshWriter(writer)
{
}

irr::core::stringc CColladaMeshWriterNames::nameForMesh(const scene::IMesh* mesh, int instance)
{
	irr::core::stringc name("mesh");
	name += nameForPtr(mesh);
	if ( instance > 0 )
	{
		name += "i";
		name += irr::core::stringc(instance);
	}
	return ColladaMeshWriter->toNCName(name);
}

irr::core::stringc CColladaMeshWriterNames::nameForNode(const scene::ISceneNode* node)
{
	irr::core::stringc name;
	// Prefix, because xs:ID can't start with a number, also nicer name
	if ( node && node->getType() == ESNT_LIGHT )
		name = "light";
	else
		name = "node";
	name += nameForPtr(node);
	if ( node )
	{
		name += irr::core::stringc(node->getName());
	}
	return ColladaMeshWriter->toNCName(name);
}

irr::core::stringc CColladaMeshWriterNames::nameForMaterial(const video::SMaterial & material, int materialId, const scene::IMesh* mesh, const scene::ISceneNode* node)
{
	core::stringc strMat("mat");

	bool nodeMaterial = ColladaMeshWriter->getProperties()->useNodeMaterial(node);
	if ( nodeMaterial )
	{
		strMat += "node";
		strMat += nameForPtr(node);
		strMat += irr::core::stringc(node->getName());
	}
	strMat += "mesh";
	strMat += nameForPtr(mesh);
	strMat += materialId;
	return ColladaMeshWriter->toNCName(strMat);
}

irr::core::stringc CColladaMeshWriterNames::nameForPtr(const void* ptr) const
{
	c8 buf[32];
	snprintf_irr(buf, 32, "%p", ptr);
	return irr::core::stringc(buf);
}



CColladaMeshWriter::CColladaMeshWriter(	ISceneManager * smgr, video::IVideoDriver* driver,
					io::IFileSystem* fs)
	: FileSystem(fs), VideoDriver(driver), Writer(0)
{

	#ifdef _DEBUG
	setDebugName("CColladaMeshWriter");
	#endif

	if (VideoDriver)
		VideoDriver->grab();

	if (FileSystem)
		FileSystem->grab();

	if ( smgr )
		setAmbientLight( smgr->getAmbientLight() );

	// Escape some characters 
	// Slightly fuzzy definition for xs:anyURI.
	// In theory not even spaces would need to be escaped, 
	// but it's strongly encouraged to do so and many Apps rely on it.
	// If there are any apps out there which need more escapes we can add them.
	// See https://www.w3schools.com/tags/ref_urlencode.asp for a list.
	// NOTE: Never replace by empty characters (so not the place to delete chars!)
	EscapeCharsAnyURI.push_back(EscapeCharacterURL(' ', "%20"));
	EscapeCharsAnyURI.push_back(EscapeCharacterURL('#', "%23"));
	EscapeCharsAnyURI.push_back(EscapeCharacterURL('%', "%25"));

	CColladaMeshWriterProperties * p = DBG_NEW CColladaMeshWriterProperties();
	setDefaultProperties(p);
	setProperties(p);
	p->drop();

	CColladaMeshWriterNames * nameGenerator = DBG_NEW CColladaMeshWriterNames(this);
	setDefaultNameGenerator(nameGenerator);
	setNameGenerator(nameGenerator);
	nameGenerator->drop();
}


CColladaMeshWriter::~CColladaMeshWriter()
{
	if (VideoDriver)
		VideoDriver->drop();

	if (FileSystem)
		FileSystem->drop();
}


void CColladaMeshWriter::reset()
{
	LibraryImages.clear();
	Meshes.clear();
	LightNodes.clear();
	CameraNodes.clear();
	MaterialsWritten.clear();
	EffectsWritten.clear();
	MaterialNameCache.clear();
}

//! Returns the type of the mesh writer
EMESH_WRITER_TYPE CColladaMeshWriter::getType() const
{
	return EMWT_COLLADA;
}

//! writes a scene starting with the given node
bool CColladaMeshWriter::writeScene(io::IWriteFile* file, scene::ISceneNode* root, int writeRoot)
{
	if (!file || !root)
		return false;

	reset();

	Writer = FileSystem->createXMLWriterUTF8(file);

	if (!Writer)
	{
		os::Printer::log("Could not write file", file->getFileName());
		return false;
	}

	Directory = FileSystem->getFileDir(FileSystem->getAbsolutePath( file->getFileName() ));

	// make names for all nodes with exportable meshes
	makeMeshNames(root);

	os::Printer::log("Writing scene", file->getFileName());

	// write COLLADA header

	Writer->writeXMLHeader();

	Writer->writeElement("COLLADA", false,
		"xmlns", "http://www.collada.org/2005/11/COLLADASchema",
		"version", "1.4.1");
	Writer->writeLineBreak();

	// write asset data
	writeAsset();

	// write all materials
	Writer->writeElement("library_materials", false);
	Writer->writeLineBreak();
	writeNodeMaterials(root);
	Writer->writeClosingTag("library_materials");
	Writer->writeLineBreak();

	Writer->writeElement("library_effects", false);
	Writer->writeLineBreak();
	writeNodeEffects(root);
	Writer->writeClosingTag("library_effects");
	Writer->writeLineBreak();


	// images
	writeLibraryImages();

	// lights
	Writer->writeElement("library_lights", false);
	Writer->writeLineBreak();

	writeAmbientLightElement( getAmbientLight() );
	writeNodeLights(root);

	Writer->writeClosingTag("library_lights");
	Writer->writeLineBreak();

	// cameras
	Writer->writeElement("library_cameras", false);
	Writer->writeLineBreak();
	writeNodeCameras(root);
	Writer->writeClosingTag("library_cameras");
	Writer->writeLineBreak();

	// write meshes
	Writer->writeElement("library_geometries", false);
	Writer->writeLineBreak();
	writeAllMeshGeometries();
	Writer->writeClosingTag("library_geometries");
	Writer->writeLineBreak();

	// write scene
	Writer->writeElement("library_visual_scenes", false);
	Writer->writeLineBreak();
	Writer->writeElement("visual_scene", false, "id", "default_scene");
	Writer->writeLineBreak();

		// ambient light (instance_light also needs a node as parent so we have to create one)
		Writer->writeElement("node", false);
		Writer->writeLineBreak();
		Writer->writeElement("instance_light", true, "url", "#ambientlight");
		Writer->writeLineBreak();
		Writer->writeClosingTag("node");
		Writer->writeLineBreak();

		// Write the scenegraph.
		if ( writeRoot == 2 || (writeRoot == 1 && root->getType() != ESNT_SCENE_MANAGER) )
		{
			// TODO: Not certain if we should really write the root or if we should just always only write the children.
			// For now writing root to keep backward compatibility for this case, but if anyone needs to _not_ write
			// that root-node we can add a parameter for this later on in writeScene.
			writeSceneNode(root);
		}
		else
		{
			// The visual_scene element is identical to our scenemanager and acts as root,
			// so we do not write the root itself if it points to the scenemanager.
			const core::list<ISceneNode*>& rootChildren = root->getChildren();
			for ( core::list<ISceneNode*>::ConstIterator it = rootChildren.begin();
					it != rootChildren.end();
					++ it )
			{
				writeSceneNode(*it);
			}
		}


	Writer->writeClosingTag("visual_scene");
	Writer->writeLineBreak();
	Writer->writeClosingTag("library_visual_scenes");
	Writer->writeLineBreak();


	// instance scene
	Writer->writeElement("scene", false);
	Writer->writeLineBreak();

		Writer->writeElement("instance_visual_scene", true, "url", "#default_scene");
		Writer->writeLineBreak();

	Writer->writeClosingTag("scene");
	Writer->writeLineBreak();


	// close everything

	Writer->writeClosingTag("COLLADA");
	Writer->drop();

	return true;
}

void CColladaMeshWriter::makeMeshNames(irr::scene::ISceneNode * node)
{
	if ( !node || !getProperties() || !getProperties()->isExportable(node) || !getNameGenerator())
		return;

	IMesh* mesh = getProperties()->getMesh(node);
	if ( mesh )
	{
		if ( !Meshes.find(mesh) )
		{
			SColladaMesh cm;
			cm.Name = nameForMesh(mesh, 0);
			Meshes.insert(mesh, cm);
		}
	}

	const core::list<ISceneNode*>& children = node->getChildren();
	for ( core::list<ISceneNode*>::ConstIterator it = children.begin(); it != children.end(); ++it )
	{
		makeMeshNames(*it);
	}
}

void CColladaMeshWriter::writeNodeMaterials(irr::scene::ISceneNode * node)
{
	if ( !node || !getProperties() || !getProperties()->isExportable(node) )
		return;

	core::array<irr::core::stringc> materialNames;

	IMesh* mesh = getProperties()->getMesh(node);
	if ( mesh )
	{
		MeshNode * n = Meshes.find(mesh);
		if ( !getProperties()->useNodeMaterial(node) )
		{
			// no material overrides - write mesh materials
			if ( n && !n->getValue().MaterialsWritten )
			{
				writeMeshMaterials(mesh, getGeometryWriting() == ECGI_PER_MESH_AND_MATERIAL ? &materialNames : NULL);
				n->getValue().MaterialsWritten = true;
			}
		}
		else
		{
			// write node materials
			for (u32 i=0; i<node->getMaterialCount(); ++i)
			{
				video::SMaterial & material = node->getMaterial(i);
				core::stringc strMat(nameForMaterial(material, i, mesh, node));
				writeMaterial(strMat);
				if ( getGeometryWriting() == ECGI_PER_MESH_AND_MATERIAL )
					materialNames.push_back(strMat);
			}
		}

		// When we write another mesh-geometry for each new material-list we have
		// to figure out here if we need another geometry copy and create a new name here.
		if ( n && getGeometryWriting() == ECGI_PER_MESH_AND_MATERIAL )
		{
			SGeometryMeshMaterials * geomMat = n->getValue().findGeometryMeshMaterials(materialNames);
			if ( geomMat )
				geomMat->MaterialOwners.push_back(node);
			else
			{
				SGeometryMeshMaterials gmm;
				if ( n->getValue().GeometryMeshMaterials.empty() )
					gmm.GeometryName = n->getValue().Name;	// first one can use the original name
				else
					gmm.GeometryName = 	nameForMesh(mesh, n->getValue().GeometryMeshMaterials.size());
				gmm.MaterialNames = materialNames;
				gmm.MaterialOwners.push_back(node);
				n->getValue().GeometryMeshMaterials.push_back(gmm);
			}
		}
	}

	const core::list<ISceneNode*>& children = node->getChildren();
	for ( core::list<ISceneNode*>::ConstIterator it = children.begin(); it != children.end(); ++it )
	{
		writeNodeMaterials( *it );
	}
}

void CColladaMeshWriter::writeMaterial(const irr::core::stringc& materialname)
{
	if ( MaterialsWritten.find(materialname) )
		return;
	MaterialsWritten.insert(materialname, true);

	Writer->writeElement("material", false,
		"id", materialname.c_str(),
		"name", materialname.c_str());
	Writer->writeLineBreak();

	// We don't make a difference between material and effect on export.
	// Every material is just using an instance of an effect.
	core::stringc strFx(materialname);
	strFx += "-fx";
	Writer->writeElement("instance_effect", true,
		"url", (core::stringc("#") + strFx).c_str());
	Writer->writeLineBreak();

	Writer->writeClosingTag("material");
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeNodeEffects(irr::scene::ISceneNode * node)
{
	if ( !node || !getProperties() || !getProperties()->isExportable(node) || !getNameGenerator() )
		return;

	IMesh* mesh = getProperties()->getMesh(node);
	if ( mesh )
	{
		if ( !getProperties()->useNodeMaterial(node) )
		{
			// no material overrides - write mesh materials
			MeshNode * n = Meshes.find(mesh);
			if ( n  && !n->getValue().EffectsWritten )
			{
				writeMeshEffects(mesh);
				n->getValue().EffectsWritten = true;
			}
		}
		else
		{
			// write node materials
			for (u32 i=0; i<node->getMaterialCount(); ++i)
			{
				video::SMaterial & material = node->getMaterial(i);
				irr::core::stringc materialfxname(nameForMaterial(material, i, mesh, node));
				materialfxname += "-fx";
				writeMaterialEffect(materialfxname, material);
			}
		}
	}

	const core::list<ISceneNode*>& children = node->getChildren();
	for ( core::list<ISceneNode*>::ConstIterator it = children.begin(); it != children.end(); ++it )
	{
		writeNodeEffects( *it );
	}
}

void CColladaMeshWriter::writeNodeLights(irr::scene::ISceneNode * node)
{
	if ( !node || !getProperties() || !getProperties()->isExportable(node))
		return;

	if ( node->getType() == ESNT_LIGHT )
	{
		ILightSceneNode * lightNode = static_cast<ILightSceneNode*>(node);
		const video::SLight& lightData = lightNode->getLightData();

		SColladaLight cLight;
		cLight.Name = nameForNode(node);
		LightNodes.insert(node, cLight);

		Writer->writeElement("light", false, "id", cLight.Name.c_str());
		Writer->writeLineBreak();

		Writer->writeElement("technique_common", false);
		Writer->writeLineBreak();

		switch ( lightNode->getLightType() )
		{
			case video::ELT_POINT:
				Writer->writeElement("point", false);
				Writer->writeLineBreak();

				writeColorElement(lightData.DiffuseColor, false);
				writeNode("constant_attenuation ", core::stringc(lightData.Attenuation.X).c_str());
				writeNode("linear_attenuation  ", core::stringc(lightData.Attenuation.Y).c_str());
				writeNode("quadratic_attenuation", core::stringc(lightData.Attenuation.Z).c_str());

				Writer->writeClosingTag("point");
				Writer->writeLineBreak();
				break;

			case video::ELT_SPOT:
				Writer->writeElement("spot", false);
				Writer->writeLineBreak();

				writeColorElement(lightData.DiffuseColor, false);

				writeNode("constant_attenuation ", core::stringc(lightData.Attenuation.X).c_str());
				writeNode("linear_attenuation  ", core::stringc(lightData.Attenuation.Y).c_str());
				writeNode("quadratic_attenuation", core::stringc(lightData.Attenuation.Z).c_str());

				writeNode("falloff_angle", core::stringc(lightData.OuterCone * core::RADTODEG).c_str());
				writeNode("falloff_exponent", core::stringc(lightData.Falloff).c_str());

				Writer->writeClosingTag("spot");
				Writer->writeLineBreak();
				break;

			case video::ELT_DIRECTIONAL:
				Writer->writeElement("directional", false);
				Writer->writeLineBreak();

				writeColorElement(lightData.DiffuseColor, false);

				Writer->writeClosingTag("directional");
				Writer->writeLineBreak();
				break;
			default:
				break;
		}

		Writer->writeClosingTag("technique_common");
		Writer->writeLineBreak();

		Writer->writeClosingTag("light");
		Writer->writeLineBreak();

	}

	const core::list<ISceneNode*>& children = node->getChildren();
	for ( core::list<ISceneNode*>::ConstIterator it = children.begin(); it != children.end(); ++it )
	{
		writeNodeLights( *it );
	}
}

void CColladaMeshWriter::writeNodeCameras(irr::scene::ISceneNode * node)
{
	if ( !node || !getProperties() || !getProperties()->isExportable(node) )
		return;

	if ( isCamera(node) )
	{
		ICameraSceneNode * cameraNode = static_cast<ICameraSceneNode*>(node);
		irr::core::stringc name = nameForNode(node);
		CameraNodes.insert(cameraNode, name);

		Writer->writeElement("camera", false, "id", name.c_str());
		Writer->writeLineBreak();

		Writer->writeElement("optics", false);
		Writer->writeLineBreak();

		Writer->writeElement("technique_common", false);
		Writer->writeLineBreak();

		if ( cameraNode->isOrthogonal() )
		{
			Writer->writeElement("orthographic", false);
			Writer->writeLineBreak();

			irr::core::matrix4 projMat( cameraNode->getProjectionMatrix() );
			irr::f32 xmag = 2.f/projMat[0];
			irr::f32 ymag = 2.f/projMat[5];

			// Note that Irrlicht camera does not update near/far when setting the projection matrix,
			// so we have to calculate that here (at least currently - maybe camera code will be updated at some time).
			irr::f32 nearMinusFar = -1.f/projMat[10];
			irr::f32 zNear = projMat[14]*nearMinusFar;
			irr::f32 zFar = 1.f/projMat[10] + zNear;

			writeNode("xmag", core::stringc(xmag).c_str());
			writeNode("ymag", core::stringc(ymag).c_str());
			writeNode("znear", core::stringc(zNear).c_str());
			writeNode("zfar", core::stringc(zFar).c_str());

			Writer->writeClosingTag("orthographic");
			Writer->writeLineBreak();
		}
		else
		{
			Writer->writeElement("perspective", false);
			Writer->writeLineBreak();

			writeNode("yfov", core::stringc(cameraNode->getFOV()*core::RADTODEG).c_str());
			writeNode("aspect_ratio", core::stringc(cameraNode->getAspectRatio()).c_str());
			writeNode("znear", core::stringc(cameraNode->getNearValue()).c_str());
			writeNode("zfar", core::stringc(cameraNode->getFarValue()).c_str());

			Writer->writeClosingTag("perspective");
			Writer->writeLineBreak();
		}

		Writer->writeClosingTag("technique_common");
		Writer->writeLineBreak();

		Writer->writeClosingTag("optics");
		Writer->writeLineBreak();

		Writer->writeClosingTag("camera");
		Writer->writeLineBreak();
	}

	const core::list<ISceneNode*>& children = node->getChildren();
	for ( core::list<ISceneNode*>::ConstIterator it = children.begin(); it != children.end(); ++it )
	{
		writeNodeCameras( *it );
	}
}

void CColladaMeshWriter::writeAllMeshGeometries()
{
	core::map<IMesh*, SColladaMesh>::ConstIterator it = Meshes.getConstIterator();
	for(; !it.atEnd(); it++ )
	{
		IMesh* mesh = it->getKey();
		const SColladaMesh& colladaMesh = it->getValue();

		if ( getGeometryWriting() == ECGI_PER_MESH_AND_MATERIAL && colladaMesh.GeometryMeshMaterials.size() > 1 )
		{
			for ( u32 i=0; i<colladaMesh.GeometryMeshMaterials.size(); ++i )
			{
				writeMeshGeometry(colladaMesh.GeometryMeshMaterials[i].GeometryName, mesh);
			}
		}
		else
		{
			writeMeshGeometry(colladaMesh.Name, mesh);
		}
	}
}

void CColladaMeshWriter::writeSceneNode(irr::scene::ISceneNode * node )
{
	if ( !node || !getProperties() || !getProperties()->isExportable(node) )
		return;

	// Collada doesn't require to set the id, but some other tools have problems if none exists, so we just add it.
	irr::core::stringc nameId(nameForNode(node));
	Writer->writeElement("node", false, "id", nameId.c_str());
	Writer->writeLineBreak();

	// DummyTransformationSceneNode don't have rotation, position, scale information
	// But also don't always export the transformation matrix as that forces us creating
	// new DummyTransformationSceneNode's on import.
	if ( node->getType() == ESNT_DUMMY_TRANSFORMATION )
	{
		writeMatrixElement(node->getRelativeTransformation());
	}
	else if ( isCamera(node) )
	{
		// TODO: We do not handle the case when ICameraSceneNode::getTargetAndRotationBinding() is false. Probably we would have to create a second
		// node to do that.

		// Note: We can't use rotations for the camera as Irrlicht does not regard the up-vector in rotations so far.
		// We could maybe use projection matrices, but avoiding them might allow us to get rid of some DummyTransformationSceneNodes on
		// import in the future. So that's why we use the lookat element instead.

		ICameraSceneNode * camNode = static_cast<ICameraSceneNode*>(node);
		writeLookAtElement(camNode->getPosition(), camNode->getTarget(), camNode->getUpVector());
	}
	else
	{
		writeTranslateElement( node->getPosition() );

		irr::core::vector3df rot(node->getRotation());
		core::quaternion quat(rot*core::DEGTORAD);
		f32 angle;
		core::vector3df axis;
		quat.toAngleAxis(angle, axis);
		writeRotateElement( axis, angle*core::RADTODEG );

		writeScaleElement( node->getScale() );
	}

	// instance geometry
	IMesh* mesh = getProperties()->getMesh(node);
	if ( mesh )
	{
		MeshNode * n = Meshes.find(mesh);
		if ( n )
		{
			const SColladaMesh& colladaMesh = n->getValue();
			writeMeshInstanceGeometry(colladaMesh.findGeometryNameForNode(node), mesh, node);
		}
	}

	// instance light
	if ( node->getType() == ESNT_LIGHT )
	{
		LightNode * n = LightNodes.find(node);
		if ( n )
			writeLightInstance(n->getValue().Name);
	}

	// instance camera
	if ( isCamera(node) )
	{
		CameraNode * camNode = CameraNodes.find(node);
		if ( camNode )
			writeCameraInstance(camNode->getValue());
	}

	const core::list<ISceneNode*>& children = node->getChildren();
	for ( core::list<ISceneNode*>::ConstIterator it = children.begin(); it != children.end(); ++it )
	{
		writeSceneNode( *it );
	}

	Writer->writeClosingTag("node");
	Writer->writeLineBreak();
}

//! writes a mesh
bool CColladaMeshWriter::writeMesh(io::IWriteFile* file, scene::IMesh* mesh, s32 flags)
{
	if (!file)
		return false;

	reset();

	Writer = FileSystem->createXMLWriterUTF8(file);

	if (!Writer)
	{
		os::Printer::log("Could not write file", file->getFileName());
		return false;
	}

	Directory = FileSystem->getFileDir(FileSystem->getAbsolutePath( file->getFileName() ));

	os::Printer::log("Writing mesh", file->getFileName());

	// write COLLADA header

	Writer->writeXMLHeader();

	Writer->writeElement("COLLADA", false,
		"xmlns", "http://www.collada.org/2005/11/COLLADASchema",
		"version", "1.4.1");
	Writer->writeLineBreak();

	// write asset data
	writeAsset();

	// write all materials

	Writer->writeElement("library_materials", false);
	Writer->writeLineBreak();

	writeMeshMaterials(mesh);

	Writer->writeClosingTag("library_materials");
	Writer->writeLineBreak();

	Writer->writeElement("library_effects", false);
	Writer->writeLineBreak();

	writeMeshEffects(mesh);

	Writer->writeClosingTag("library_effects");
	Writer->writeLineBreak();

	// images
	writeLibraryImages();

	// write mesh

	Writer->writeElement("library_geometries", false);
	Writer->writeLineBreak();

	irr::core::stringc meshname(nameForMesh(mesh, 0));
	writeMeshGeometry(meshname, mesh);

	Writer->writeClosingTag("library_geometries");
	Writer->writeLineBreak();

	// write scene_library
	if ( getWriteDefaultScene() )
	{
		Writer->writeElement("library_visual_scenes", false);
		Writer->writeLineBreak();

		Writer->writeElement("visual_scene", false, "id", "default_scene");
		Writer->writeLineBreak();

			Writer->writeElement("node", false);
			Writer->writeLineBreak();

				writeMeshInstanceGeometry(meshname, mesh);

			Writer->writeClosingTag("node");
			Writer->writeLineBreak();

		Writer->writeClosingTag("visual_scene");
		Writer->writeLineBreak();

		Writer->writeClosingTag("library_visual_scenes");
		Writer->writeLineBreak();


		// write scene
		Writer->writeElement("scene", false);
		Writer->writeLineBreak();

			Writer->writeElement("instance_visual_scene", true, "url", "#default_scene");
			Writer->writeLineBreak();

		Writer->writeClosingTag("scene");
		Writer->writeLineBreak();
	}


	// close everything

	Writer->writeClosingTag("COLLADA");
	Writer->drop();

	return true;
}

void CColladaMeshWriter::writeMeshInstanceGeometry(const irr::core::stringc& meshname, scene::IMesh* mesh, scene::ISceneNode* node)
{
	//<instance_geometry url="#mesh">
	Writer->writeElement("instance_geometry", false, "url", toRef(meshname).c_str());
	Writer->writeLineBreak();

		Writer->writeElement("bind_material", false);
		Writer->writeLineBreak();

			Writer->writeElement("technique_common", false);
			Writer->writeLineBreak();

			// instance materials
			// <instance_material symbol="leaf" target="#MidsummerLeaf01"/>
			bool useNodeMaterials = node && node->getMaterialCount() == mesh->getMeshBufferCount();
			for (u32 i=0; i<mesh->getMeshBufferCount(); ++i)
			{
				irr::core::stringc strMatSymbol(nameForMaterialSymbol(mesh, i));
				core::stringc strMatTarget = "#";
				video::SMaterial & material = useNodeMaterials ? node->getMaterial(i) : mesh->getMeshBuffer(i)->getMaterial();
				strMatTarget += nameForMaterial(material, i, mesh, node);
				Writer->writeElement("instance_material", false, "symbol", strMatSymbol.c_str(), "target", strMatTarget.c_str());
				Writer->writeLineBreak();

					// TODO: need to handle second UV-set
					// <bind_vertex_input semantic="uv" input_semantic="TEXCOORD" input_set="0"/>
					Writer->writeElement("bind_vertex_input", true, "semantic", "uv", "input_semantic", "TEXCOORD", "input_set", "0" );
					Writer->writeLineBreak();

				Writer->writeClosingTag("instance_material");
				Writer->writeLineBreak();
			}

			Writer->writeClosingTag("technique_common");
			Writer->writeLineBreak();

		Writer->writeClosingTag("bind_material");
		Writer->writeLineBreak();

	Writer->writeClosingTag("instance_geometry");
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeLightInstance(const irr::core::stringc& lightName)
{
	Writer->writeElement("instance_light", true, "url", toRef(lightName).c_str());
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeCameraInstance(const irr::core::stringc& cameraName)
{
	Writer->writeElement("instance_camera", true, "url", toRef(cameraName).c_str());
	Writer->writeLineBreak();
}

bool CColladaMeshWriter::hasSecondTextureCoordinates(video::E_VERTEX_TYPE type) const
{
	return type == video::EVT_2TCOORDS;
}

void CColladaMeshWriter::writeVector(const irr::core::vector3df& vec)
{
	c8 tmpbuf[255];

	snprintf_irr(tmpbuf, 255, "%f", vec.X);
	WriteBuffer = tmpbuf;
	WriteBuffer.eraseTrailingFloatZeros();

	snprintf_irr(tmpbuf, 255, " %f", vec.Y);
	WriteBuffer.append(tmpbuf);
	WriteBuffer.eraseTrailingFloatZeros();

	snprintf_irr(tmpbuf, 255, " %f", vec.Z*-1.f);	// 	change handedness
	WriteBuffer.append(tmpbuf);
	WriteBuffer.eraseTrailingFloatZeros();

	Writer->writeText(WriteBuffer.c_str());
}

void CColladaMeshWriter::writeUv(const irr::core::vector2df& vec)
{
	c8 tmpbuf[255];

	snprintf_irr(tmpbuf, 255, "%f", vec.X);
	WriteBuffer = tmpbuf;
	WriteBuffer.eraseTrailingFloatZeros();

	snprintf_irr(tmpbuf, 255, " %f", 1.f-vec.Y);	// 	change handedness
	WriteBuffer.append(tmpbuf);
	WriteBuffer.eraseTrailingFloatZeros();

	Writer->writeText(WriteBuffer.c_str());
}

void CColladaMeshWriter::writeColor(const irr::video::SColorf& colorf, bool writeAlpha)
{
	c8 tmpbuf[255];

	snprintf_irr(tmpbuf, 255, "%f", colorf.getRed());
	WriteBuffer = tmpbuf;
	WriteBuffer.eraseTrailingFloatZeros();

	snprintf_irr(tmpbuf, 255, " %f", colorf.getGreen());
	WriteBuffer.append(tmpbuf);
	WriteBuffer.eraseTrailingFloatZeros();

	snprintf_irr(tmpbuf, 255, " %f", colorf.getBlue());
	WriteBuffer.append(tmpbuf);
	WriteBuffer.eraseTrailingFloatZeros();

	if ( writeAlpha )
	{
		snprintf_irr(tmpbuf, 255, " %f", colorf.getAlpha());
		WriteBuffer.append(tmpbuf);
		WriteBuffer.eraseTrailingFloatZeros();
	}

	Writer->writeText(WriteBuffer.c_str());
}

irr::core::stringc CColladaMeshWriter::toString(const irr::video::ECOLOR_FORMAT format) const
{
	switch ( format )
	{
		case video::ECF_A1R5G5B5:	return irr::core::stringc("A1R5G5B5");
		case video::ECF_R5G6B5:		return irr::core::stringc("R5G6B5");
		case video::ECF_R8G8B8:		return irr::core::stringc("R8G8B8");
		case video::ECF_A8R8G8B8:	return irr::core::stringc("A8R8G8B8");
		default:					return irr::core::stringc("");
	}
}

irr::core::stringc CColladaMeshWriter::toString(const irr::video::E_TEXTURE_CLAMP clamp) const
{
	switch ( clamp )
	{
		case video::ETC_REPEAT:
			return core::stringc("WRAP");
		case video::ETC_CLAMP:
		case video::ETC_CLAMP_TO_EDGE:
			return core::stringc("CLAMP");
		case video::ETC_CLAMP_TO_BORDER:
			return core::stringc("BORDER");
		case video::ETC_MIRROR:
		case video::ETC_MIRROR_CLAMP:
		case video::ETC_MIRROR_CLAMP_TO_EDGE:
		case video::ETC_MIRROR_CLAMP_TO_BORDER:
			return core::stringc("MIRROR");
	}
	return core::stringc("NONE");
}

irr::core::stringc CColladaMeshWriter::toString(const irr::scene::E_COLLADA_TRANSPARENT_FX transparent) const
{
	if ( transparent & ECOF_RGB_ZERO )
		return core::stringc("RGB_ZERO");
	else
		return core::stringc("A_ONE");
}

irr::core::stringc CColladaMeshWriter::toRef(const irr::core::stringc& source) const
{
	irr::core::stringc ref("#");
	ref += source;
	return ref;
}

bool CColladaMeshWriter::isCamera(const scene::ISceneNode* node) const
{
	// TODO: we need some ISceneNode::hasType() function to get rid of those checks
	if (	node->getType() == ESNT_CAMERA
		||	node->getType() == ESNT_CAMERA_MAYA
		||	node->getType() == ESNT_CAMERA_FPS )
		return true;
	return false;
}

irr::core::stringc CColladaMeshWriter::nameForMesh(const scene::IMesh* mesh, int instance) const
{
	IColladaMeshWriterNames * nameGenerator = getNameGenerator();
	if ( nameGenerator )
	{
		return nameGenerator->nameForMesh(mesh, instance);
	}
	return irr::core::stringc("missing_name_generator");
}

irr::core::stringc CColladaMeshWriter::nameForNode(const scene::ISceneNode* node) const
{
	IColladaMeshWriterNames * nameGenerator = getNameGenerator();
	if ( nameGenerator )
	{
		return nameGenerator->nameForNode(node);
	}
	return irr::core::stringc("missing_name_generator");
}

irr::core::stringc CColladaMeshWriter::nameForMaterial(const video::SMaterial & material, int materialId, const scene::IMesh* mesh, const scene::ISceneNode* node)
{
	irr::core::stringc matName;
	if ( getExportSMaterialsOnlyOnce() )
	{
		matName = findCachedMaterialName(material);
		if ( !matName.empty() )
			return matName;
	}

	IColladaMeshWriterNames * nameGenerator = getNameGenerator();
	if ( nameGenerator )
	{
		matName = nameGenerator->nameForMaterial(material, materialId, mesh, node);
	}
	else
		matName = irr::core::stringc("missing_name_generator");

	if ( getExportSMaterialsOnlyOnce() )
		MaterialNameCache.push_back (MaterialName(material, matName));
	return matName;
}

// Each mesh-material has one symbol which is replaced on instantiation
irr::core::stringc CColladaMeshWriter::nameForMaterialSymbol(const scene::IMesh* mesh, int materialId) const
{
	c8 buf[100];
	snprintf_irr(buf, 100, "mat_symb_%p_%d", mesh, materialId);
	return irr::core::stringc(buf);
}

irr::core::stringc CColladaMeshWriter::findCachedMaterialName(const irr::video::SMaterial& material) const
{
	for ( u32 i=0; i<MaterialNameCache.size(); ++i )
	{
		if ( MaterialNameCache[i].Material == material )
			return MaterialNameCache[i].Name;
	}
	return irr::core::stringc();
}

irr::core::stringc CColladaMeshWriter::minTexfilterToString(bool bilinear, bool trilinear) const
{
	if ( trilinear )
		return core::stringc("LINEAR_MIPMAP_LINEAR");
	else if ( bilinear )
		return core::stringc("LINEAR_MIPMAP_NEAREST");

	return core::stringc("NONE");
}

inline irr::core::stringc CColladaMeshWriter::magTexfilterToString(bool bilinear, bool trilinear) const
{
	if ( bilinear || trilinear )
		return core::stringc("LINEAR");

	return core::stringc("NONE");
}

bool CColladaMeshWriter::isXmlNameStartChar(c8 c) const
{
	return	   (c >= 'A' && c <= 'Z')
			||	c == '_'
			||	(c >= 'a' && c <= 'z');
			/*	Following would also be legal, but only when using real unicode.
				We do only check ansi codes as they are sufficient for us.
 			||	(c >= 0xC0 && c <= 0xD6)
			||	(c >= 0xD8 && c <= 0xF6)
			||	(c >= 0xF8 && c <= 0x2FF)
			||	(c >= 0x370 && c <= 0x37D)
			||  (c >= 0x37F && c <= 0x1FFF)
			||  (c >= 0x200C && c <= 0x200D)
			||  (c >= 0x2070 && c <= 0x218F)
			||  (c >= 0x2C00 && c <= 0x2FEF)
			||  (c >= 0x3001 && c <= 0xD7FF)
			||  (c >= 0xF900 && c <= 0xFDCF)
			||  (c >= 0xFDF0 && c <= 0xFFFD)
			||  (c >= 0x10000 && c <=0xEFFFF)
*/
			;
}

bool CColladaMeshWriter::isXmlNameChar(c8 c) const
{
	return isXmlNameStartChar(c)
		||	c == '-'
		||	c == '.'
		||	(c >= '0' && c <= '9');
		/*	Following would also be legal, but only when using real unicode.
			We do only check ansi codes for now as they are sufficient for us.
		 ||	c == 0xB7
		 ||	(c >= 9x0300 && c <= 0x036F)
		 ||	(c >= 0x203F && c <= 0x2040)
		 */
}

// Restrict the characters to a set of allowed characters in xs:NCName.
irr::core::stringc CColladaMeshWriter::toNCName(const irr::core::stringc& oldString, const irr::core::stringc& prefix) const
{
	irr::core::stringc result(prefix);	// help to ensure id starts with a valid char and reduce chance of name-conflicts
	if ( oldString.empty() )
		return result;

	result.append( oldString );

	// We replace all characters not allowed by a replacement char
	const c8 REPLACMENT = '-';
	for ( irr::u32 i=1; i < result.size(); ++i )
	{
		if ( result[i] == ':' || !isXmlNameChar(result[i]) )
		{
			result[i] = REPLACMENT;
		}
	}
	return result;
}

const irr::core::stringc* CColladaMeshWriter::findGeometryNameForNode(ISceneNode* node)
{
	IMesh* mesh = getProperties()->getMesh(node);
	if ( !mesh )
		return NULL;

	MeshNode * n = Meshes.find(mesh);
	if ( !n )
		return NULL;

	const SColladaMesh& colladaMesh = n->getValue();
	return &colladaMesh.findGeometryNameForNode(node);
}

// Restrict the characters to a set of allowed characters in xs:anyURI
irr::core::stringc CColladaMeshWriter::pathToURI(const irr::io::path& path) const
{
	irr::core::stringc result;

	// is this a relative path?
	if ( path.size() > 1
		&& path[0] != _IRR_TEXT('/')
		&& path[0] != _IRR_TEXT('\\')
		&& path[1] != _IRR_TEXT(':') )
	{
		// not already starting with "./" ?
		if (	path[0] != _IRR_TEXT('.')
			||	path[1] != _IRR_TEXT('/') )
		{
			result.append("./");
		}
	}
	result.append(path);

	// Make correct URI (without whitespace)
	u32 len = result.size();
	for (u32 i=0; i<len; ++i)
	{
		for (u32 e = 0; e < EscapeCharsAnyURI.size(); ++e)
		{
			if (result[i] == EscapeCharsAnyURI[e].Character)
			{
				// escape characters should always be at least 3 characters
				const u32 addLen = EscapeCharsAnyURI[e].Escape.size() - 1;
				result[i] = EscapeCharsAnyURI[e].Escape[0];	// replace first one
				result.insert(i+1, &EscapeCharsAnyURI[e].Escape[1], addLen); // insert rest
				i += addLen;
				len += addLen;
				break;
			}
		}
	}


	return result;
}

void CColladaMeshWriter::writeAsset()
{
	Writer->writeElement("asset", false);
	Writer->writeLineBreak();

	Writer->writeElement("contributor", false);
	Writer->writeLineBreak();
	Writer->writeElement("authoring_tool", false);
	Writer->writeText("Irrlicht Engine");
	Writer->writeClosingTag("authoring_tool");
	Writer->writeLineBreak();
	Writer->writeClosingTag("contributor");
	Writer->writeLineBreak();

	// The next two are required
	Writer->writeElement("created", false);
	Writer->writeText("2008-01-31T00:00:00Z");
	Writer->writeClosingTag("created");
	Writer->writeLineBreak();

	Writer->writeElement("modified", false);
	Writer->writeText("2008-01-31T00:00:00Z");
	Writer->writeClosingTag("modified");
	Writer->writeLineBreak();

	// Revision 2.0 changes (since 1.0):
	// - All coordinates are now written with right-handed coordinate system.
	//   Before only texture V of first textures was swapped and all other 
	//   parameters where exported left-handed.
	//   For specific changes change svn revision 5708.
	// - authoring_tool no longer mentions IrrEdit (this code has originated 
	//   from irrEdit 0.7) to avoid conflicts as the software is now
	//   independent of each other and we're not aware of irrEdit revision numbers.
	Writer->writeElement("revision", false);
	Writer->writeText("2.0");	
	Writer->writeClosingTag("revision");
	Writer->writeLineBreak();

	Writer->writeElement("unit", true, "meter", core::stringc(getUnitMeter()).eraseTrailingFloatZeros().c_str(), "name", getUnitName().c_str());
	Writer->writeLineBreak();

	Writer->writeClosingTag("asset");
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeMeshMaterials(scene::IMesh* mesh, irr::core::array<irr::core::stringc> * materialNamesOut)
{
	u32 i;
	for (i=0; i<mesh->getMeshBufferCount(); ++i)
	{
		video::SMaterial & material = mesh->getMeshBuffer(i)->getMaterial();
		core::stringc strMat(nameForMaterial(material, i, mesh, NULL));
		writeMaterial(strMat);
		if ( materialNamesOut )
			materialNamesOut->push_back(strMat);
	}
}

void CColladaMeshWriter::writeMaterialEffect(const irr::core::stringc& materialfxname, const video::SMaterial & material)
{
	if ( EffectsWritten.find(materialfxname) )
		return;
	EffectsWritten.insert(materialfxname, true);

	Writer->writeElement("effect", false,
		"id", materialfxname.c_str(),
		"name", materialfxname.c_str());
	Writer->writeLineBreak();
	Writer->writeElement("profile_COMMON", false);
	Writer->writeLineBreak();

	int numTextures = 0;
	if ( getWriteTextures() )
	{
		// write texture surfaces and samplers and buffer all used imagess
		for ( int t=0; t<4; ++t )
		{
			const video::SMaterialLayer& layer  = material.TextureLayer[t];
			if ( !layer.Texture )
				break;
			++numTextures;

			if ( LibraryImages.linear_search(layer.Texture) < 0 )
					LibraryImages.push_back( layer.Texture );

			irr::core::stringc texName("tex");
			texName += irr::core::stringc(t);

			// write texture surface
			//<newparam sid="tex0-surface">
			irr::core::stringc texSurface(texName);
			texSurface += "-surface";
			Writer->writeElement("newparam", false, "sid", texSurface.c_str());
			Writer->writeLineBreak();
			//  <surface type="2D">
				Writer->writeElement("surface", false, "type", "2D");
				Writer->writeLineBreak();

		//          <init_from>internal_texturename</init_from>
					Writer->writeElement("init_from", false);
					irr::io::path p(FileSystem->getRelativeFilename(layer.Texture->getName().getPath(), Directory));
					Writer->writeText(toNCName(irr::core::stringc(p)).c_str());	// same ID for internal name as in writeLibraryImages
					Writer->writeClosingTag("init_from");
					Writer->writeLineBreak();

		//          <format>A8R8G8B8</format>
					Writer->writeElement("format", false);
					video::ECOLOR_FORMAT format = layer.Texture->getColorFormat();
					Writer->writeText(toString(format).c_str());
					Writer->writeClosingTag("format");
					Writer->writeLineBreak();
		//      </surface>
				Writer->writeClosingTag("surface");
				Writer->writeLineBreak();
		//  </newparam>
			Writer->writeClosingTag("newparam");
			Writer->writeLineBreak();

			// write texture sampler
		//  <newparam sid="tex0-sampler">
			irr::core::stringc texSampler(texName);
			texSampler += "-sampler";
			Writer->writeElement("newparam", false, "sid", texSampler.c_str());
			Writer->writeLineBreak();
		//      <sampler2D>
				Writer->writeElement("sampler2D", false);
				Writer->writeLineBreak();

		//          <source>tex0-surface</source>
					Writer->writeElement("source", false);
					Writer->writeText(texSurface.c_str());
					Writer->writeClosingTag("source");
					Writer->writeLineBreak();

		//			<wrap_s>WRAP</wrap_s>
					Writer->writeElement("wrap_s", false);
					Writer->writeText(toString((video::E_TEXTURE_CLAMP)layer.TextureWrapU).c_str());
					Writer->writeClosingTag("wrap_s");
					Writer->writeLineBreak();

		//			<wrap_t>WRAP</wrap_t>
					Writer->writeElement("wrap_t", false);
					Writer->writeText(toString((video::E_TEXTURE_CLAMP)layer.TextureWrapV).c_str());
					Writer->writeClosingTag("wrap_t");
					Writer->writeLineBreak();

		//			<wrap_p>WRAP</wrap_p>	// TODO: Should only be written in Collada 1.5
					Writer->writeElement("wrap_p", false);
					Writer->writeText(toString((video::E_TEXTURE_CLAMP)layer.TextureWrapW).c_str());
					Writer->writeClosingTag("wrap_p");
					Writer->writeLineBreak();

		//			<minfilter>LINEAR_MIPMAP_LINEAR</minfilter>
					Writer->writeElement("minfilter", false);
					Writer->writeText(minTexfilterToString(layer.BilinearFilter, layer.TrilinearFilter).c_str());
					Writer->writeClosingTag("minfilter");
					Writer->writeLineBreak();

		//			<magfilter>LINEAR</magfilter>
					Writer->writeElement("magfilter", false);
					Writer->writeText(magTexfilterToString(layer.BilinearFilter, layer.TrilinearFilter).c_str());
					Writer->writeClosingTag("magfilter");
					Writer->writeLineBreak();

					// TBD - actually not sure how anisotropic should be written, so for now it writes in a way
					// that works with the way the loader reads it again.
					if ( layer.AnisotropicFilter )
					{
		//			<mipfilter>LINEAR_MIPMAP_LINEAR</mipfilter>
						Writer->writeElement("mipfilter", false);
						Writer->writeText("LINEAR_MIPMAP_LINEAR");
						Writer->writeClosingTag("mipfilter");
						Writer->writeLineBreak();
					}

		//     </sampler2D>
				Writer->writeClosingTag("sampler2D");
				Writer->writeLineBreak();
		//  </newparam>
			Writer->writeClosingTag("newparam");
			Writer->writeLineBreak();
		}
	}

	Writer->writeElement("technique", false, "sid", "common");
	Writer->writeLineBreak();

	E_COLLADA_TECHNIQUE_FX techFx = getProperties() ? getProperties()->getTechniqueFx(material) : ECTF_BLINN;
	writeFxElement(material, techFx);

	Writer->writeClosingTag("technique");
	Writer->writeLineBreak();
	Writer->writeClosingTag("profile_COMMON");
	Writer->writeLineBreak();
	Writer->writeClosingTag("effect");
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeMeshEffects(scene::IMesh* mesh)
{
	for (u32 i=0; i<mesh->getMeshBufferCount(); ++i)
	{
		video::SMaterial & material = mesh->getMeshBuffer(i)->getMaterial();
		irr::core::stringc materialfxname(nameForMaterial(material, i, mesh, NULL));
		materialfxname += "-fx";
		writeMaterialEffect(materialfxname, material);
	}
}

void CColladaMeshWriter::writeMeshGeometry(const irr::core::stringc& meshname, scene::IMesh* mesh)
{
	core::stringc meshId(meshname);

	Writer->writeElement("geometry", false, "id", meshId.c_str(), "name", meshId.c_str());
	Writer->writeLineBreak();
	Writer->writeElement("mesh");
	Writer->writeLineBreak();

	// do some statistics for the mesh to know which stuff needs to be saved into
	// the file:
	// - count vertices
	// - check for the need of a second texture coordinate
	// - count amount of second texture coordinates
	// - check for the need of tangents (TODO)

	u32 totalVertexCount = 0;
	u32 totalTCoords2Count = 0;
	bool needsTangents = false; // TODO: tangents not supported here yet
	u32 i=0;
	for (i=0; i<mesh->getMeshBufferCount(); ++i)
	{
		totalVertexCount += mesh->getMeshBuffer(i)->getVertexCount();

		if (hasSecondTextureCoordinates(mesh->getMeshBuffer(i)->getVertexType()))
			totalTCoords2Count += mesh->getMeshBuffer(i)->getVertexCount();

		if (!needsTangents)
			needsTangents = mesh->getMeshBuffer(i)->getVertexType() == video::EVT_TANGENTS;
	}

	const irr::u32 mbCount = mesh->getMeshBufferCount();
	SComponentGlobalStartPos* globalIndices = DBG_NEW SComponentGlobalStartPos[mbCount];

	// write positions
	core::stringc meshPosId(meshId);
	meshPosId += "-Pos";
	Writer->writeElement("source", false, "id", meshPosId.c_str());
	Writer->writeLineBreak();

		core::stringc vertexCountStr(totalVertexCount*3);
		core::stringc meshPosArrayId(meshPosId);
		meshPosArrayId += "-array";
		Writer->writeElement("float_array", false, "id", meshPosArrayId.c_str(),
					"count", vertexCountStr.c_str());
		Writer->writeLineBreak();

		for (i=0; i<mbCount; ++i)
		{
			scene::IMeshBuffer* buffer = mesh->getMeshBuffer(i);
			u32 vertexCount = buffer->getVertexCount();

			if ( i == 0 )
				globalIndices[i].PosStartIndex = 0;

			if (i+1 < mbCount)
				globalIndices[i+1].PosStartIndex = globalIndices[i].PosStartIndex + vertexCount;

			u8* vertices = static_cast<u8*>(buffer->getVertices());
			u32 vertexPitch = getVertexPitchFromType(buffer->getVertexType());
			for (u32 j=0; j<vertexCount; ++j)
			{
				writeVector( (*reinterpret_cast<const video::S3DVertex*>(&vertices[j*vertexPitch])).Pos );
				Writer->writeLineBreak();
			}
		}

		Writer->writeClosingTag("float_array");
		Writer->writeLineBreak();

		Writer->writeElement("technique_common", false);
		Writer->writeLineBreak();

		vertexCountStr = core::stringc(totalVertexCount);

			Writer->writeElement("accessor", false, "source", toRef(meshPosArrayId).c_str(),
						"count", vertexCountStr.c_str(), "stride", "3");
			Writer->writeLineBreak();

				Writer->writeElement("param", true, "name", "X", "type", "float");
				Writer->writeLineBreak();
				Writer->writeElement("param", true, "name", "Y", "type", "float");
				Writer->writeLineBreak();
				Writer->writeElement("param", true, "name", "Z", "type", "float");
				Writer->writeLineBreak();

				Writer->writeClosingTag("accessor");
				Writer->writeLineBreak();

		Writer->writeClosingTag("technique_common");
		Writer->writeLineBreak();

	Writer->writeClosingTag("source");
	Writer->writeLineBreak();

	// write texture coordinates

	core::stringc meshTexCoord0Id(meshId);
	meshTexCoord0Id += "-TexCoord0";
	Writer->writeElement("source", false, "id", meshTexCoord0Id.c_str());
	Writer->writeLineBreak();

		vertexCountStr = core::stringc(totalVertexCount*2);
		core::stringc meshTexCoordArrayId(meshTexCoord0Id);
		meshTexCoordArrayId += "-array";
		Writer->writeElement("float_array", false, "id", meshTexCoordArrayId.c_str(),
					"count", vertexCountStr.c_str());
		Writer->writeLineBreak();

		for (i=0; i<mbCount; ++i)
		{
			scene::IMeshBuffer* buffer = mesh->getMeshBuffer(i);
			u32 vertexCount = buffer->getVertexCount();

			if (i==0)
				globalIndices[i].TCoord0StartIndex = 0;

			if (i+1 < mbCount)
				globalIndices[i+1].TCoord0StartIndex = globalIndices[i].TCoord0StartIndex + vertexCount;

			u8* vertices = static_cast<u8*>(buffer->getVertices());
			u32 vertexPitch = getVertexPitchFromType(buffer->getVertexType());
			for (u32 j=0; j<vertexCount; ++j)
			{
				writeUv( (*reinterpret_cast<const video::S3DVertex*>(&vertices[j*vertexPitch])).TCoords );
				Writer->writeLineBreak();
			}
		}

		Writer->writeClosingTag("float_array");
		Writer->writeLineBreak();

		Writer->writeElement("technique_common", false);
		Writer->writeLineBreak();

		vertexCountStr = core::stringc(totalVertexCount);

			Writer->writeElement("accessor", false, "source", toRef(meshTexCoordArrayId).c_str(),
						"count", vertexCountStr.c_str(), "stride", "2");
			Writer->writeLineBreak();

				Writer->writeElement("param", true, "name", ParamNamesUV[0].c_str(), "type", "float");
				Writer->writeLineBreak();
				Writer->writeElement("param", true, "name", ParamNamesUV[1].c_str(), "type", "float");
				Writer->writeLineBreak();

			Writer->writeClosingTag("accessor");
			Writer->writeLineBreak();

		Writer->writeClosingTag("technique_common");
		Writer->writeLineBreak();

	Writer->writeClosingTag("source");
	Writer->writeLineBreak();

	// write normals
	core::stringc meshNormalId(meshId);
	meshNormalId += "-Normal";
	Writer->writeElement("source", false, "id", meshNormalId.c_str());
	Writer->writeLineBreak();

		vertexCountStr = core::stringc(totalVertexCount*3);
		core::stringc meshNormalArrayId(meshNormalId);
		meshNormalArrayId += "-array";
		Writer->writeElement("float_array", false, "id", meshNormalArrayId.c_str(),
					"count", vertexCountStr.c_str());
		Writer->writeLineBreak();

		for (i=0; i<mbCount; ++i)
		{
			scene::IMeshBuffer* buffer = mesh->getMeshBuffer(i);
			u32 vertexCount = buffer->getVertexCount();

			if ( i==0 )
				globalIndices[i].NormalStartIndex = 0;

			if (i+1 < mbCount)
				globalIndices[i+1].NormalStartIndex = globalIndices[i].NormalStartIndex + vertexCount;

			u8* vertices = static_cast<u8*>(buffer->getVertices());
			u32 vertexPitch = getVertexPitchFromType(buffer->getVertexType());
			for (u32 j=0; j<vertexCount; ++j)
			{
				writeVector( (*reinterpret_cast<const video::S3DVertex*>(&vertices[j*vertexPitch])).Normal );
				Writer->writeLineBreak();
			}
		}

		Writer->writeClosingTag("float_array");
		Writer->writeLineBreak();

		Writer->writeElement("technique_common", false);
		Writer->writeLineBreak();

		vertexCountStr = core::stringc(totalVertexCount);

		Writer->writeElement("accessor", false, "source", toRef(meshNormalArrayId).c_str(),
									"count", vertexCountStr.c_str(), "stride", "3");
			Writer->writeLineBreak();

				Writer->writeElement("param", true, "name", "X", "type", "float");
				Writer->writeLineBreak();
				Writer->writeElement("param", true, "name", "Y", "type", "float");
				Writer->writeLineBreak();
				Writer->writeElement("param", true, "name", "Z", "type", "float");
				Writer->writeLineBreak();

			Writer->writeClosingTag("accessor");
			Writer->writeLineBreak();

		Writer->writeClosingTag("technique_common");
		Writer->writeLineBreak();

	Writer->writeClosingTag("source");
	Writer->writeLineBreak();

	// write second set of texture coordinates
	core::stringc meshTexCoord1Id(meshId);
	meshTexCoord1Id += "-TexCoord1";
	if (totalTCoords2Count)
	{
		Writer->writeElement("source", false, "id", meshTexCoord1Id.c_str());
		Writer->writeLineBreak();

			vertexCountStr = core::stringc(totalTCoords2Count*2);
			core::stringc meshTexCoord1ArrayId(meshTexCoord1Id);
			meshTexCoord1ArrayId += "-array";
			Writer->writeElement("float_array", false, "id", meshTexCoord1ArrayId.c_str(),
									"count", vertexCountStr.c_str());
			Writer->writeLineBreak();

			for (i=0; i<mbCount; ++i)
			{
				scene::IMeshBuffer* buffer = mesh->getMeshBuffer(i);
				video::E_VERTEX_TYPE vtxType = buffer->getVertexType();
				u32 vertexCount = 0;

				if (hasSecondTextureCoordinates(vtxType))
				{
					vertexCount = buffer->getVertexCount();
					switch(vtxType)
					{
					case video::EVT_2TCOORDS:
						{
							video::S3DVertex2TCoords* vtx = (video::S3DVertex2TCoords*)buffer->getVertices();
							for (u32 j=0; j<vertexCount; ++j)
							{
								writeUv(vtx[j].TCoords2);
								Writer->writeLineBreak();
							}
						}
						break;
					default:
						break;
					}
				} // end this buffer has 2 texture coordinates

				if ( i == 0 )
					globalIndices[i].TCoord1StartIndex = 0;

				if (i+1 < mbCount)
					globalIndices[i+1].TCoord1StartIndex = globalIndices[i].TCoord1StartIndex + vertexCount;
			}

			Writer->writeClosingTag("float_array");
			Writer->writeLineBreak();

			Writer->writeElement("technique_common", false);
			Writer->writeLineBreak();

			vertexCountStr = core::stringc(totalTCoords2Count);

				Writer->writeElement("accessor", false, "source", toRef(meshTexCoord1ArrayId).c_str(),
										"count", vertexCountStr.c_str(), "stride", "2");
				Writer->writeLineBreak();

					Writer->writeElement("param", true, "name", ParamNamesUV[0].c_str(), "type", "float");
					Writer->writeLineBreak();
					Writer->writeElement("param", true, "name", ParamNamesUV[1].c_str(), "type", "float");
					Writer->writeLineBreak();

				Writer->writeClosingTag("accessor");
				Writer->writeLineBreak();

			Writer->writeClosingTag("technique_common");
			Writer->writeLineBreak();

		Writer->writeClosingTag("source");
		Writer->writeLineBreak();
	}

	// write tangents

	// TODO

	// write vertices
	core::stringc meshVtxId(meshId);
	meshVtxId += "-Vtx";
	Writer->writeElement("vertices", false, "id", meshVtxId.c_str());
	Writer->writeLineBreak();

		Writer->writeElement("input", true, "semantic", "POSITION", "source", toRef(meshPosId).c_str());
		Writer->writeLineBreak();

	Writer->writeClosingTag("vertices");
	Writer->writeLineBreak();

	// write polygons

	for (i=0; i<mbCount; ++i)
	{
		scene::IMeshBuffer* buffer = mesh->getMeshBuffer(i);

		if ( buffer->getPrimitiveType() != EPT_TRIANGLES )
		{
			os::Printer::log("Collada writer does not support non-triangle meshbuffers. Mesh: ", meshname.c_str(), ELL_WARNING);
			continue;
		}

		const u32 polyCount = buffer->getPrimitiveCount();
		core::stringc strPolyCount(polyCount);
		irr::core::stringc strMat(nameForMaterialSymbol(mesh, i));

		Writer->writeElement("triangles", false, "count", strPolyCount.c_str(),
								"material", strMat.c_str());
		Writer->writeLineBreak();

		Writer->writeElement("input", true, "semantic", "VERTEX", "source", toRef(meshVtxId).c_str(), "offset", "0");
		Writer->writeLineBreak();
		Writer->writeElement("input", true, "semantic", "TEXCOORD", "source", toRef(meshTexCoord0Id).c_str(), "offset", "1", "set", "0");
		Writer->writeLineBreak();
		Writer->writeElement("input", true, "semantic", "NORMAL", "source", toRef(meshNormalId).c_str(), "offset", "2");
		Writer->writeLineBreak();

		bool has2ndTexCoords = hasSecondTextureCoordinates(buffer->getVertexType());
		if (has2ndTexCoords)
		{
			// TODO: when working on second uv-set - my suspicion is that this one should be called "TEXCOORD2"
			// to allow bind_vertex_input to differentiate the uv-sets.
			Writer->writeElement("input", true, "semantic", "TEXCOORD", "source", toRef(meshTexCoord1Id).c_str(), "idx", "3");
			Writer->writeLineBreak();
		}

		// write indices now

		// In Collada we us a single global buffer for all vertices, so indices have this offset compared to Irrlicht
		u32 posIdx = globalIndices[i].PosStartIndex;
		u32 tCoordIdx = globalIndices[i].TCoord0StartIndex;
		u32 normalIdx = globalIndices[i].NormalStartIndex;
		u32 tCoord2Idx = globalIndices[i].TCoord1StartIndex;

		Writer->writeElement("p", false);

		core::stringc strP;
		strP.reserve(100);
		for (u32 p=0; p<polyCount; ++p)
		{
			// Irrlicht uses clockwise, Collada uses counter-clockwise to define front-face
			u32 irrIdx = buffer->getIndices()[(p*3) + 2];
			strP = "";
			strP += irrIdx + posIdx;
			strP += " ";
			strP += irrIdx + tCoordIdx;
			strP += " ";
			strP += irrIdx + normalIdx;
			strP += " ";
			if (has2ndTexCoords)
			{
				strP += irrIdx + tCoord2Idx;
				strP += " ";
			}

			irrIdx = buffer->getIndices()[(p*3) + 1];
			strP += irrIdx + posIdx;
			strP += " ";
			strP += irrIdx + tCoordIdx;
			strP += " ";
			strP += irrIdx + normalIdx;
			strP += " ";
			if (has2ndTexCoords)
			{
				strP += irrIdx + tCoord2Idx;
				strP += " ";
			}

			irrIdx = buffer->getIndices()[(p*3) + 0];
			strP += irrIdx + posIdx;
			strP += " ";
			strP += irrIdx + tCoordIdx;
			strP += " ";
			strP += irrIdx + normalIdx;
			if (has2ndTexCoords)
			{
				strP += " ";
				strP += irrIdx + tCoord2Idx;
			}
			strP += " ";

			Writer->writeText(strP.c_str());
		}

		Writer->writeClosingTag("p");
		Writer->writeLineBreak();

		// close index buffer section

		Writer->writeClosingTag("triangles");
		Writer->writeLineBreak();
	}

	// close mesh and geometry
	delete [] globalIndices;
	Writer->writeClosingTag("mesh");
	Writer->writeLineBreak();
	Writer->writeClosingTag("geometry");
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeLibraryImages()
{
	if ( getWriteTextures() && !LibraryImages.empty() )
	{
		Writer->writeElement("library_images", false);
		Writer->writeLineBreak();

		for ( irr::u32 i=0; i<LibraryImages.size(); ++i )
		{
			irr::io::path p(FileSystem->getRelativeFilename(LibraryImages[i]->getName().getPath(), Directory));
			//<image name="rose01">
			irr::core::stringc ncname( toNCName(irr::core::stringc(p)) );
			Writer->writeElement("image", false, "id", ncname.c_str(), "name", ncname.c_str());
			Writer->writeLineBreak();
			//  <init_from>../flowers/rose01.jpg</init_from>
				Writer->writeElement("init_from", false);
				Writer->writeText(pathToURI(p).c_str());
				Writer->writeClosingTag("init_from");
				Writer->writeLineBreak();
	 		//  </image>
			Writer->writeClosingTag("image");
			Writer->writeLineBreak();
		}

		Writer->writeClosingTag("library_images");
		Writer->writeLineBreak();
	}
}

void CColladaMeshWriter::writeColorElement(const video::SColorf & col, bool writeAlpha)
{
	Writer->writeElement("color", false);

	writeColor(col, writeAlpha);

	Writer->writeClosingTag("color");
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeColorElement(const video::SColor & col, bool writeAlpha)
{
	writeColorElement( video::SColorf(col), writeAlpha );
}

void CColladaMeshWriter::writeAmbientLightElement(const video::SColorf & col)
{
	Writer->writeElement("light", false, "id", "ambientlight");
	Writer->writeLineBreak();

		Writer->writeElement("technique_common", false);
		Writer->writeLineBreak();

			Writer->writeElement("ambient", false);
			Writer->writeLineBreak();

				writeColorElement(col, false);

			Writer->writeClosingTag("ambient");
			Writer->writeLineBreak();

		Writer->writeClosingTag("technique_common");
		Writer->writeLineBreak();

	Writer->writeClosingTag("light");
	Writer->writeLineBreak();
}

s32 CColladaMeshWriter::getCheckedTextureIdx(const video::SMaterial & material, E_COLLADA_COLOR_SAMPLER cs)
{
	if (	!getWriteTextures()
		||	!getProperties() )
		return -1;

	s32 idx = getProperties()->getTextureIdx(material, cs);
	if ( idx >= 0 && !material.TextureLayer[idx].Texture )
		return -1;

	return idx;
}

video::SColor CColladaMeshWriter::getColorMapping(const video::SMaterial & material, E_COLLADA_COLOR_SAMPLER cs, E_COLLADA_IRR_COLOR colType)
{
	switch ( colType )
	{
		case ECIC_NONE:
			return video::SColor(255, 0, 0, 0);

		case ECIC_CUSTOM:
			return getProperties()->getCustomColor(material, cs);

		case ECIC_DIFFUSE:
			return material.DiffuseColor;

		case ECIC_AMBIENT:
			return material.AmbientColor;

		case ECIC_EMISSIVE:
			return material.EmissiveColor;

		case ECIC_SPECULAR:
			return material.SpecularColor;
	}
	return video::SColor(255, 0, 0, 0);
}

void CColladaMeshWriter::writeTextureSampler(s32 textureIdx)
{
	irr::core::stringc sampler("tex");
	sampler += irr::core::stringc(textureIdx);
	sampler += "-sampler";

	// <texture texture="sampler" texcoord="texCoordUv"/>
	Writer->writeElement("texture", true, "texture", sampler.c_str(), "texcoord", "uv" );
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeFxElement(const video::SMaterial & material, E_COLLADA_TECHNIQUE_FX techFx)
{
	core::stringc fxLabel;
	bool writeEmission = true;
	bool writeAmbient = true;
	bool writeDiffuse = true;
	bool writeSpecular = true;
	bool writeShininess = true;
	bool writeReflective = true;
	bool writeReflectivity = true;
	bool writeTransparent = true;
	bool writeTransparency = true;
	bool writeIndexOfRefraction = true;
	switch ( techFx )
	{
		case ECTF_BLINN:
			fxLabel = "blinn";
			break;
		case ECTF_PHONG:
			fxLabel = "phong";
			break;
		case ECTF_LAMBERT:
			fxLabel = "lambert";
			writeSpecular = false;
			writeShininess = false;
			break;
		case ECTF_CONSTANT:
			fxLabel = "constant";
			writeAmbient = false;
			writeDiffuse = false;
			writeSpecular = false;
			writeShininess = false;
			break;
	}

	Writer->writeElement(fxLabel.c_str(), false);
	Writer->writeLineBreak();

	// write all interesting material parameters
	// attributes must be written in fixed order
	if ( getProperties() )
	{
		if ( writeEmission )
		{
			writeColorFx(material, "emission", ECCS_EMISSIVE);
		}

		if ( writeAmbient )
		{
			writeColorFx(material, "ambient", ECCS_AMBIENT);
		}

		if ( writeDiffuse )
		{
			writeColorFx(material, "diffuse", ECCS_DIFFUSE);
		}

		if ( writeSpecular )
		{
			writeColorFx(material, "specular", ECCS_SPECULAR);
		}

		if ( writeShininess )
		{
			Writer->writeElement("shininess", false);
			Writer->writeLineBreak();
			writeFloatElement(material.Shininess);
			Writer->writeClosingTag("shininess");
			Writer->writeLineBreak();
		}

		if ( writeReflective )
		{
			writeColorFx(material, "reflective", ECCS_REFLECTIVE);
		}

		if ( writeReflectivity )
		{
			f32 t = getProperties()->getReflectivity(material);
			if ( t >= 0.f )
			{
				// <transparency>  <float>1.000000</float> </transparency>
				Writer->writeElement("reflectivity", false);
				Writer->writeLineBreak();
				writeFloatElement(t);
				Writer->writeClosingTag("reflectivity");
				Writer->writeLineBreak();
			}
		}

		if ( writeTransparent )
		{
			E_COLLADA_TRANSPARENT_FX transparentFx = getProperties()->getTransparentFx(material);
			writeColorFx(material, "transparent", ECCS_TRANSPARENT, "opaque", toString(transparentFx).c_str());
		}

		if ( writeTransparency  )
		{
			f32 t = getProperties()->getTransparency(material);
			if ( t >= 0.f )
			{
				// <transparency>  <float>1.000000</float> </transparency>
				Writer->writeElement("transparency", false);
				Writer->writeLineBreak();
				writeFloatElement(t);
				Writer->writeClosingTag("transparency");
				Writer->writeLineBreak();
			}
		}

		if ( writeIndexOfRefraction )
		{
			f32 t = getProperties()->getIndexOfRefraction(material);
			if ( t >= 0.f )
			{
				Writer->writeElement("index_of_refraction", false);
				Writer->writeLineBreak();
				writeFloatElement(t);
				Writer->writeClosingTag("index_of_refraction");
				Writer->writeLineBreak();
			}
		}
	}


	Writer->writeClosingTag(fxLabel.c_str());
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeColorFx(const video::SMaterial & material, const c8 * colorname, E_COLLADA_COLOR_SAMPLER cs, const c8* attr1Name, const c8* attr1Value)
{
	irr::s32 idx = getCheckedTextureIdx(material, cs);
	E_COLLADA_IRR_COLOR colType = idx < 0 ? getProperties()->getColorMapping(material, cs) : ECIC_NONE;
	if ( idx >= 0 || colType != ECIC_NONE )
	{
		Writer->writeElement(colorname, false, attr1Name, attr1Value);
		Writer->writeLineBreak();
		if ( idx >= 0 )
			writeTextureSampler(idx);
		else
			writeColorElement(getColorMapping(material, cs, colType));
		Writer->writeClosingTag(colorname);
		Writer->writeLineBreak();
	}
}

void CColladaMeshWriter::writeNode(const c8 * nodeName, const c8 * content)
{
	Writer->writeElement(nodeName, false);
	Writer->writeText(content);
	Writer->writeClosingTag(nodeName);
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeFloatElement(irr::f32 value)
{
	Writer->writeElement("float", false);
	Writer->writeText(core::stringc((double)value).eraseTrailingFloatZeros().c_str());
	Writer->writeClosingTag("float");
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeRotateElement(const irr::core::vector3df& axis, irr::f32 angle)
{
	Writer->writeElement("rotate", false);
	irr::core::stringc txt(axis.X);
	txt.eraseTrailingFloatZeros();
	txt += " ";
	txt += irr::core::stringc(axis.Y);
	txt.eraseTrailingFloatZeros();
	txt += " ";
	txt += irr::core::stringc(axis.Z * -1.f);
	txt.eraseTrailingFloatZeros();
	txt += " ";
	txt += irr::core::stringc((double)angle * -1.f);
	txt.eraseTrailingFloatZeros();
	Writer->writeText(txt.c_str());
	Writer->writeClosingTag("rotate");
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeScaleElement(const irr::core::vector3df& scale)
{
	Writer->writeElement("scale", false);
	irr::core::stringc txt(scale.X);
	txt.eraseTrailingFloatZeros();
	txt += " ";
	txt += irr::core::stringc(scale.Y);
	txt.eraseTrailingFloatZeros();
	txt += " ";
	txt += irr::core::stringc(scale.Z);
	txt.eraseTrailingFloatZeros();
	Writer->writeText(txt.c_str());
	Writer->writeClosingTag("scale");
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeTranslateElement(const irr::core::vector3df& translate)
{
	Writer->writeElement("translate", false);
	irr::core::stringc txt(translate.X);
	txt.eraseTrailingFloatZeros();
	txt += " ";
	txt += irr::core::stringc(translate.Y);
	txt.eraseTrailingFloatZeros();
	txt += " ";
	txt += irr::core::stringc(translate.Z*-1.f);
	txt.eraseTrailingFloatZeros();
	Writer->writeText(txt.c_str());
	Writer->writeClosingTag("translate");
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeLookAtElement(const irr::core::vector3df& eyePos, const irr::core::vector3df& targetPos, const irr::core::vector3df& upVector)
{
	Writer->writeElement("lookat", false);

	c8 tmpbuf[255];
	snprintf_irr(tmpbuf, 255, "%f %f %f %f %f %f %f %f %f", eyePos.X, eyePos.Y, eyePos.Z*-1.f, targetPos.X, targetPos.Y, targetPos.Z*-1.f, upVector.X, upVector.Y, upVector.Z*-1.f);
	Writer->writeText(tmpbuf);

	Writer->writeClosingTag("lookat");
	Writer->writeLineBreak();
}

void CColladaMeshWriter::writeMatrixElement(const irr::core::matrix4& matrixIrr)
{
	irr::core::matrix4 matrix(matrixIrr.getTransposed());	// transposed because row/lines are written other way round in Collada
	// Convert to right-handed
	matrix[2] *= -1.f;
	matrix[6] *= -1.f;
	matrix[8] *= -1.f;
	matrix[9] *= -1.f;
	matrix[11] *= -1.f;
	matrix[14] *= -1.f;

	Writer->writeElement("matrix", false);
	Writer->writeLineBreak();

	for ( int a=0; a<4; ++a )
	{
		irr::core::stringc txt;
		for ( int b=0; b<4; ++b )
		{
			if ( b > 0 )
				txt += " ";
			txt += irr::core::stringc(matrix[a*4+b]).eraseTrailingFloatZeros();
		}
		Writer->writeText(txt.c_str());
		Writer->writeLineBreak();
	}

	Writer->writeClosingTag("matrix");
	Writer->writeLineBreak();
}

} // end namespace
} // end namespace

#endif


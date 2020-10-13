// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __IRR_C_COLLADA_MESH_WRITER_H_INCLUDED__
#define __IRR_C_COLLADA_MESH_WRITER_H_INCLUDED__

#include "IColladaMeshWriter.h"
#include "S3DVertex.h"
#include "irrMap.h"
#include "IVideoDriver.h"
#include "IXMLWriter.h"

namespace irr
{
namespace io
{
	class IFileSystem;
}

namespace scene
{
	//! Callback interface for properties which can be used to influence collada writing
	// (Implementer note: keep namespace labels here to make it easier for users copying this one)
	class CColladaMeshWriterProperties  : public virtual IColladaMeshWriterProperties
	{
	public:
		//! Which lighting model should be used in the technique (FX) section when exporting effects (materials)
		virtual irr::scene::E_COLLADA_TECHNIQUE_FX getTechniqueFx(const irr::video::SMaterial& material) const _IRR_OVERRIDE_;

		//! Which texture index should be used when writing the texture of the given sampler color.
		virtual irr::s32 getTextureIdx(const irr::video::SMaterial & material, irr::scene::E_COLLADA_COLOR_SAMPLER cs) const _IRR_OVERRIDE_;

		//! Return which color from Irrlicht should be used for the color requested by collada
		virtual irr::scene::E_COLLADA_IRR_COLOR getColorMapping(const irr::video::SMaterial & material, irr::scene::E_COLLADA_COLOR_SAMPLER cs) const _IRR_OVERRIDE_;

		//! Return custom colors for certain color types requested by collada.
		virtual irr::video::SColor getCustomColor(const irr::video::SMaterial & material, irr::scene::E_COLLADA_COLOR_SAMPLER cs) const _IRR_OVERRIDE_;

		//! Return the settings for transparence
		virtual irr::scene::E_COLLADA_TRANSPARENT_FX getTransparentFx(const irr::video::SMaterial& material) const _IRR_OVERRIDE_;

		//! Transparency value for that material.
		virtual irr::f32 getTransparency(const irr::video::SMaterial& material) const _IRR_OVERRIDE_;

		//! Reflectivity value for that material
		virtual irr::f32 getReflectivity(const irr::video::SMaterial& material) const _IRR_OVERRIDE_;

		//! Return index of refraction for that material
		virtual irr::f32 getIndexOfRefraction(const irr::video::SMaterial& material) const _IRR_OVERRIDE_;

		//! Should node be used in scene export? By default all visible nodes are exported.
		virtual bool isExportable(const irr::scene::ISceneNode * node) const _IRR_OVERRIDE_;

		//! Return the mesh for the given nod. If it has no mesh or shouldn't export it's mesh return 0.
		virtual irr::scene::IMesh* getMesh(irr::scene::ISceneNode * node) _IRR_OVERRIDE_;

		//! Return if the node has it's own material overwriting the mesh-materials
		virtual bool useNodeMaterial(const scene::ISceneNode* node) const _IRR_OVERRIDE_;
	};

	class CColladaMeshWriterNames  : public virtual IColladaMeshWriterNames
	{
	public:
		CColladaMeshWriterNames(IColladaMeshWriter * writer);
		virtual irr::core::stringc nameForMesh(const scene::IMesh* mesh, int instance) _IRR_OVERRIDE_;
		virtual irr::core::stringc nameForNode(const scene::ISceneNode* node) _IRR_OVERRIDE_;
		virtual irr::core::stringc nameForMaterial(const video::SMaterial & material, int materialId, const scene::IMesh* mesh, const scene::ISceneNode* node) _IRR_OVERRIDE_;
	protected:
		irr::core::stringc nameForPtr(const void* ptr) const;
	private:
		IColladaMeshWriter * ColladaMeshWriter;
	};



//! class to write meshes, implementing a COLLADA (.dae, .xml) writer
/** This writer implementation has been originally developed for irrEdit and then
merged out to the Irrlicht Engine */
class CColladaMeshWriter : public IColladaMeshWriter
{
public:

	CColladaMeshWriter(ISceneManager * smgr, video::IVideoDriver* driver, io::IFileSystem* fs);
	virtual ~CColladaMeshWriter();

	//! Returns the type of the mesh writer
	virtual EMESH_WRITER_TYPE getType() const _IRR_OVERRIDE_;

	//! writes a scene starting with the given node
	virtual bool writeScene(io::IWriteFile* file, scene::ISceneNode* root, int writeRoot) _IRR_OVERRIDE_;

	//! writes a mesh
	virtual bool writeMesh(io::IWriteFile* file, scene::IMesh* mesh, s32 flags=EMWF_NONE) _IRR_OVERRIDE_;

	// Restrict the characters of oldString a set of allowed characters in xs:NCName and add the prefix.
	virtual irr::core::stringc toNCName(const irr::core::stringc& oldString, const irr::core::stringc& prefix=irr::core::stringc("_NC_")) const _IRR_OVERRIDE_;

	//! After export you can find out which name had been used for writing the geometry for this node.
	virtual const irr::core::stringc* findGeometryNameForNode(ISceneNode* node) _IRR_OVERRIDE_;

protected:

	void reset();
	bool hasSecondTextureCoordinates(video::E_VERTEX_TYPE type) const;
	void writeUv(const irr::core::vector2df& vec);
	void writeVector(const irr::core::vector3df& vec);
	void writeColor(const irr::video::SColorf& colorf, bool writeAlpha=true);
	inline irr::core::stringc toString(const irr::video::ECOLOR_FORMAT format) const;
	inline irr::core::stringc toString(const irr::video::E_TEXTURE_CLAMP clamp) const;
	inline irr::core::stringc toString(const irr::scene::E_COLLADA_TRANSPARENT_FX opaque) const;
	inline irr::core::stringc toRef(const irr::core::stringc& source) const;
	bool isCamera(const scene::ISceneNode* node) const;
	irr::core::stringc nameForMesh(const scene::IMesh* mesh, int instance) const;
	irr::core::stringc nameForNode(const scene::ISceneNode* node) const;
	irr::core::stringc nameForMaterial(const video::SMaterial & material, int materialId, const scene::IMesh* mesh, const scene::ISceneNode* node);
	irr::core::stringc nameForMaterialSymbol(const scene::IMesh* mesh, int materialId) const;
	irr::core::stringc findCachedMaterialName(const irr::video::SMaterial& material) const;
	irr::core::stringc minTexfilterToString(bool bilinear, bool trilinear) const;
	irr::core::stringc magTexfilterToString(bool bilinear, bool trilinear) const;
	irr::core::stringc pathToURI(const irr::io::path& path) const;
	inline bool isXmlNameStartChar(c8 c) const;
	inline bool isXmlNameChar(c8 c) const;
	s32 getCheckedTextureIdx(const video::SMaterial & material, E_COLLADA_COLOR_SAMPLER cs);
	video::SColor getColorMapping(const video::SMaterial & material, E_COLLADA_COLOR_SAMPLER cs, E_COLLADA_IRR_COLOR colType);
	void writeAsset();
	void makeMeshNames(irr::scene::ISceneNode * node);
	void writeNodeMaterials(irr::scene::ISceneNode * node);
	void writeNodeEffects(irr::scene::ISceneNode * node);
	void writeNodeLights(irr::scene::ISceneNode * node);
	void writeNodeCameras(irr::scene::ISceneNode * node);
	void writeAllMeshGeometries();
	void writeSceneNode(irr::scene::ISceneNode * node);
	void writeMeshMaterials(scene::IMesh* mesh, irr::core::array<irr::core::stringc> * materialNamesOut=0);
	void writeMeshEffects(scene::IMesh* mesh);
	void writeMaterialEffect(const irr::core::stringc& materialname, const video::SMaterial & material);
	void writeMeshGeometry(const irr::core::stringc& meshname, scene::IMesh* mesh);
	void writeMeshInstanceGeometry(const irr::core::stringc& meshname, scene::IMesh* mesh, scene::ISceneNode* node=0);
	void writeMaterial(const irr::core::stringc& materialname);
	void writeLightInstance(const irr::core::stringc& lightName);
	void writeCameraInstance(const irr::core::stringc& cameraName);
	void writeLibraryImages();
	void writeColorFx(const video::SMaterial & material, const c8 * colorname, E_COLLADA_COLOR_SAMPLER cs, const c8* attr1Name=0, const c8* attr1Value=0);
	void writeAmbientLightElement(const video::SColorf & col);
	void writeColorElement(const video::SColor & col, bool writeAlpha=true);
	void writeColorElement(const video::SColorf & col, bool writeAlpha=true);
	void writeTextureSampler(s32 textureIdx);
	void writeFxElement(const video::SMaterial & material, E_COLLADA_TECHNIQUE_FX techFx);
	void writeNode(const c8 * nodeName, const c8 * content);
	void writeFloatElement(irr::f32 value);
	void writeRotateElement(const irr::core::vector3df& axis, irr::f32 angle);
	void writeScaleElement(const irr::core::vector3df& scale);
	void writeTranslateElement(const irr::core::vector3df& translate);
	void writeLookAtElement(const irr::core::vector3df& eyePos, const irr::core::vector3df& targetPos, const irr::core::vector3df& upVector);
	void writeMatrixElement(const irr::core::matrix4& matrix);

	struct SComponentGlobalStartPos
	{
		SComponentGlobalStartPos() : PosStartIndex(0),
				NormalStartIndex(0),
				TCoord0StartIndex(0),
				TCoord1StartIndex(0)
		{ }

		u32 PosStartIndex;
		u32 NormalStartIndex;
		u32 TCoord0StartIndex;
		u32 TCoord1StartIndex;
	};

	io::IFileSystem* FileSystem;
	video::IVideoDriver* VideoDriver;
	io::IXMLWriterUTF8* Writer;
	core::array<video::ITexture*> LibraryImages;
	io::path Directory;

	// Helper struct for creating geometry copies for the ECGI_PER_MESH_AND_MATERIAL settings.
	struct SGeometryMeshMaterials
	{
		bool equals(const core::array<irr::core::stringc>& names) const
		{
			if ( names.size() != MaterialNames.size() )
				return false;
			for ( irr::u32 i=0; i<MaterialNames.size(); ++i )
				if ( names[i] != MaterialNames[i] )
					return false;
			return true;
		}

		irr::core::stringc GeometryName;				// replacing the usual ColladaMesh::Name
		core::array<irr::core::stringc> MaterialNames;	// Material names exported for this instance
		core::array<const ISceneNode*> MaterialOwners;	// Nodes using this specific mesh-material combination
	};

	// Check per mesh-ptr if stuff has been written for this mesh already
	struct SColladaMesh
	{
		SColladaMesh() : MaterialsWritten(false), EffectsWritten(false)
		{
		}

		SGeometryMeshMaterials * findGeometryMeshMaterials(const irr::core::array<irr::core::stringc> materialNames)
		{
			for ( irr::u32 i=0; i<GeometryMeshMaterials.size(); ++i )
			{
				if ( GeometryMeshMaterials[i].equals(materialNames) )
					return &(GeometryMeshMaterials[i]);
			}
			return NULL;
		}

		const irr::core::stringc& findGeometryNameForNode(const ISceneNode* node) const
		{
			if ( GeometryMeshMaterials.size() < 2 )
				return Name;
			for ( irr::u32 i=0; i<GeometryMeshMaterials.size(); ++i )
			{
				if ( GeometryMeshMaterials[i].MaterialOwners.linear_search(node)  >= 0 )
					return GeometryMeshMaterials[i].GeometryName;
			}
			return Name; // (shouldn't get here usually)
		}

		irr::core::stringc Name;
		bool MaterialsWritten;	// just an optimization doing that here in addition to the MaterialsWritten map
		bool EffectsWritten;	// just an optimization doing that here in addition to the EffectsWritten map

		core::array<SGeometryMeshMaterials> GeometryMeshMaterials;
	};
	typedef core::map<IMesh*, SColladaMesh>::Node MeshNode;
	core::map<IMesh*, SColladaMesh> Meshes;

	// structure for the lights library
	struct SColladaLight
	{
		SColladaLight()	{}
		irr::core::stringc Name;
	};
	typedef core::map<ISceneNode*, SColladaLight>::Node LightNode;
	core::map<ISceneNode*, SColladaLight> LightNodes;

	// structure for the camera library
	typedef core::map<ISceneNode*, irr::core::stringc>::Node CameraNode;
	core::map<ISceneNode*, irr::core::stringc> CameraNodes;

	// Check per name if stuff has been written already
	// TODO: second parameter not needed, we just don't have a core::set class yet in Irrlicht
	core::map<irr::core::stringc, bool> MaterialsWritten;
	core::map<irr::core::stringc, bool> EffectsWritten;

	// Cache material names
	struct MaterialName
	{
		MaterialName(const irr::video::SMaterial & material, const irr::core::stringc& name)
			: Material(material), Name(name)
		{}
		irr::video::SMaterial Material;
		irr::core::stringc Name;
	};
	irr::core::array< MaterialName > MaterialNameCache;

	irr::core::stringc WriteBuffer;	// use for writing short strings to avoid regular memory allocations

	struct EscapeCharacterURL
	{
		EscapeCharacterURL(irr::c8 c, const irr::c8* e)
			: Character(c)
		{
			Escape = e;
		}

		irr::c8 Character;		// unescaped (like ' ')
		irr::core::stringc Escape;	// escaped (like '%20')
	};
	irr::core::array<EscapeCharacterURL> EscapeCharsAnyURI;
};


} // end namespace
} // end namespace

#endif

using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFurMeshResource : CMeshTypeResource
	{
		[RED("positions", 2,0)] 		public CArray<Vector> Positions { get; set;}

		[RED("uvs", 2,0)] 		public CArray<Vector2> Uvs { get; set;}

		[RED("endIndices", 2,0)] 		public CArray<CUInt32> EndIndices { get; set;}

		[RED("faceIndices", 2,0)] 		public CArray<CUInt32> FaceIndices { get; set;}

		[RED("boneIndices", 2,0)] 		public CArray<Vector> BoneIndices { get; set;}

		[RED("boneWeights", 2,0)] 		public CArray<Vector> BoneWeights { get; set;}

		[RED("boneCount")] 		public CUInt32 BoneCount { get; set;}

		[RED("boneNames", 2,0)] 		public CArray<CName> BoneNames { get; set;}

		[RED("boneRigMatrices", 2,0)] 		public CArray<CMatrix> BoneRigMatrices { get; set;}

		[RED("boneParents", 2,0)] 		public CArray<CInt32> BoneParents { get; set;}

		[RED("bindPoses", 2,0)] 		public CArray<CMatrix> BindPoses { get; set;}

		[RED("boneSphereLocalPosArray", 2,0)] 		public CArray<Vector> BoneSphereLocalPosArray { get; set;}

		[RED("boneSphereIndexArray", 2,0)] 		public CArray<CUInt32> BoneSphereIndexArray { get; set;}

		[RED("boneSphereRadiusArray", 2,0)] 		public CArray<CFloat> BoneSphereRadiusArray { get; set;}

		[RED("boneCapsuleIndices", 2,0)] 		public CArray<CUInt32> BoneCapsuleIndices { get; set;}

		[RED("boneVertexEpsilons", 69,0)] 		public CArray<CFloat> BoneVertexEpsilons { get; set;}

		[RED("pinConstraintsLocalPosArray", 2,0)] 		public CArray<Vector> PinConstraintsLocalPosArray { get; set;}

		[RED("pinConstraintsIndexArray", 2,0)] 		public CArray<CUInt32> PinConstraintsIndexArray { get; set;}

		[RED("pinConstraintsRadiusArray", 2,0)] 		public CArray<CFloat> PinConstraintsRadiusArray { get; set;}

		[RED("splineMultiplier")] 		public CUInt32 SplineMultiplier { get; set;}

		[RED("visualizers")] 		public SFurVisualizers Visualizers { get; set;}

		[RED("physicalMaterials")] 		public SFurPhysicalMaterials PhysicalMaterials { get; set;}

		[RED("graphicalMaterials")] 		public SFurGraphicalMaterials GraphicalMaterials { get; set;}

		[RED("levelOfDetail")] 		public SFurLevelOfDetail LevelOfDetail { get; set;}

		[RED("materialWeight")] 		public CFloat MaterialWeight { get; set;}

		[RED("materialSets")] 		public SFurMaterialSet MaterialSets { get; set;}

		[RED("importUnitsScale")] 		public CFloat ImportUnitsScale { get; set;}

		public CFurMeshResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFurMeshResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
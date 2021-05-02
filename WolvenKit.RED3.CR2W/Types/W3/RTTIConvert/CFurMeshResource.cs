using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFurMeshResource : CMeshTypeResource
	{
		[Ordinal(1)] [RED("positions", 2,0)] 		public CArray<Vector> Positions { get; set;}

		[Ordinal(2)] [RED("uvs", 2,0)] 		public CArray<Vector2> Uvs { get; set;}

		[Ordinal(3)] [RED("endIndices", 2,0)] 		public CArray<CUInt32> EndIndices { get; set;}

		[Ordinal(4)] [RED("faceIndices", 2,0)] 		public CArray<CUInt32> FaceIndices { get; set;}

		[Ordinal(5)] [RED("boneIndices", 2,0)] 		public CArray<Vector> BoneIndices { get; set;}

		[Ordinal(6)] [RED("boneWeights", 2,0)] 		public CArray<Vector> BoneWeights { get; set;}

		[Ordinal(7)] [RED("boneCount")] 		public CUInt32 BoneCount { get; set;}

		[Ordinal(8)] [RED("boneNames", 2,0)] 		public CArray<CName> BoneNames { get; set;}

		[Ordinal(9)] [RED("boneRigMatrices", 2,0)] 		public CArray<CMatrix> BoneRigMatrices { get; set;}

		[Ordinal(10)] [RED("boneParents", 2,0)] 		public CArray<CInt32> BoneParents { get; set;}

		[Ordinal(11)] [RED("bindPoses", 2,0)] 		public CArray<CMatrix> BindPoses { get; set;}

		[Ordinal(12)] [RED("boneSphereLocalPosArray", 2,0)] 		public CArray<Vector> BoneSphereLocalPosArray { get; set;}

		[Ordinal(13)] [RED("boneSphereIndexArray", 2,0)] 		public CArray<CUInt32> BoneSphereIndexArray { get; set;}

		[Ordinal(14)] [RED("boneSphereRadiusArray", 2,0)] 		public CArray<CFloat> BoneSphereRadiusArray { get; set;}

		[Ordinal(15)] [RED("boneCapsuleIndices", 2,0)] 		public CArray<CUInt32> BoneCapsuleIndices { get; set;}

		[Ordinal(16)] [RED("boneVertexEpsilons", 69,0)] 		public CArray<CFloat> BoneVertexEpsilons { get; set;}

		[Ordinal(17)] [RED("pinConstraintsLocalPosArray", 2,0)] 		public CArray<Vector> PinConstraintsLocalPosArray { get; set;}

		[Ordinal(18)] [RED("pinConstraintsIndexArray", 2,0)] 		public CArray<CUInt32> PinConstraintsIndexArray { get; set;}

		[Ordinal(19)] [RED("pinConstraintsRadiusArray", 2,0)] 		public CArray<CFloat> PinConstraintsRadiusArray { get; set;}

		[Ordinal(20)] [RED("splineMultiplier")] 		public CUInt32 SplineMultiplier { get; set;}

		[Ordinal(21)] [RED("visualizers")] 		public SFurVisualizers Visualizers { get; set;}

		[Ordinal(22)] [RED("physicalMaterials")] 		public SFurPhysicalMaterials PhysicalMaterials { get; set;}

		[Ordinal(23)] [RED("graphicalMaterials")] 		public SFurGraphicalMaterials GraphicalMaterials { get; set;}

		[Ordinal(24)] [RED("levelOfDetail")] 		public SFurLevelOfDetail LevelOfDetail { get; set;}

		[Ordinal(25)] [RED("materialWeight")] 		public CFloat MaterialWeight { get; set;}

		[Ordinal(26)] [RED("materialSets")] 		public SFurMaterialSet MaterialSets { get; set;}

		[Ordinal(27)] [RED("importUnitsScale")] 		public CFloat ImportUnitsScale { get; set;}

		public CFurMeshResource(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFurMeshResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
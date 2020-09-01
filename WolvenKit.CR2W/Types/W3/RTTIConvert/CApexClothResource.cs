using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CApexClothResource : CApexResource
	{
		[Ordinal(0)] [RED("boneCount")] 		public CUInt32 BoneCount { get; set;}

		[Ordinal(0)] [RED("boneNames", 2,0)] 		public CArray<CName> BoneNames { get; set;}

		[Ordinal(0)] [RED("boneMatrices", 2,0)] 		public CArray<CMatrix> BoneMatrices { get; set;}

		[Ordinal(0)] [RED("simThickness")] 		public CFloat SimThickness { get; set;}

		[Ordinal(0)] [RED("simVirtualParticleDensity")] 		public CFloat SimVirtualParticleDensity { get; set;}

		[Ordinal(0)] [RED("simDisableCCD")] 		public CBool SimDisableCCD { get; set;}

		[Ordinal(0)] [RED("mtlMassScale")] 		public CFloat MtlMassScale { get; set;}

		[Ordinal(0)] [RED("mtlFriction")] 		public CFloat MtlFriction { get; set;}

		[Ordinal(0)] [RED("mtlGravityScale")] 		public CFloat MtlGravityScale { get; set;}

		[Ordinal(0)] [RED("mtlBendingStiffness")] 		public CFloat MtlBendingStiffness { get; set;}

		[Ordinal(0)] [RED("mtlShearingStiffness")] 		public CFloat MtlShearingStiffness { get; set;}

		[Ordinal(0)] [RED("mtlTetherStiffness")] 		public CFloat MtlTetherStiffness { get; set;}

		[Ordinal(0)] [RED("mtlTetherLimit")] 		public CFloat MtlTetherLimit { get; set;}

		[Ordinal(0)] [RED("mtlDamping")] 		public CFloat MtlDamping { get; set;}

		[Ordinal(0)] [RED("mtlDrag")] 		public CFloat MtlDrag { get; set;}

		[Ordinal(0)] [RED("mtlInertiaScale")] 		public CFloat MtlInertiaScale { get; set;}

		[Ordinal(0)] [RED("mtlMaxDistanceBias")] 		public CFloat MtlMaxDistanceBias { get; set;}

		[Ordinal(0)] [RED("mtlSelfcollisionThickness")] 		public CFloat MtlSelfcollisionThickness { get; set;}

		[Ordinal(0)] [RED("mtlSelfcollisionStiffness")] 		public CFloat MtlSelfcollisionStiffness { get; set;}

		[Ordinal(0)] [RED("mtlHardStretchLimitation")] 		public CFloat MtlHardStretchLimitation { get; set;}

		[Ordinal(0)] [RED("mtlComDamping")] 		public CBool MtlComDamping { get; set;}

		[Ordinal(0)] [RED("materialPresetName")] 		public CString MaterialPresetName { get; set;}

		[Ordinal(0)] [RED("graphicalLodLevelInfo", 2,0)] 		public CArray<SMeshTypeResourceLODLevel> GraphicalLodLevelInfo { get; set;}

		public CApexClothResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CApexClothResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CApexClothResource : CApexResource
	{
		[Ordinal(1)] [RED("boneCount")] 		public CUInt32 BoneCount { get; set;}

		[Ordinal(2)] [RED("boneNames", 2,0)] 		public CArray<CName> BoneNames { get; set;}

		[Ordinal(3)] [RED("boneMatrices", 2,0)] 		public CArray<CMatrix> BoneMatrices { get; set;}

		[Ordinal(4)] [RED("simThickness")] 		public CFloat SimThickness { get; set;}

		[Ordinal(5)] [RED("simVirtualParticleDensity")] 		public CFloat SimVirtualParticleDensity { get; set;}

		[Ordinal(6)] [RED("simDisableCCD")] 		public CBool SimDisableCCD { get; set;}

		[Ordinal(7)] [RED("mtlMassScale")] 		public CFloat MtlMassScale { get; set;}

		[Ordinal(8)] [RED("mtlFriction")] 		public CFloat MtlFriction { get; set;}

		[Ordinal(9)] [RED("mtlGravityScale")] 		public CFloat MtlGravityScale { get; set;}

		[Ordinal(10)] [RED("mtlBendingStiffness")] 		public CFloat MtlBendingStiffness { get; set;}

		[Ordinal(11)] [RED("mtlShearingStiffness")] 		public CFloat MtlShearingStiffness { get; set;}

		[Ordinal(12)] [RED("mtlTetherStiffness")] 		public CFloat MtlTetherStiffness { get; set;}

		[Ordinal(13)] [RED("mtlTetherLimit")] 		public CFloat MtlTetherLimit { get; set;}

		[Ordinal(14)] [RED("mtlDamping")] 		public CFloat MtlDamping { get; set;}

		[Ordinal(15)] [RED("mtlDrag")] 		public CFloat MtlDrag { get; set;}

		[Ordinal(16)] [RED("mtlInertiaScale")] 		public CFloat MtlInertiaScale { get; set;}

		[Ordinal(17)] [RED("mtlMaxDistanceBias")] 		public CFloat MtlMaxDistanceBias { get; set;}

		[Ordinal(18)] [RED("mtlSelfcollisionThickness")] 		public CFloat MtlSelfcollisionThickness { get; set;}

		[Ordinal(19)] [RED("mtlSelfcollisionStiffness")] 		public CFloat MtlSelfcollisionStiffness { get; set;}

		[Ordinal(20)] [RED("mtlHardStretchLimitation")] 		public CFloat MtlHardStretchLimitation { get; set;}

		[Ordinal(21)] [RED("mtlComDamping")] 		public CBool MtlComDamping { get; set;}

		[Ordinal(22)] [RED("materialPresetName")] 		public CString MaterialPresetName { get; set;}

		[Ordinal(23)] [RED("graphicalLodLevelInfo", 2,0)] 		public CArray<SMeshTypeResourceLODLevel> GraphicalLodLevelInfo { get; set;}

		public CApexClothResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CApexClothResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
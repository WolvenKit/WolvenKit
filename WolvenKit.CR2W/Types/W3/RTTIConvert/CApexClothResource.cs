using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CApexClothResource : CApexResource
	{
		[RED("boneCount")] 		public CUInt32 BoneCount { get; set;}

		[RED("boneNames", 2,0)] 		public CArray<CName> BoneNames { get; set;}

		[RED("boneMatrices", 2,0)] 		public CArray<CMatrix> BoneMatrices { get; set;}

		[RED("simThickness")] 		public CFloat SimThickness { get; set;}

		[RED("simVirtualParticleDensity")] 		public CFloat SimVirtualParticleDensity { get; set;}

		[RED("simDisableCCD")] 		public CBool SimDisableCCD { get; set;}

		[RED("mtlMassScale")] 		public CFloat MtlMassScale { get; set;}

		[RED("mtlFriction")] 		public CFloat MtlFriction { get; set;}

		[RED("mtlGravityScale")] 		public CFloat MtlGravityScale { get; set;}

		[RED("mtlBendingStiffness")] 		public CFloat MtlBendingStiffness { get; set;}

		[RED("mtlShearingStiffness")] 		public CFloat MtlShearingStiffness { get; set;}

		[RED("mtlTetherStiffness")] 		public CFloat MtlTetherStiffness { get; set;}

		[RED("mtlTetherLimit")] 		public CFloat MtlTetherLimit { get; set;}

		[RED("mtlDamping")] 		public CFloat MtlDamping { get; set;}

		[RED("mtlDrag")] 		public CFloat MtlDrag { get; set;}

		[RED("mtlInertiaScale")] 		public CFloat MtlInertiaScale { get; set;}

		[RED("mtlMaxDistanceBias")] 		public CFloat MtlMaxDistanceBias { get; set;}

		[RED("mtlSelfcollisionThickness")] 		public CFloat MtlSelfcollisionThickness { get; set;}

		[RED("mtlSelfcollisionStiffness")] 		public CFloat MtlSelfcollisionStiffness { get; set;}

		[RED("mtlHardStretchLimitation")] 		public CFloat MtlHardStretchLimitation { get; set;}

		[RED("mtlComDamping")] 		public CBool MtlComDamping { get; set;}

		[RED("materialPresetName")] 		public CString MaterialPresetName { get; set;}

		[RED("graphicalLodLevelInfo", 2,0)] 		public CArray<SMeshTypeResourceLODLevel> GraphicalLodLevelInfo { get; set;}

		public CApexClothResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CApexClothResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
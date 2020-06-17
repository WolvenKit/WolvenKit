using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Breast : CAnimSkeletalDangleConstraint
	{
		[RED("preset")] 		public EBreastPreset Preset { get; set;}

		[RED("simTime")] 		public CFloat SimTime { get; set;}

		[RED("elA")] 		public Vector ElA { get; set;}

		[RED("startSimPointOffset")] 		public CFloat StartSimPointOffset { get; set;}

		[RED("velDamp")] 		public CFloat VelDamp { get; set;}

		[RED("bounceDamp")] 		public CFloat BounceDamp { get; set;}

		[RED("inAcc")] 		public CFloat InAcc { get; set;}

		[RED("inertiaScaler")] 		public CFloat InertiaScaler { get; set;}

		[RED("blackHole")] 		public CFloat BlackHole { get; set;}

		[RED("velClamp")] 		public CFloat VelClamp { get; set;}

		[RED("gravity")] 		public CFloat Gravity { get; set;}

		[RED("movementBoneWeight")] 		public CFloat MovementBoneWeight { get; set;}

		[RED("rotationBoneWeight")] 		public CFloat RotationBoneWeight { get; set;}

		public CAnimDangleConstraint_Breast(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAnimDangleConstraint_Breast(cr2w);

	}
}
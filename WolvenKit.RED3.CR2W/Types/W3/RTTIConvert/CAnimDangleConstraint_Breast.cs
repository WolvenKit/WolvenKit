using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Breast : CAnimSkeletalDangleConstraint
	{
		[Ordinal(1)] [RED("preset")] 		public CEnum<EBreastPreset> Preset { get; set;}

		[Ordinal(2)] [RED("simTime")] 		public CFloat SimTime { get; set;}

		[Ordinal(3)] [RED("elA")] 		public Vector ElA { get; set;}

		[Ordinal(4)] [RED("startSimPointOffset")] 		public CFloat StartSimPointOffset { get; set;}

		[Ordinal(5)] [RED("velDamp")] 		public CFloat VelDamp { get; set;}

		[Ordinal(6)] [RED("bounceDamp")] 		public CFloat BounceDamp { get; set;}

		[Ordinal(7)] [RED("inAcc")] 		public CFloat InAcc { get; set;}

		[Ordinal(8)] [RED("inertiaScaler")] 		public CFloat InertiaScaler { get; set;}

		[Ordinal(9)] [RED("blackHole")] 		public CFloat BlackHole { get; set;}

		[Ordinal(10)] [RED("velClamp")] 		public CFloat VelClamp { get; set;}

		[Ordinal(11)] [RED("gravity")] 		public CFloat Gravity { get; set;}

		[Ordinal(12)] [RED("movementBoneWeight")] 		public CFloat MovementBoneWeight { get; set;}

		[Ordinal(13)] [RED("rotationBoneWeight")] 		public CFloat RotationBoneWeight { get; set;}

		public CAnimDangleConstraint_Breast(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDangleConstraint_Breast(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
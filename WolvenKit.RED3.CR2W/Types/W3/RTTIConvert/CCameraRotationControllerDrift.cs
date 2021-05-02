using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraRotationControllerDrift : ICustomCameraScriptedPivotRotationController
	{
		[Ordinal(1)] [RED("fixedPitch")] 		public CFloat FixedPitch { get; set;}

		[Ordinal(2)] [RED("rollBase")] 		public CFloat RollBase { get; set;}

		[Ordinal(3)] [RED("rollExtraTurn")] 		public CFloat RollExtraTurn { get; set;}

		[Ordinal(4)] [RED("yawTotal")] 		public CFloat YawTotal { get; set;}

		[Ordinal(5)] [RED("timeCur")] 		public CFloat TimeCur { get; set;}

		[Ordinal(6)] [RED("blendSpeedRoll")] 		public CFloat BlendSpeedRoll { get; set;}

		[Ordinal(7)] [RED("blendSpeedYaw")] 		public CFloat BlendSpeedYaw { get; set;}

		[Ordinal(8)] [RED("turnLast")] 		public CFloat TurnLast { get; set;}

		public CCameraRotationControllerDrift(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraRotationControllerDrift(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
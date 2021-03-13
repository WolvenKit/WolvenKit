using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLandData : CVariable
	{
		[Ordinal(1)] [RED("landType")] 		public CEnum<ELandType> LandType { get; set;}

		[Ordinal(2)] [RED("timeBeforeChain")] 		public CFloat TimeBeforeChain { get; set;}

		[Ordinal(3)] [RED("cameraShakeStrength")] 		public CFloat CameraShakeStrength { get; set;}

		[Ordinal(4)] [RED("orientationSpeed")] 		public CFloat OrientationSpeed { get; set;}

		[Ordinal(5)] [RED("timeSafetyEnd")] 		public CFloat TimeSafetyEnd { get; set;}

		[Ordinal(6)] [RED("landEndForcedMode")] 		public CEnum<ELandRunForcedMode> LandEndForcedMode { get; set;}

		[Ordinal(7)] [RED("shouldFlipFoot")] 		public CBool ShouldFlipFoot { get; set;}

		public SLandData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLandData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
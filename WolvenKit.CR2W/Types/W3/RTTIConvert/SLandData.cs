using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLandData : CVariable
	{
		[RED("landType")] 		public CEnum<ELandType> LandType { get; set;}

		[RED("timeBeforeChain")] 		public CFloat TimeBeforeChain { get; set;}

		[RED("cameraShakeStrength")] 		public CFloat CameraShakeStrength { get; set;}

		[RED("orientationSpeed")] 		public CFloat OrientationSpeed { get; set;}

		[RED("timeSafetyEnd")] 		public CFloat TimeSafetyEnd { get; set;}

		[RED("landEndForcedMode")] 		public CEnum<ELandRunForcedMode> LandEndForcedMode { get; set;}

		[RED("shouldFlipFoot")] 		public CBool ShouldFlipFoot { get; set;}

		public SLandData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SLandData(cr2w);

	}
}
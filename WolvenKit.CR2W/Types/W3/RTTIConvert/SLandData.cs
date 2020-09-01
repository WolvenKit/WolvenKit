using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLandData : CVariable
	{
		[Ordinal(0)] [RED("("landType")] 		public CEnum<ELandType> LandType { get; set;}

		[Ordinal(0)] [RED("("timeBeforeChain")] 		public CFloat TimeBeforeChain { get; set;}

		[Ordinal(0)] [RED("("cameraShakeStrength")] 		public CFloat CameraShakeStrength { get; set;}

		[Ordinal(0)] [RED("("orientationSpeed")] 		public CFloat OrientationSpeed { get; set;}

		[Ordinal(0)] [RED("("timeSafetyEnd")] 		public CFloat TimeSafetyEnd { get; set;}

		[Ordinal(0)] [RED("("landEndForcedMode")] 		public CEnum<ELandRunForcedMode> LandEndForcedMode { get; set;}

		[Ordinal(0)] [RED("("shouldFlipFoot")] 		public CBool ShouldFlipFoot { get; set;}

		public SLandData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLandData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
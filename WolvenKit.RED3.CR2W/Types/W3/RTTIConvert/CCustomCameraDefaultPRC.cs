using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCustomCameraDefaultPRC : ICustomCameraPivotRotationController
	{
		[Ordinal(1)] [RED("dampYawFactor")] 		public CFloat DampYawFactor { get; set;}

		[Ordinal(2)] [RED("dampPitchFactor")] 		public CFloat DampPitchFactor { get; set;}

		[Ordinal(3)] [RED("yawMaxVelocity")] 		public CFloat YawMaxVelocity { get; set;}

		[Ordinal(4)] [RED("yawAcceleration")] 		public CFloat YawAcceleration { get; set;}

		[Ordinal(5)] [RED("pitchAcceleration")] 		public CFloat PitchAcceleration { get; set;}

		[Ordinal(6)] [RED("pitchMaxVelocity")] 		public CFloat PitchMaxVelocity { get; set;}

		public CCustomCameraDefaultPRC(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCustomCameraDefaultPRC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
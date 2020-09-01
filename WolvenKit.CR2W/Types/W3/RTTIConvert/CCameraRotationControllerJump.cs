using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraRotationControllerJump : ICustomCameraScriptedPivotRotationController
	{
		[Ordinal(0)] [RED("("pitchTotal")] 		public CFloat PitchTotal { get; set;}

		[Ordinal(0)] [RED("("pitchBase")] 		public CFloat PitchBase { get; set;}

		[Ordinal(0)] [RED("("yawAcceleration")] 		public CFloat YawAcceleration { get; set;}

		[Ordinal(0)] [RED("("yawMaxSpeed")] 		public CFloat YawMaxSpeed { get; set;}

		[Ordinal(0)] [RED("("timeCur")] 		public CFloat TimeCur { get; set;}

		[Ordinal(0)] [RED("("timeStart")] 		public CFloat TimeStart { get; set;}

		[Ordinal(0)] [RED("("timeComplete")] 		public CFloat TimeComplete { get; set;}

		[Ordinal(0)] [RED("("blendSpeed")] 		public CFloat BlendSpeed { get; set;}

		[Ordinal(0)] [RED("("pitchCurve")] 		public CHandle<CCurve> PitchCurve { get; set;}

		public CCameraRotationControllerJump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraRotationControllerJump(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
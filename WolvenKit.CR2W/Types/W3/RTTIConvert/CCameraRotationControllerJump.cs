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
		[RED("pitchTotal")] 		public CFloat PitchTotal { get; set;}

		[RED("pitchBase")] 		public CFloat PitchBase { get; set;}

		[RED("yawAcceleration")] 		public CFloat YawAcceleration { get; set;}

		[RED("yawMaxSpeed")] 		public CFloat YawMaxSpeed { get; set;}

		[RED("timeCur")] 		public CFloat TimeCur { get; set;}

		[RED("timeStart")] 		public CFloat TimeStart { get; set;}

		[RED("timeComplete")] 		public CFloat TimeComplete { get; set;}

		[RED("blendSpeed")] 		public CFloat BlendSpeed { get; set;}

		[RED("pitchCurve")] 		public CHandle<CCurve> PitchCurve { get; set;}

		public CCameraRotationControllerJump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraRotationControllerJump(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
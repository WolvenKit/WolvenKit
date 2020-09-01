using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraRotationControllerInteraction : ICustomCameraScriptedPivotRotationController
	{
		[Ordinal(1)] [RED("("pitchMaxSpeed")] 		public CFloat PitchMaxSpeed { get; set;}

		[Ordinal(2)] [RED("("blendTodesiredPitch")] 		public CBool BlendTodesiredPitch { get; set;}

		[Ordinal(3)] [RED("("desiredPitch")] 		public CFloat DesiredPitch { get; set;}

		[Ordinal(4)] [RED("("desiredPitchSpeed")] 		public CFloat DesiredPitchSpeed { get; set;}

		[Ordinal(5)] [RED("("yawMaxSpeed")] 		public CFloat YawMaxSpeed { get; set;}

		public CCameraRotationControllerInteraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraRotationControllerInteraction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
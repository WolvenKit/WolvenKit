using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MeditationCameraRotationController : ICustomCameraScriptedPivotRotationController
	{
		[RED("fixedPitch")] 		public CFloat FixedPitch { get; set;}

		[RED("fixedYaw")] 		public CFloat FixedYaw { get; set;}

		[RED("fixedRoll")] 		public CFloat FixedRoll { get; set;}

		[RED("baseSmooth")] 		public CFloat BaseSmooth { get; set;}

		[RED("desiredYaw")] 		public CFloat DesiredYaw { get; set;}

		[RED("desired")] 		public CBool Desired { get; set;}

		[RED("smooth")] 		public CFloat Smooth { get; set;}

		public W3MeditationCameraRotationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MeditationCameraRotationController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
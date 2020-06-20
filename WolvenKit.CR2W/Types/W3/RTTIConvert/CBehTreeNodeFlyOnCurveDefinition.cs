using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeFlyOnCurveDefinition : CBehTreeNodeAttachToCurveDefinition
	{
		[RED("animValPitch")] 		public CBehTreeValCName AnimValPitch { get; set;}

		[RED("animValYaw")] 		public CBehTreeValCName AnimValYaw { get; set;}

		[RED("maxPitchInput")] 		public CBehTreeValFloat MaxPitchInput { get; set;}

		[RED("maxPitchOutput")] 		public CBehTreeValFloat MaxPitchOutput { get; set;}

		[RED("maxYawInput")] 		public CBehTreeValFloat MaxYawInput { get; set;}

		[RED("maxYawOutput")] 		public CBehTreeValFloat MaxYawOutput { get; set;}

		public CBehTreeNodeFlyOnCurveDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeFlyOnCurveDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
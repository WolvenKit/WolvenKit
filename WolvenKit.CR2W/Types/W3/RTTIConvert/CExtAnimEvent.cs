using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimEvent : CVariable
	{
		[RED("eventName")] 		public CName EventName { get; set;}

		[RED("startTime")] 		public CFloat StartTime { get; set;}

		[RED("reportToScript")] 		public CBool ReportToScript { get; set;}

		[RED("reportToScriptMinWeight")] 		public CFloat ReportToScriptMinWeight { get; set;}

		[RED("animationName")] 		public CName AnimationName { get; set;}

		public CExtAnimEvent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExtAnimEvent(cr2w);

	}
}
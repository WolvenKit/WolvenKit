using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskStopYrdenDef : IBehTreeTaskDefinition
	{
		[RED("yrdenIsActionTarget")] 		public CBool YrdenIsActionTarget { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		[RED("useYrdenRadiusAsRange")] 		public CBool UseYrdenRadiusAsRange { get; set;}

		[RED("maxResults")] 		public CInt32 MaxResults { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[RED("eventName")] 		public CName EventName { get; set;}

		[RED("stopYrdenShock")] 		public CBool StopYrdenShock { get; set;}

		public CBTTaskStopYrdenDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskStopYrdenDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
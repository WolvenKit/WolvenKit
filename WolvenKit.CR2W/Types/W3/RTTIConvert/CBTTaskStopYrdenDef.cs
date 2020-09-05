using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskStopYrdenDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("yrdenIsActionTarget")] 		public CBool YrdenIsActionTarget { get; set;}

		[Ordinal(2)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(3)] [RED("useYrdenRadiusAsRange")] 		public CBool UseYrdenRadiusAsRange { get; set;}

		[Ordinal(4)] [RED("maxResults")] 		public CInt32 MaxResults { get; set;}

		[Ordinal(5)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(6)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(7)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(8)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(9)] [RED("stopYrdenShock")] 		public CBool StopYrdenShock { get; set;}

		public CBTTaskStopYrdenDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskStopYrdenDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
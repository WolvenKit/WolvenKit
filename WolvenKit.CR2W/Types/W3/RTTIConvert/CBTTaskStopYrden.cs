using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskStopYrden : IBehTreeTask
	{
		[Ordinal(0)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(0)] [RED("yrden")] 		public CHandle<W3YrdenEntity> Yrden { get; set;}

		[Ordinal(0)] [RED("yrdenIsActionTarget")] 		public CBool YrdenIsActionTarget { get; set;}

		[Ordinal(0)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(0)] [RED("useYrdenRadiusAsRange")] 		public CBool UseYrdenRadiusAsRange { get; set;}

		[Ordinal(0)] [RED("maxResults")] 		public CInt32 MaxResults { get; set;}

		[Ordinal(0)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(0)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(0)] [RED("stopYrdenShock")] 		public CBool StopYrdenShock { get; set;}

		public CBTTaskStopYrden(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskStopYrden(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
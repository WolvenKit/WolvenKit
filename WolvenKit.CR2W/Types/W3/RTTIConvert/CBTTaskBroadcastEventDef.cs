using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBroadcastEventDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(0)] [RED("lifetime")] 		public CFloat Lifetime { get; set;}

		[Ordinal(0)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(0)] [RED("broadcastInterval")] 		public CFloat BroadcastInterval { get; set;}

		[Ordinal(0)] [RED("recipientCount")] 		public CInt32 RecipientCount { get; set;}

		[Ordinal(0)] [RED("broadcastScene")] 		public CBool BroadcastScene { get; set;}

		[Ordinal(0)] [RED("skipInvoker")] 		public CBool SkipInvoker { get; set;}

		public CBTTaskBroadcastEventDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskBroadcastEventDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
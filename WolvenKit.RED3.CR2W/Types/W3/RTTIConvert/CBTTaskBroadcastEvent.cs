using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBroadcastEvent : IBehTreeTask
	{
		[Ordinal(1)] [RED("owner")] 		public CHandle<CNewNPC> Owner { get; set;}

		[Ordinal(2)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(3)] [RED("lifetime")] 		public CFloat Lifetime { get; set;}

		[Ordinal(4)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(5)] [RED("broadcastInterval")] 		public CFloat BroadcastInterval { get; set;}

		[Ordinal(6)] [RED("recipientCount")] 		public CInt32 RecipientCount { get; set;}

		[Ordinal(7)] [RED("broadcastScene")] 		public CBool BroadcastScene { get; set;}

		[Ordinal(8)] [RED("skipInvoker")] 		public CBool SkipInvoker { get; set;}

		public CBTTaskBroadcastEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskBroadcastEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
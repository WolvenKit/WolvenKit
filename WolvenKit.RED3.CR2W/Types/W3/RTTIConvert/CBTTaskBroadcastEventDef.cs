using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBroadcastEventDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(2)] [RED("lifetime")] 		public CFloat Lifetime { get; set;}

		[Ordinal(3)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(4)] [RED("broadcastInterval")] 		public CFloat BroadcastInterval { get; set;}

		[Ordinal(5)] [RED("recipientCount")] 		public CInt32 RecipientCount { get; set;}

		[Ordinal(6)] [RED("broadcastScene")] 		public CBool BroadcastScene { get; set;}

		[Ordinal(7)] [RED("skipInvoker")] 		public CBool SkipInvoker { get; set;}

		public CBTTaskBroadcastEventDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
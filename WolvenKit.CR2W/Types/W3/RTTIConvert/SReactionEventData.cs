using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SReactionEventData : CVariable
	{
		[RED("eventName")] 		public CName EventName { get; set;}

		[RED("lifetime")] 		public CFloat Lifetime { get; set;}

		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("broadcastInterval")] 		public CFloat BroadcastInterval { get; set;}

		[RED("recipientCount")] 		public CInt32 RecipientCount { get; set;}

		[RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[RED("chanceOfSucceeding")] 		public CFloat ChanceOfSucceeding { get; set;}

		[RED("lastBroadcastTime")] 		public CFloat LastBroadcastTime { get; set;}

		public SReactionEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SReactionEventData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
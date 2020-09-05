using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSignalReactionEventDef : IBehTreeReactionTaskDefinition
	{
		[Ordinal(1)] [RED("reactionEventName")] 		public CBehTreeValCName ReactionEventName { get; set;}

		[Ordinal(2)] [RED("lifeTime")] 		public CFloat LifeTime { get; set;}

		[Ordinal(3)] [RED("distanceRange")] 		public CBehTreeValFloat DistanceRange { get; set;}

		[Ordinal(4)] [RED("broadcastInterval")] 		public CFloat BroadcastInterval { get; set;}

		[Ordinal(5)] [RED("recipientCount")] 		public CBehTreeValInt RecipientCount { get; set;}

		[Ordinal(6)] [RED("setActionTargetOnBroadcast")] 		public CBool SetActionTargetOnBroadcast { get; set;}

		[Ordinal(7)] [RED("skipInvoker")] 		public CBool SkipInvoker { get; set;}

		[Ordinal(8)] [RED("disableOnDeactivate")] 		public CBool DisableOnDeactivate { get; set;}

		[Ordinal(9)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(10)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(11)] [RED("onSuccess")] 		public CBool OnSuccess { get; set;}

		[Ordinal(12)] [RED("onFailure")] 		public CBool OnFailure { get; set;}

		[Ordinal(13)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(14)] [RED("eventName")] 		public CName EventName { get; set;}

		public CBTTaskSignalReactionEventDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSignalReactionEventDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
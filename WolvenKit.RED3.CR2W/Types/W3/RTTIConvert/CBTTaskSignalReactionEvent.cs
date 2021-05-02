using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSignalReactionEvent : IBehTreeTask
	{
		[Ordinal(1)] [RED("reactionEventName")] 		public CName ReactionEventName { get; set;}

		[Ordinal(2)] [RED("lifeTime")] 		public CFloat LifeTime { get; set;}

		[Ordinal(3)] [RED("distanceRange")] 		public CFloat DistanceRange { get; set;}

		[Ordinal(4)] [RED("broadcastInterval")] 		public CFloat BroadcastInterval { get; set;}

		[Ordinal(5)] [RED("recipientCount")] 		public CInt32 RecipientCount { get; set;}

		[Ordinal(6)] [RED("skipInvoker")] 		public CBool SkipInvoker { get; set;}

		[Ordinal(7)] [RED("setActionTargetOnBroadcast")] 		public CBool SetActionTargetOnBroadcast { get; set;}

		[Ordinal(8)] [RED("disableOnDeactivate")] 		public CBool DisableOnDeactivate { get; set;}

		[Ordinal(9)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(10)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(11)] [RED("onSuccess")] 		public CBool OnSuccess { get; set;}

		[Ordinal(12)] [RED("onFailure")] 		public CBool OnFailure { get; set;}

		[Ordinal(13)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(14)] [RED("eventName")] 		public CName EventName { get; set;}

		public CBTTaskSignalReactionEvent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
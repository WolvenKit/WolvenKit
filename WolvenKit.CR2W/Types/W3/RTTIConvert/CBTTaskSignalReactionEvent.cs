using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSignalReactionEvent : IBehTreeTask
	{
		[RED("reactionEventName")] 		public CName ReactionEventName { get; set;}

		[RED("lifeTime")] 		public CFloat LifeTime { get; set;}

		[RED("distanceRange")] 		public CFloat DistanceRange { get; set;}

		[RED("broadcastInterval")] 		public CFloat BroadcastInterval { get; set;}

		[RED("recipientCount")] 		public CInt32 RecipientCount { get; set;}

		[RED("skipInvoker")] 		public CBool SkipInvoker { get; set;}

		[RED("setActionTargetOnBroadcast")] 		public CBool SetActionTargetOnBroadcast { get; set;}

		[RED("disableOnDeactivate")] 		public CBool DisableOnDeactivate { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("onSuccess")] 		public CBool OnSuccess { get; set;}

		[RED("onFailure")] 		public CBool OnFailure { get; set;}

		[RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[RED("eventName")] 		public CName EventName { get; set;}

		public CBTTaskSignalReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSignalReactionEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
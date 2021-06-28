using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcActionSubtree : CAISubTree
	{
		[Ordinal(1)] [RED("reactionLogicTree")] 		public CHandle<CAINpcReaction> ReactionLogicTree { get; set;}

		[Ordinal(2)] [RED("reactionPriority")] 		public CInt32 ReactionPriority { get; set;}

		[Ordinal(3)] [RED("actionEventName")] 		public CName ActionEventName { get; set;}

		[Ordinal(4)] [RED("actionCooldownDistance")] 		public CFloat ActionCooldownDistance { get; set;}

		[Ordinal(5)] [RED("actionCooldownTimeout")] 		public CFloat ActionCooldownTimeout { get; set;}

		[Ordinal(6)] [RED("actionFailedCooldown")] 		public CFloat ActionFailedCooldown { get; set;}

		[Ordinal(7)] [RED("dontSetActionTarget")] 		public CBool DontSetActionTarget { get; set;}

		[Ordinal(8)] [RED("changePriorityWhileActive")] 		public CBool ChangePriorityWhileActive { get; set;}

		[Ordinal(9)] [RED("reactionPriorityWhileActive")] 		public CInt32 ReactionPriorityWhileActive { get; set;}

		[Ordinal(10)] [RED("disallowOutsideOfGuardArea")] 		public CBool DisallowOutsideOfGuardArea { get; set;}

		[Ordinal(11)] [RED("forwardAvailabilityToReactionTree")] 		public CBool ForwardAvailabilityToReactionTree { get; set;}

		[Ordinal(12)] [RED("disableTalkInteraction")] 		public CBool DisableTalkInteraction { get; set;}

		[Ordinal(13)] [RED("disallowWhileOnHorse")] 		public CBool DisallowWhileOnHorse { get; set;}

		public CAINpcActionSubtree(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
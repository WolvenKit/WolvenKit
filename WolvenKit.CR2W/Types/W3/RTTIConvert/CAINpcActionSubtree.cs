using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcActionSubtree : CAISubTree
	{
		[RED("reactionLogicTree")] 		public CHandle<CAINpcReaction> ReactionLogicTree { get; set;}

		[RED("reactionPriority")] 		public CInt32 ReactionPriority { get; set;}

		[RED("actionEventName")] 		public CName ActionEventName { get; set;}

		[RED("actionCooldownDistance")] 		public CFloat ActionCooldownDistance { get; set;}

		[RED("actionCooldownTimeout")] 		public CFloat ActionCooldownTimeout { get; set;}

		[RED("actionFailedCooldown")] 		public CFloat ActionFailedCooldown { get; set;}

		[RED("dontSetActionTarget")] 		public CBool DontSetActionTarget { get; set;}

		[RED("changePriorityWhileActive")] 		public CBool ChangePriorityWhileActive { get; set;}

		[RED("reactionPriorityWhileActive")] 		public CInt32 ReactionPriorityWhileActive { get; set;}

		[RED("disallowOutsideOfGuardArea")] 		public CBool DisallowOutsideOfGuardArea { get; set;}

		[RED("forwardAvailabilityToReactionTree")] 		public CBool ForwardAvailabilityToReactionTree { get; set;}

		[RED("disableTalkInteraction")] 		public CBool DisableTalkInteraction { get; set;}

		[RED("disallowWhileOnHorse")] 		public CBool DisallowWhileOnHorse { get; set;}

		public CAINpcActionSubtree(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAINpcActionSubtree(cr2w);

	}
}
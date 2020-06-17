using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeAtomicLookAtDefinition : CBehTreeNodeCompleteImmediatelyDefinition
	{
		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("player")] 		public CBool Player { get; set;}

		[RED("actionTarget")] 		public CBool ActionTarget { get; set;}

		[RED("combatTarget")] 		public CBool CombatTarget { get; set;}

		[RED("reactionTarget")] 		public CBool ReactionTarget { get; set;}

		[RED("namedTarget")] 		public CName NamedTarget { get; set;}

		public CBehTreeNodeAtomicLookAtDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeAtomicLookAtDefinition(cr2w);

	}
}
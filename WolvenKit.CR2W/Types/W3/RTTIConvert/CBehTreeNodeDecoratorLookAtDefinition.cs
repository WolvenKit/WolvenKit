using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeDecoratorLookAtDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("durationPostDeactivation")] 		public CFloat DurationPostDeactivation { get; set;}

		[Ordinal(2)] [RED("player")] 		public CBool Player { get; set;}

		[Ordinal(3)] [RED("actionTarget")] 		public CBool ActionTarget { get; set;}

		[Ordinal(4)] [RED("combatTarget")] 		public CBool CombatTarget { get; set;}

		[Ordinal(5)] [RED("reactionTarget")] 		public CBool ReactionTarget { get; set;}

		[Ordinal(6)] [RED("namedTarget")] 		public CName NamedTarget { get; set;}

		public CBehTreeNodeDecoratorLookAtDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeDecoratorLookAtDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
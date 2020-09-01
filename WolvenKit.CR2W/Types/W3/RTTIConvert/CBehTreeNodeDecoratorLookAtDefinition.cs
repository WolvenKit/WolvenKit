using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeDecoratorLookAtDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(0)] [RED("durationPostDeactivation")] 		public CFloat DurationPostDeactivation { get; set;}

		[Ordinal(0)] [RED("player")] 		public CBool Player { get; set;}

		[Ordinal(0)] [RED("actionTarget")] 		public CBool ActionTarget { get; set;}

		[Ordinal(0)] [RED("combatTarget")] 		public CBool CombatTarget { get; set;}

		[Ordinal(0)] [RED("reactionTarget")] 		public CBool ReactionTarget { get; set;}

		[Ordinal(0)] [RED("namedTarget")] 		public CName NamedTarget { get; set;}

		public CBehTreeNodeDecoratorLookAtDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeDecoratorLookAtDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
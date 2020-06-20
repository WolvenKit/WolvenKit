using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeConditionClearLineToTargetDefinition : CBehTreeNodeConditionDefinition
	{
		[RED("combatTarget")] 		public CBool CombatTarget { get; set;}

		[RED("navTest")] 		public CBool NavTest { get; set;}

		[RED("creatureTest")] 		public CBool CreatureTest { get; set;}

		[RED("useAgentRadius")] 		public CBool UseAgentRadius { get; set;}

		[RED("customRadius")] 		public CBehTreeValFloat CustomRadius { get; set;}

		public CBehTreeNodeConditionClearLineToTargetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeConditionClearLineToTargetDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
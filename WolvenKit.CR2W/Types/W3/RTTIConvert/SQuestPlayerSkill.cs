using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SQuestPlayerSkill : CVariable
	{
		[RED("skill")] 		public CEnum<ESkill> Skill { get; set;}

		[RED("skillLevel")] 		public CInt32 SkillLevel { get; set;}

		[RED("condition")] 		public CEnum<EQuestPlayerSkillCondition> Condition { get; set;}

		public SQuestPlayerSkill(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SQuestPlayerSkill(cr2w);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SQuestPlayerSkill : CVariable
	{
		[Ordinal(1)] [RED("skill")] 		public CEnum<ESkill> Skill { get; set;}

		[Ordinal(2)] [RED("skillLevel")] 		public CInt32 SkillLevel { get; set;}

		[Ordinal(3)] [RED("condition")] 		public CEnum<EQuestPlayerSkillCondition> Condition { get; set;}

		public SQuestPlayerSkill(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
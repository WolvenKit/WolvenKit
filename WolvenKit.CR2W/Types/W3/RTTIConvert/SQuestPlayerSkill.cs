using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SQuestPlayerSkill : CVariable
	{
		[Ordinal(0)] [RED("("skill")] 		public CEnum<ESkill> Skill { get; set;}

		[Ordinal(0)] [RED("("skillLevel")] 		public CInt32 SkillLevel { get; set;}

		[Ordinal(0)] [RED("("condition")] 		public CEnum<EQuestPlayerSkillCondition> Condition { get; set;}

		public SQuestPlayerSkill(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SQuestPlayerSkill(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
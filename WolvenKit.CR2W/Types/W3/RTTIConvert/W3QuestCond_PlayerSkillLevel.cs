using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_PlayerSkillLevel : CQuestScriptedCondition
	{
		[Ordinal(0)] [RED("("mode")] 		public CEnum<EQuestPlayerSkillLevel> Mode { get; set;}

		[Ordinal(0)] [RED("("skills", 2,0)] 		public CArray<SQuestPlayerSkill> Skills { get; set;}

		[Ordinal(0)] [RED("("dialogAxiiLevel")] 		public CInt32 DialogAxiiLevel { get; set;}

		public W3QuestCond_PlayerSkillLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_PlayerSkillLevel(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
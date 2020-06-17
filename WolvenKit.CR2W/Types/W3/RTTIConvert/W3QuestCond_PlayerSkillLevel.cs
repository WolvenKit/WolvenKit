using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_PlayerSkillLevel : CQuestScriptedCondition
	{
		[RED("mode")] 		public EQuestPlayerSkillLevel Mode { get; set;}

		[RED("skills", 2,0)] 		public CArray<SQuestPlayerSkill> Skills { get; set;}

		[RED("dialogAxiiLevel")] 		public CInt32 DialogAxiiLevel { get; set;}

		public W3QuestCond_PlayerSkillLevel(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3QuestCond_PlayerSkillLevel(cr2w);

	}
}
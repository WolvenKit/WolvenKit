using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_chosenLanguage : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("ChoosenTextLanguage")] 		public CEnum<ECheckedLanguage> ChoosenTextLanguage { get; set;}

		[Ordinal(2)] [RED("ChoosenSpeechLanguage")] 		public CEnum<ECheckedLanguage> ChoosenSpeechLanguage { get; set;}

		[Ordinal(3)] [RED("checkFor")] 		public CEnum<ELanguageCheckType> CheckFor { get; set;}

		public W3QuestCond_chosenLanguage(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_chosenLanguage : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("("ChoosenTextLanguage")] 		public CEnum<ECheckedLanguage> ChoosenTextLanguage { get; set;}

		[Ordinal(2)] [RED("("ChoosenSpeechLanguage")] 		public CEnum<ECheckedLanguage> ChoosenSpeechLanguage { get; set;}

		[Ordinal(3)] [RED("("checkFor")] 		public CEnum<ELanguageCheckType> CheckFor { get; set;}

		public W3QuestCond_chosenLanguage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_chosenLanguage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
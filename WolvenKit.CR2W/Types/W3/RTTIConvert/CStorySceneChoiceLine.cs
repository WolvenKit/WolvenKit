using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneChoiceLine : CStorySceneLinkElement
	{
		[RED("choiceLine")] 		public LocalizedString ChoiceLine { get; set;}

		[RED("choiceComment")] 		public LocalizedString ChoiceComment { get; set;}

		[RED("questCondition")] 		public CPtr<IQuestCondition> QuestCondition { get; set;}

		[RED("memo", 2,0)] 		public CArray<CPtr<ISceneChoiceMemo>> Memo { get; set;}

		[RED("singleUseChoice")] 		public CBool SingleUseChoice { get; set;}

		[RED("emphasisLine")] 		public CBool EmphasisLine { get; set;}

		[RED("action")] 		public CPtr<IStorySceneChoiceLineAction> Action { get; set;}

		public CStorySceneChoiceLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneChoiceLine(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
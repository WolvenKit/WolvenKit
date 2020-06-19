using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalQuestObjective : CJournalContainer
	{
		[RED("title")] 		public LocalizedString Title { get; set;}

		[RED("image")] 		public CString Image { get; set;}

		[RED("world")] 		public CUInt32 World { get; set;}

		[RED("counterType")] 		public CEnum<eQuestObjectiveType> CounterType { get; set;}

		[RED("count")] 		public CUInt32 Count { get; set;}

		[RED("mutuallyExclusive")] 		public CBool MutuallyExclusive { get; set;}

		[RED("bookShortcut")] 		public CName BookShortcut { get; set;}

		[RED("itemShortcut")] 		public CName ItemShortcut { get; set;}

		[RED("recipeShortcut")] 		public CName RecipeShortcut { get; set;}

		[RED("monsterShortcut")] 		public CHandle<CJournalPath> MonsterShortcut { get; set;}

		public CJournalQuestObjective(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJournalQuestObjective(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
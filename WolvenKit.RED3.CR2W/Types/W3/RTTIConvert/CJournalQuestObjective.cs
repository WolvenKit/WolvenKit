using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalQuestObjective : CJournalContainer
	{
		[Ordinal(1)] [RED("title")] 		public LocalizedString Title { get; set;}

		[Ordinal(2)] [RED("image")] 		public CString Image { get; set;}

		[Ordinal(3)] [RED("world")] 		public CUInt32 World { get; set;}

		[Ordinal(4)] [RED("counterType")] 		public CEnum<eQuestObjectiveType> CounterType { get; set;}

		[Ordinal(5)] [RED("count")] 		public CUInt32 Count { get; set;}

		[Ordinal(6)] [RED("mutuallyExclusive")] 		public CBool MutuallyExclusive { get; set;}

		[Ordinal(7)] [RED("bookShortcut")] 		public CName BookShortcut { get; set;}

		[Ordinal(8)] [RED("itemShortcut")] 		public CName ItemShortcut { get; set;}

		[Ordinal(9)] [RED("recipeShortcut")] 		public CName RecipeShortcut { get; set;}

		[Ordinal(10)] [RED("monsterShortcut")] 		public CHandle<CJournalPath> MonsterShortcut { get; set;}

		public CJournalQuestObjective(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
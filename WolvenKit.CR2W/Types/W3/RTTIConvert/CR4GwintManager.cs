using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GwintManager : IGameSystem
	{
		[RED("testMatch")] 		public CBool TestMatch { get; set;}

		[RED("enemyDecksSet")] 		public CBool EnemyDecksSet { get; set;}

		[RED("enemyDecks", 2,0)] 		public CArray<SDeckDefinition> EnemyDecks { get; set;}

		[RED("selectedEnemyDeck")] 		public CInt32 SelectedEnemyDeck { get; set;}

		[RED("forcePlayerFaction")] 		public CEnum<eGwintFaction> ForcePlayerFaction { get; set;}

		[RED("difficulty")] 		public CInt32 Difficulty { get; set;}

		[RED("diff1")] 		public CInt32 Diff1 { get; set;}

		[RED("diff2")] 		public CInt32 Diff2 { get; set;}

		[RED("diff3")] 		public CInt32 Diff3 { get; set;}

		[RED("diff4")] 		public CInt32 Diff4 { get; set;}

		[RED("diff5")] 		public CInt32 Diff5 { get; set;}

		[RED("diff6")] 		public CInt32 Diff6 { get; set;}

		[RED("diff7")] 		public CInt32 Diff7 { get; set;}

		[RED("diff8")] 		public CInt32 Diff8 { get; set;}

		[RED("diff9")] 		public CInt32 Diff9 { get; set;}

		[RED("diff10")] 		public CInt32 Diff10 { get; set;}

		[RED("diff11")] 		public CInt32 Diff11 { get; set;}

		[RED("diff12")] 		public CInt32 Diff12 { get; set;}

		[RED("diff13")] 		public CInt32 Diff13 { get; set;}

		[RED("diff14")] 		public CInt32 Diff14 { get; set;}

		[RED("diff15")] 		public CInt32 Diff15 { get; set;}

		[RED("doubleAIEnabled")] 		public CBool DoubleAIEnabled { get; set;}

		[RED("gameRequested")] 		public CBool GameRequested { get; set;}

		public CR4GwintManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GwintManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
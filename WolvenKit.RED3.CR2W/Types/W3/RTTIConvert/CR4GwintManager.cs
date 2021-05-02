using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GwintManager : IGameSystem
	{
		[Ordinal(1)] [RED("testMatch")] 		public CBool TestMatch { get; set;}

		[Ordinal(2)] [RED("enemyDecksSet")] 		public CBool EnemyDecksSet { get; set;}

		[Ordinal(3)] [RED("enemyDecks", 2,0)] 		public CArray<SDeckDefinition> EnemyDecks { get; set;}

		[Ordinal(4)] [RED("selectedEnemyDeck")] 		public CInt32 SelectedEnemyDeck { get; set;}

		[Ordinal(5)] [RED("forcePlayerFaction")] 		public CEnum<eGwintFaction> ForcePlayerFaction { get; set;}

		[Ordinal(6)] [RED("difficulty")] 		public CInt32 Difficulty { get; set;}

		[Ordinal(7)] [RED("diff1")] 		public CInt32 Diff1 { get; set;}

		[Ordinal(8)] [RED("diff2")] 		public CInt32 Diff2 { get; set;}

		[Ordinal(9)] [RED("diff3")] 		public CInt32 Diff3 { get; set;}

		[Ordinal(10)] [RED("diff4")] 		public CInt32 Diff4 { get; set;}

		[Ordinal(11)] [RED("diff5")] 		public CInt32 Diff5 { get; set;}

		[Ordinal(12)] [RED("diff6")] 		public CInt32 Diff6 { get; set;}

		[Ordinal(13)] [RED("diff7")] 		public CInt32 Diff7 { get; set;}

		[Ordinal(14)] [RED("diff8")] 		public CInt32 Diff8 { get; set;}

		[Ordinal(15)] [RED("diff9")] 		public CInt32 Diff9 { get; set;}

		[Ordinal(16)] [RED("diff10")] 		public CInt32 Diff10 { get; set;}

		[Ordinal(17)] [RED("diff11")] 		public CInt32 Diff11 { get; set;}

		[Ordinal(18)] [RED("diff12")] 		public CInt32 Diff12 { get; set;}

		[Ordinal(19)] [RED("diff13")] 		public CInt32 Diff13 { get; set;}

		[Ordinal(20)] [RED("diff14")] 		public CInt32 Diff14 { get; set;}

		[Ordinal(21)] [RED("diff15")] 		public CInt32 Diff15 { get; set;}

		[Ordinal(22)] [RED("doubleAIEnabled")] 		public CBool DoubleAIEnabled { get; set;}

		[Ordinal(23)] [RED("gameRequested")] 		public CBool GameRequested { get; set;}

		public CR4GwintManager(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
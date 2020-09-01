using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterCombatParams : CAIBaseMonsterCombatParams
	{
		[Ordinal(1)] [RED("createHitReactionEvent")] 		public CName CreateHitReactionEvent { get; set;}

		[Ordinal(2)] [RED("IncreaseHitCounterOnlyOnMelee")] 		public CBool IncreaseHitCounterOnlyOnMelee { get; set;}

		[Ordinal(3)] [RED("criticalState")] 		public CHandle<CAINpcCriticalState> CriticalState { get; set;}

		[Ordinal(4)] [RED("reactionTree")] 		public CHandle<CAIMonsterCombatReactionsTree> ReactionTree { get; set;}

		public CAIMonsterCombatParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterCombatParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
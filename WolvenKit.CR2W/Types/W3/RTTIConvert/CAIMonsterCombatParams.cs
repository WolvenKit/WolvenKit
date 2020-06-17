using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterCombatParams : CAIBaseMonsterCombatParams
	{
		[RED("createHitReactionEvent")] 		public CName CreateHitReactionEvent { get; set;}

		[RED("IncreaseHitCounterOnlyOnMelee")] 		public CBool IncreaseHitCounterOnlyOnMelee { get; set;}

		[RED("criticalState")] 		public CHandle<CAINpcCriticalState> CriticalState { get; set;}

		[RED("reactionTree")] 		public CHandle<CAIMonsterCombatReactionsTree> ReactionTree { get; set;}

		public CAIMonsterCombatParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIMonsterCombatParams(cr2w);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFlyingMonsterCombatParams : CAIBaseMonsterCombatParams
	{
		[Ordinal(1)] [RED("IncreaseHitCounterOnlyOnMelee")] 		public CBool IncreaseHitCounterOnlyOnMelee { get; set;}

		[Ordinal(2)] [RED("criticalState")] 		public CHandle<CAINpcCriticalStateFlying> CriticalState { get; set;}

		[Ordinal(3)] [RED("reactionTree")] 		public CHandle<CAIMonsterCombatReactionsTree> ReactionTree { get; set;}

		public CAIFlyingMonsterCombatParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
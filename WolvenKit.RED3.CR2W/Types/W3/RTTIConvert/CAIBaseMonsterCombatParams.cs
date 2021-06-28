using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIBaseMonsterCombatParams : CAICombatParameters
	{
		[Ordinal(1)] [RED("combatLogicTree")] 		public CHandle<CAIMonsterCombatLogic> CombatLogicTree { get; set;}

		[Ordinal(2)] [RED("damageReactionTree")] 		public CHandle<CAIMonsterSimpleDamageReactionTree> DamageReactionTree { get; set;}

		[Ordinal(3)] [RED("reachabilityTolerance")] 		public CFloat ReachabilityTolerance { get; set;}

		[Ordinal(4)] [RED("targetOnlyPlayer")] 		public CBool TargetOnlyPlayer { get; set;}

		[Ordinal(5)] [RED("hostileActorWeight")] 		public CFloat HostileActorWeight { get; set;}

		[Ordinal(6)] [RED("currentTargetWeight")] 		public CFloat CurrentTargetWeight { get; set;}

		[Ordinal(7)] [RED("rememberedHits")] 		public CInt32 RememberedHits { get; set;}

		[Ordinal(8)] [RED("hitterWeight")] 		public CFloat HitterWeight { get; set;}

		[Ordinal(9)] [RED("maxWeightedDistance")] 		public CFloat MaxWeightedDistance { get; set;}

		[Ordinal(10)] [RED("distanceWeight")] 		public CFloat DistanceWeight { get; set;}

		[Ordinal(11)] [RED("playerWeightProbability")] 		public CInt32 PlayerWeightProbability { get; set;}

		[Ordinal(12)] [RED("playerWeight")] 		public CFloat PlayerWeight { get; set;}

		[Ordinal(13)] [RED("skipVehicle")] 		public CEnum<ECombatTargetSelectionSkipTarget> SkipVehicle { get; set;}

		[Ordinal(14)] [RED("skipVehicleProbability")] 		public CInt32 SkipVehicleProbability { get; set;}

		[Ordinal(15)] [RED("skipUnreachable")] 		public CEnum<ECombatTargetSelectionSkipTarget> SkipUnreachable { get; set;}

		[Ordinal(16)] [RED("skipUnreachableProbability")] 		public CInt32 SkipUnreachableProbability { get; set;}

		[Ordinal(17)] [RED("skipNotThreatening")] 		public CEnum<ECombatTargetSelectionSkipTarget> SkipNotThreatening { get; set;}

		[Ordinal(18)] [RED("skipNotThreateningProbability")] 		public CInt32 SkipNotThreateningProbability { get; set;}

		public CAIBaseMonsterCombatParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
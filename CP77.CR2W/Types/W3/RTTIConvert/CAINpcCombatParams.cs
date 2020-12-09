using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcCombatParams : CAICombatParameters
	{
		[Ordinal(1)] [RED("scaredCombat")] 		public CBool ScaredCombat { get; set;}

		[Ordinal(2)] [RED("scaredBranch")] 		public CHandle<CAIScaredSubTree> ScaredBranch { get; set;}

		[Ordinal(3)] [RED("combatStyles", 2,0)] 		public CArray<CHandle<CAINpcCombatStyle>> CombatStyles { get; set;}

		[Ordinal(4)] [RED("criticalState")] 		public CHandle<CAINpcCriticalState> CriticalState { get; set;}

		[Ordinal(5)] [RED("preferedCombatStyle")] 		public CEnum<EBehaviorGraph> PreferedCombatStyle { get; set;}

		[Ordinal(6)] [RED("increaseHitCounterOnlyOnMelee")] 		public CBool IncreaseHitCounterOnlyOnMelee { get; set;}

		[Ordinal(7)] [RED("reachabilityTolerance")] 		public CFloat ReachabilityTolerance { get; set;}

		[Ordinal(8)] [RED("targetOnlyPlayer")] 		public CBool TargetOnlyPlayer { get; set;}

		[Ordinal(9)] [RED("hostileActorWeight")] 		public CFloat HostileActorWeight { get; set;}

		[Ordinal(10)] [RED("currentTargetWeight")] 		public CFloat CurrentTargetWeight { get; set;}

		[Ordinal(11)] [RED("rememberedHits")] 		public CInt32 RememberedHits { get; set;}

		[Ordinal(12)] [RED("hitterWeight")] 		public CFloat HitterWeight { get; set;}

		[Ordinal(13)] [RED("maxWeightedDistance")] 		public CFloat MaxWeightedDistance { get; set;}

		[Ordinal(14)] [RED("distanceWeight")] 		public CFloat DistanceWeight { get; set;}

		[Ordinal(15)] [RED("playerWeightProbability")] 		public CInt32 PlayerWeightProbability { get; set;}

		[Ordinal(16)] [RED("playerWeight")] 		public CFloat PlayerWeight { get; set;}

		[Ordinal(17)] [RED("skipVehicle")] 		public CEnum<ECombatTargetSelectionSkipTarget> SkipVehicle { get; set;}

		[Ordinal(18)] [RED("skipVehicleProbability")] 		public CInt32 SkipVehicleProbability { get; set;}

		[Ordinal(19)] [RED("skipUnreachable")] 		public CEnum<ECombatTargetSelectionSkipTarget> SkipUnreachable { get; set;}

		[Ordinal(20)] [RED("skipUnreachableProbability")] 		public CInt32 SkipUnreachableProbability { get; set;}

		[Ordinal(21)] [RED("monsterWeight")] 		public CFloat MonsterWeight { get; set;}

		public CAINpcCombatParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcCombatParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
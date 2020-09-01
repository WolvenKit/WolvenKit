using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcCombatParams : CAICombatParameters
	{
		[Ordinal(0)] [RED("scaredCombat")] 		public CBool ScaredCombat { get; set;}

		[Ordinal(0)] [RED("scaredBranch")] 		public CHandle<CAIScaredSubTree> ScaredBranch { get; set;}

		[Ordinal(0)] [RED("combatStyles", 2,0)] 		public CArray<CHandle<CAINpcCombatStyle>> CombatStyles { get; set;}

		[Ordinal(0)] [RED("criticalState")] 		public CHandle<CAINpcCriticalState> CriticalState { get; set;}

		[Ordinal(0)] [RED("preferedCombatStyle")] 		public CEnum<EBehaviorGraph> PreferedCombatStyle { get; set;}

		[Ordinal(0)] [RED("increaseHitCounterOnlyOnMelee")] 		public CBool IncreaseHitCounterOnlyOnMelee { get; set;}

		[Ordinal(0)] [RED("reachabilityTolerance")] 		public CFloat ReachabilityTolerance { get; set;}

		[Ordinal(0)] [RED("targetOnlyPlayer")] 		public CBool TargetOnlyPlayer { get; set;}

		[Ordinal(0)] [RED("hostileActorWeight")] 		public CFloat HostileActorWeight { get; set;}

		[Ordinal(0)] [RED("currentTargetWeight")] 		public CFloat CurrentTargetWeight { get; set;}

		[Ordinal(0)] [RED("rememberedHits")] 		public CInt32 RememberedHits { get; set;}

		[Ordinal(0)] [RED("hitterWeight")] 		public CFloat HitterWeight { get; set;}

		[Ordinal(0)] [RED("maxWeightedDistance")] 		public CFloat MaxWeightedDistance { get; set;}

		[Ordinal(0)] [RED("distanceWeight")] 		public CFloat DistanceWeight { get; set;}

		[Ordinal(0)] [RED("playerWeightProbability")] 		public CInt32 PlayerWeightProbability { get; set;}

		[Ordinal(0)] [RED("playerWeight")] 		public CFloat PlayerWeight { get; set;}

		[Ordinal(0)] [RED("skipVehicle")] 		public CEnum<ECombatTargetSelectionSkipTarget> SkipVehicle { get; set;}

		[Ordinal(0)] [RED("skipVehicleProbability")] 		public CInt32 SkipVehicleProbability { get; set;}

		[Ordinal(0)] [RED("skipUnreachable")] 		public CEnum<ECombatTargetSelectionSkipTarget> SkipUnreachable { get; set;}

		[Ordinal(0)] [RED("skipUnreachableProbability")] 		public CInt32 SkipUnreachableProbability { get; set;}

		[Ordinal(0)] [RED("monsterWeight")] 		public CFloat MonsterWeight { get; set;}

		public CAINpcCombatParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcCombatParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcCombatParams : CAICombatParameters
	{
		[RED("scaredCombat")] 		public CBool ScaredCombat { get; set;}

		[RED("scaredBranch")] 		public CHandle<CAIScaredSubTree> ScaredBranch { get; set;}

		[RED("combatStyles", 2,0)] 		public CArray<CHandle<CAINpcCombatStyle>> CombatStyles { get; set;}

		[RED("criticalState")] 		public CHandle<CAINpcCriticalState> CriticalState { get; set;}

		[RED("preferedCombatStyle")] 		public CEnum<EBehaviorGraph> PreferedCombatStyle { get; set;}

		[RED("increaseHitCounterOnlyOnMelee")] 		public CBool IncreaseHitCounterOnlyOnMelee { get; set;}

		[RED("reachabilityTolerance")] 		public CFloat ReachabilityTolerance { get; set;}

		[RED("targetOnlyPlayer")] 		public CBool TargetOnlyPlayer { get; set;}

		[RED("hostileActorWeight")] 		public CFloat HostileActorWeight { get; set;}

		[RED("currentTargetWeight")] 		public CFloat CurrentTargetWeight { get; set;}

		[RED("rememberedHits")] 		public CInt32 RememberedHits { get; set;}

		[RED("hitterWeight")] 		public CFloat HitterWeight { get; set;}

		[RED("maxWeightedDistance")] 		public CFloat MaxWeightedDistance { get; set;}

		[RED("distanceWeight")] 		public CFloat DistanceWeight { get; set;}

		[RED("playerWeightProbability")] 		public CInt32 PlayerWeightProbability { get; set;}

		[RED("playerWeight")] 		public CFloat PlayerWeight { get; set;}

		[RED("skipVehicle")] 		public CEnum<ECombatTargetSelectionSkipTarget> SkipVehicle { get; set;}

		[RED("skipVehicleProbability")] 		public CInt32 SkipVehicleProbability { get; set;}

		[RED("skipUnreachable")] 		public CEnum<ECombatTargetSelectionSkipTarget> SkipUnreachable { get; set;}

		[RED("skipUnreachableProbability")] 		public CInt32 SkipUnreachableProbability { get; set;}

		[RED("monsterWeight")] 		public CFloat MonsterWeight { get; set;}

		public CAINpcCombatParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcCombatParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
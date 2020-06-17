using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIBaseMonsterCombatParams : CAICombatParameters
	{
		[RED("combatLogicTree")] 		public CHandle<CAIMonsterCombatLogic> CombatLogicTree { get; set;}

		[RED("damageReactionTree")] 		public CHandle<CAIMonsterSimpleDamageReactionTree> DamageReactionTree { get; set;}

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

		[RED("skipVehicle")] 		public ECombatTargetSelectionSkipTarget SkipVehicle { get; set;}

		[RED("skipVehicleProbability")] 		public CInt32 SkipVehicleProbability { get; set;}

		[RED("skipUnreachable")] 		public ECombatTargetSelectionSkipTarget SkipUnreachable { get; set;}

		[RED("skipUnreachableProbability")] 		public CInt32 SkipUnreachableProbability { get; set;}

		[RED("skipNotThreatening")] 		public ECombatTargetSelectionSkipTarget SkipNotThreatening { get; set;}

		[RED("skipNotThreateningProbability")] 		public CInt32 SkipNotThreateningProbability { get; set;}

		public CAIBaseMonsterCombatParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIBaseMonsterCombatParams(cr2w);

	}
}
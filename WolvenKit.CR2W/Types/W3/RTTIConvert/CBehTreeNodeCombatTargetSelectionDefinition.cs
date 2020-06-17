using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeCombatTargetSelectionDefinition : IBehTreeNodeCombatTargetSelectionBaseDefinition
	{
		[RED("targetOnlyPlayer")] 		public CBehTreeValBool TargetOnlyPlayer { get; set;}

		[RED("hostileActorWeight")] 		public CBehTreeValFloat HostileActorWeight { get; set;}

		[RED("currentTargetWeight")] 		public CBehTreeValFloat CurrentTargetWeight { get; set;}

		[RED("rememberedHits")] 		public CBehTreeValInt RememberedHits { get; set;}

		[RED("hitterWeight")] 		public CBehTreeValFloat HitterWeight { get; set;}

		[RED("maxWeightedDistance")] 		public CBehTreeValFloat MaxWeightedDistance { get; set;}

		[RED("distanceWeight")] 		public CBehTreeValFloat DistanceWeight { get; set;}

		[RED("playerWeightProbability")] 		public CBehTreeValInt PlayerWeightProbability { get; set;}

		[RED("playerWeight")] 		public CBehTreeValFloat PlayerWeight { get; set;}

		[RED("monsterWeight")] 		public CBehTreeValFloat MonsterWeight { get; set;}

		[RED("skipVehicle")] 		public CBehTreeValECombatTargetSelectionSkipTarget SkipVehicle { get; set;}

		[RED("skipVehicleProbability")] 		public CBehTreeValInt SkipVehicleProbability { get; set;}

		[RED("skipUnreachable")] 		public CBehTreeValECombatTargetSelectionSkipTarget SkipUnreachable { get; set;}

		[RED("skipUnreachableProbability")] 		public CBehTreeValInt SkipUnreachableProbability { get; set;}

		[RED("skipNotThreatening")] 		public CBehTreeValECombatTargetSelectionSkipTarget SkipNotThreatening { get; set;}

		[RED("skipNotThreateningProbability")] 		public CBehTreeValInt SkipNotThreateningProbability { get; set;}

		public CBehTreeNodeCombatTargetSelectionDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeCombatTargetSelectionDefinition(cr2w);

	}
}
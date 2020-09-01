using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeCombatTargetSelectionDefinition : IBehTreeNodeCombatTargetSelectionBaseDefinition
	{
		[Ordinal(0)] [RED("targetOnlyPlayer")] 		public CBehTreeValBool TargetOnlyPlayer { get; set;}

		[Ordinal(0)] [RED("hostileActorWeight")] 		public CBehTreeValFloat HostileActorWeight { get; set;}

		[Ordinal(0)] [RED("currentTargetWeight")] 		public CBehTreeValFloat CurrentTargetWeight { get; set;}

		[Ordinal(0)] [RED("rememberedHits")] 		public CBehTreeValInt RememberedHits { get; set;}

		[Ordinal(0)] [RED("hitterWeight")] 		public CBehTreeValFloat HitterWeight { get; set;}

		[Ordinal(0)] [RED("maxWeightedDistance")] 		public CBehTreeValFloat MaxWeightedDistance { get; set;}

		[Ordinal(0)] [RED("distanceWeight")] 		public CBehTreeValFloat DistanceWeight { get; set;}

		[Ordinal(0)] [RED("playerWeightProbability")] 		public CBehTreeValInt PlayerWeightProbability { get; set;}

		[Ordinal(0)] [RED("playerWeight")] 		public CBehTreeValFloat PlayerWeight { get; set;}

		[Ordinal(0)] [RED("monsterWeight")] 		public CBehTreeValFloat MonsterWeight { get; set;}

		[Ordinal(0)] [RED("skipVehicle")] 		public CBehTreeValECombatTargetSelectionSkipTarget SkipVehicle { get; set;}

		[Ordinal(0)] [RED("skipVehicleProbability")] 		public CBehTreeValInt SkipVehicleProbability { get; set;}

		[Ordinal(0)] [RED("skipUnreachable")] 		public CBehTreeValECombatTargetSelectionSkipTarget SkipUnreachable { get; set;}

		[Ordinal(0)] [RED("skipUnreachableProbability")] 		public CBehTreeValInt SkipUnreachableProbability { get; set;}

		[Ordinal(0)] [RED("skipNotThreatening")] 		public CBehTreeValECombatTargetSelectionSkipTarget SkipNotThreatening { get; set;}

		[Ordinal(0)] [RED("skipNotThreateningProbability")] 		public CBehTreeValInt SkipNotThreateningProbability { get; set;}

		public CBehTreeNodeCombatTargetSelectionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeCombatTargetSelectionDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
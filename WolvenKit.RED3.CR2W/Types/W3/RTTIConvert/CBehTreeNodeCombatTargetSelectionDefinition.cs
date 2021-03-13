using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeCombatTargetSelectionDefinition : IBehTreeNodeCombatTargetSelectionBaseDefinition
	{
		[Ordinal(1)] [RED("targetOnlyPlayer")] 		public CBehTreeValBool TargetOnlyPlayer { get; set;}

		[Ordinal(2)] [RED("hostileActorWeight")] 		public CBehTreeValFloat HostileActorWeight { get; set;}

		[Ordinal(3)] [RED("currentTargetWeight")] 		public CBehTreeValFloat CurrentTargetWeight { get; set;}

		[Ordinal(4)] [RED("rememberedHits")] 		public CBehTreeValInt RememberedHits { get; set;}

		[Ordinal(5)] [RED("hitterWeight")] 		public CBehTreeValFloat HitterWeight { get; set;}

		[Ordinal(6)] [RED("maxWeightedDistance")] 		public CBehTreeValFloat MaxWeightedDistance { get; set;}

		[Ordinal(7)] [RED("distanceWeight")] 		public CBehTreeValFloat DistanceWeight { get; set;}

		[Ordinal(8)] [RED("playerWeightProbability")] 		public CBehTreeValInt PlayerWeightProbability { get; set;}

		[Ordinal(9)] [RED("playerWeight")] 		public CBehTreeValFloat PlayerWeight { get; set;}

		[Ordinal(10)] [RED("monsterWeight")] 		public CBehTreeValFloat MonsterWeight { get; set;}

		[Ordinal(11)] [RED("skipVehicle")] 		public CBehTreeValECombatTargetSelectionSkipTarget SkipVehicle { get; set;}

		[Ordinal(12)] [RED("skipVehicleProbability")] 		public CBehTreeValInt SkipVehicleProbability { get; set;}

		[Ordinal(13)] [RED("skipUnreachable")] 		public CBehTreeValECombatTargetSelectionSkipTarget SkipUnreachable { get; set;}

		[Ordinal(14)] [RED("skipUnreachableProbability")] 		public CBehTreeValInt SkipUnreachableProbability { get; set;}

		[Ordinal(15)] [RED("skipNotThreatening")] 		public CBehTreeValECombatTargetSelectionSkipTarget SkipNotThreatening { get; set;}

		[Ordinal(16)] [RED("skipNotThreateningProbability")] 		public CBehTreeValInt SkipNotThreateningProbability { get; set;}

		public CBehTreeNodeCombatTargetSelectionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeCombatTargetSelectionDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
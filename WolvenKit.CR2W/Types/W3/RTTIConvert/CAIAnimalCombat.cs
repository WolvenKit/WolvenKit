using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAnimalCombat : CAICombatTree
	{
		[RED("chanceOfBeingScared")] 		public CFloat ChanceOfBeingScared { get; set;}

		[RED("chanceOfBeingScaredRerollTime")] 		public CFloat ChanceOfBeingScaredRerollTime { get; set;}

		[RED("scaredIfTargetRuns")] 		public CBool ScaredIfTargetRuns { get; set;}

		[RED("maxTolerableTargetDistance")] 		public CFloat MaxTolerableTargetDistance { get; set;}

		[RED("maxFleeRunDistance")] 		public CFloat MaxFleeRunDistance { get; set;}

		[RED("maxFleeWalkDistance")] 		public CFloat MaxFleeWalkDistance { get; set;}

		[RED("stopFleeingDistance")] 		public CFloat StopFleeingDistance { get; set;}

		[RED("fleeInGroup")] 		public CBool FleeInGroup { get; set;}

		[RED("neutralIsDanger")] 		public CBool NeutralIsDanger { get; set;}

		public CAIAnimalCombat(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIAnimalCombat(cr2w);

	}
}
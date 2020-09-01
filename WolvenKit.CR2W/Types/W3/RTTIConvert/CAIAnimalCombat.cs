using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAnimalCombat : CAICombatTree
	{
		[Ordinal(0)] [RED("chanceOfBeingScared")] 		public CFloat ChanceOfBeingScared { get; set;}

		[Ordinal(0)] [RED("chanceOfBeingScaredRerollTime")] 		public CFloat ChanceOfBeingScaredRerollTime { get; set;}

		[Ordinal(0)] [RED("scaredIfTargetRuns")] 		public CBool ScaredIfTargetRuns { get; set;}

		[Ordinal(0)] [RED("maxTolerableTargetDistance")] 		public CFloat MaxTolerableTargetDistance { get; set;}

		[Ordinal(0)] [RED("maxFleeRunDistance")] 		public CFloat MaxFleeRunDistance { get; set;}

		[Ordinal(0)] [RED("maxFleeWalkDistance")] 		public CFloat MaxFleeWalkDistance { get; set;}

		[Ordinal(0)] [RED("stopFleeingDistance")] 		public CFloat StopFleeingDistance { get; set;}

		[Ordinal(0)] [RED("fleeInGroup")] 		public CBool FleeInGroup { get; set;}

		[Ordinal(0)] [RED("neutralIsDanger")] 		public CBool NeutralIsDanger { get; set;}

		public CAIAnimalCombat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIAnimalCombat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
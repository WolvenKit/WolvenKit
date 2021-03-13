using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAnimalCombat : CAICombatTree
	{
		[Ordinal(1)] [RED("chanceOfBeingScared")] 		public CFloat ChanceOfBeingScared { get; set;}

		[Ordinal(2)] [RED("chanceOfBeingScaredRerollTime")] 		public CFloat ChanceOfBeingScaredRerollTime { get; set;}

		[Ordinal(3)] [RED("scaredIfTargetRuns")] 		public CBool ScaredIfTargetRuns { get; set;}

		[Ordinal(4)] [RED("maxTolerableTargetDistance")] 		public CFloat MaxTolerableTargetDistance { get; set;}

		[Ordinal(5)] [RED("maxFleeRunDistance")] 		public CFloat MaxFleeRunDistance { get; set;}

		[Ordinal(6)] [RED("maxFleeWalkDistance")] 		public CFloat MaxFleeWalkDistance { get; set;}

		[Ordinal(7)] [RED("stopFleeingDistance")] 		public CFloat StopFleeingDistance { get; set;}

		[Ordinal(8)] [RED("fleeInGroup")] 		public CBool FleeInGroup { get; set;}

		[Ordinal(9)] [RED("neutralIsDanger")] 		public CBool NeutralIsDanger { get; set;}

		public CAIAnimalCombat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIAnimalCombat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcCombatStyleParams : CAISubTreeParameters
	{
		[Ordinal(1)] [RED("LeftItemType")] 		public CName LeftItemType { get; set;}

		[Ordinal(2)] [RED("RightItemType")] 		public CName RightItemType { get; set;}

		[Ordinal(3)] [RED("chooseSilverIfPossible")] 		public CBool ChooseSilverIfPossible { get; set;}

		[Ordinal(4)] [RED("behGraph")] 		public CEnum<EBehaviorGraph> BehGraph { get; set;}

		[Ordinal(5)] [RED("minCombatStyleDistance")] 		public CFloat MinCombatStyleDistance { get; set;}

		[Ordinal(6)] [RED("defenseActions", 2,0)] 		public CArray<CHandle<CAINpcDefenseAction>> DefenseActions { get; set;}

		[Ordinal(7)] [RED("combatTacticTree")] 		public CHandle<CAINpcTacticTree> CombatTacticTree { get; set;}

		[Ordinal(8)] [RED("attackBehavior")] 		public CHandle<CAIAttackBehaviorTree> AttackBehavior { get; set;}

		[Ordinal(9)] [RED("potentialFollower")] 		public CBool PotentialFollower { get; set;}

		[Ordinal(10)] [RED("tryToUseFormation")] 		public CBool TryToUseFormation { get; set;}

		[Ordinal(11)] [RED("formationTacticTree")] 		public CHandle<CAINpcFormationTacticTree> FormationTacticTree { get; set;}

		public CAINpcCombatStyleParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcCombatStyleParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
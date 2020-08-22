using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcCombatStyleParams : CAISubTreeParameters
	{
		[RED("LeftItemType")] 		public CName LeftItemType { get; set;}

		[RED("RightItemType")] 		public CName RightItemType { get; set;}

		[RED("chooseSilverIfPossible")] 		public CBool ChooseSilverIfPossible { get; set;}

		[RED("behGraph")] 		public CEnum<EBehaviorGraph> BehGraph { get; set;}

		[RED("minCombatStyleDistance")] 		public CFloat MinCombatStyleDistance { get; set;}

		[RED("defenseActions", 2,0)] 		public CArray<CHandle<CAINpcDefenseAction>> DefenseActions { get; set;}

		[RED("combatTacticTree")] 		public CHandle<CAINpcTacticTree> CombatTacticTree { get; set;}

		[RED("attackBehavior")] 		public CHandle<CAIAttackBehaviorTree> AttackBehavior { get; set;}

		[RED("potentialFollower")] 		public CBool PotentialFollower { get; set;}

		[RED("tryToUseFormation")] 		public CBool TryToUseFormation { get; set;}

		[RED("formationTacticTree")] 		public CHandle<CAINpcFormationTacticTree> FormationTacticTree { get; set;}

		public CAINpcCombatStyleParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcCombatStyleParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
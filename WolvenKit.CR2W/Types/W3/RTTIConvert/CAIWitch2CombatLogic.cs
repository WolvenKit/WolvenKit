using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIWitch2CombatLogic : CAIMonsterCombatLogic
	{
		[Ordinal(0)] [RED("Phase1")] 		public CBool Phase1 { get; set;}

		[Ordinal(0)] [RED("Phase2")] 		public CBool Phase2 { get; set;}

		[Ordinal(0)] [RED("PhaseReset")] 		public CBool PhaseReset { get; set;}

		[Ordinal(0)] [RED("bileAttack")] 		public CBool BileAttack { get; set;}

		[Ordinal(0)] [RED("prePursueTaunt")] 		public CBool PrePursueTaunt { get; set;}

		public CAIWitch2CombatLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIWitch2CombatLogic(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
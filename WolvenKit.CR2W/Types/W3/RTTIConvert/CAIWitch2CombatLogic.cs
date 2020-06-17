using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIWitch2CombatLogic : CAIMonsterCombatLogic
	{
		[RED("Phase1")] 		public CBool Phase1 { get; set;}

		[RED("Phase2")] 		public CBool Phase2 { get; set;}

		[RED("PhaseReset")] 		public CBool PhaseReset { get; set;}

		[RED("bileAttack")] 		public CBool BileAttack { get; set;}

		[RED("prePursueTaunt")] 		public CBool PrePursueTaunt { get; set;}

		public CAIWitch2CombatLogic(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIWitch2CombatLogic(cr2w);

	}
}
using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFugasCombatLogic : CAIMonsterCombatLogic
	{
		[RED("useFasterMovementToApproach")] 		public CBool UseFasterMovementToApproach { get; set;}

		[RED("fireAttack")] 		public CBool FireAttack { get; set;}

		public CAIFugasCombatLogic(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIFugasCombatLogic(cr2w);

	}
}
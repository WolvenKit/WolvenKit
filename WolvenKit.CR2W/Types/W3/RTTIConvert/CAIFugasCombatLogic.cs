using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFugasCombatLogic : CAIMonsterCombatLogic
	{
		[Ordinal(0)] [RED("useFasterMovementToApproach")] 		public CBool UseFasterMovementToApproach { get; set;}

		[Ordinal(0)] [RED("fireAttack")] 		public CBool FireAttack { get; set;}

		public CAIFugasCombatLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFugasCombatLogic(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
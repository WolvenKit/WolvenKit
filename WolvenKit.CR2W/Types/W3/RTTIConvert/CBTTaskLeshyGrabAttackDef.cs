using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskLeshyGrabAttackDef : IBehTreeTaskDefinition
	{
		[RED("attackType")] 		public CEnum<EAttackType> AttackType { get; set;}

		[RED("stopTaskAfterDealingDmg")] 		public CBool StopTaskAfterDealingDmg { get; set;}

		[RED("useDirectionalAttacks")] 		public CBool UseDirectionalAttacks { get; set;}

		[RED("fxOnDamageInstigated")] 		public CName FxOnDamageInstigated { get; set;}

		public CBTTaskLeshyGrabAttackDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskLeshyGrabAttackDef(cr2w);

	}
}
using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorComboAttack : CVariable
	{
		[RED("level")] 		public CInt32 Level { get; set;}

		[RED("type")] 		public CInt32 Type { get; set;}

		[RED("direction")] 		public CEnum<EAttackDirection> Direction { get; set;}

		[RED("distance")] 		public CEnum<EAttackDistance> Distance { get; set;}

		[RED("attackTime")] 		public CFloat AttackTime { get; set;}

		[RED("parryTime")] 		public CFloat ParryTime { get; set;}

		[RED("attackAnimation")] 		public CName AttackAnimation { get; set;}

		[RED("parryAnimation")] 		public CName ParryAnimation { get; set;}

		[RED("attackHitTime")] 		public CFloat AttackHitTime { get; set;}

		[RED("parryHitTime")] 		public CFloat ParryHitTime { get; set;}

		[RED("attackHitLevel")] 		public CFloat AttackHitLevel { get; set;}

		[RED("parryHitLevel")] 		public CFloat ParryHitLevel { get; set;}

		[RED("attackHitTime1")] 		public CFloat AttackHitTime1 { get; set;}

		[RED("parryHitTime1")] 		public CFloat ParryHitTime1 { get; set;}

		[RED("attackHitLevel1")] 		public CFloat AttackHitLevel1 { get; set;}

		[RED("parryHitLevel1")] 		public CFloat ParryHitLevel1 { get; set;}

		[RED("attackHitTime2")] 		public CFloat AttackHitTime2 { get; set;}

		[RED("parryHitTime2")] 		public CFloat ParryHitTime2 { get; set;}

		[RED("attackHitLevel2")] 		public CFloat AttackHitLevel2 { get; set;}

		[RED("parryHitLevel2")] 		public CFloat ParryHitLevel2 { get; set;}

		[RED("attackHitTime3")] 		public CFloat AttackHitTime3 { get; set;}

		[RED("parryHitTime3")] 		public CFloat ParryHitTime3 { get; set;}

		[RED("attackHitLevel3")] 		public CFloat AttackHitLevel3 { get; set;}

		[RED("parryHitLevel3")] 		public CFloat ParryHitLevel3 { get; set;}

		public SBehaviorComboAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorComboAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
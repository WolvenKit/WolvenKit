using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorComboAttack : CVariable
	{
		[Ordinal(1)] [RED("level")] 		public CInt32 Level { get; set;}

		[Ordinal(2)] [RED("type")] 		public CInt32 Type { get; set;}

		[Ordinal(3)] [RED("direction")] 		public CEnum<EAttackDirection> Direction { get; set;}

		[Ordinal(4)] [RED("distance")] 		public CEnum<EAttackDistance> Distance { get; set;}

		[Ordinal(5)] [RED("attackTime")] 		public CFloat AttackTime { get; set;}

		[Ordinal(6)] [RED("parryTime")] 		public CFloat ParryTime { get; set;}

		[Ordinal(7)] [RED("attackAnimation")] 		public CName AttackAnimation { get; set;}

		[Ordinal(8)] [RED("parryAnimation")] 		public CName ParryAnimation { get; set;}

		[Ordinal(9)] [RED("attackHitTime")] 		public CFloat AttackHitTime { get; set;}

		[Ordinal(10)] [RED("parryHitTime")] 		public CFloat ParryHitTime { get; set;}

		[Ordinal(11)] [RED("attackHitLevel")] 		public CFloat AttackHitLevel { get; set;}

		[Ordinal(12)] [RED("parryHitLevel")] 		public CFloat ParryHitLevel { get; set;}

		[Ordinal(13)] [RED("attackHitTime1")] 		public CFloat AttackHitTime1 { get; set;}

		[Ordinal(14)] [RED("parryHitTime1")] 		public CFloat ParryHitTime1 { get; set;}

		[Ordinal(15)] [RED("attackHitLevel1")] 		public CFloat AttackHitLevel1 { get; set;}

		[Ordinal(16)] [RED("parryHitLevel1")] 		public CFloat ParryHitLevel1 { get; set;}

		[Ordinal(17)] [RED("attackHitTime2")] 		public CFloat AttackHitTime2 { get; set;}

		[Ordinal(18)] [RED("parryHitTime2")] 		public CFloat ParryHitTime2 { get; set;}

		[Ordinal(19)] [RED("attackHitLevel2")] 		public CFloat AttackHitLevel2 { get; set;}

		[Ordinal(20)] [RED("parryHitLevel2")] 		public CFloat ParryHitLevel2 { get; set;}

		[Ordinal(21)] [RED("attackHitTime3")] 		public CFloat AttackHitTime3 { get; set;}

		[Ordinal(22)] [RED("parryHitTime3")] 		public CFloat ParryHitTime3 { get; set;}

		[Ordinal(23)] [RED("attackHitLevel3")] 		public CFloat AttackHitLevel3 { get; set;}

		[Ordinal(24)] [RED("parryHitLevel3")] 		public CFloat ParryHitLevel3 { get; set;}

		public SBehaviorComboAttack(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorComboAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
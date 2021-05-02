using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskAdditiveHitListener : IBehTreeTask
	{
		[Ordinal(1)] [RED("playHitSound")] 		public CBool PlayHitSound { get; set;}

		[Ordinal(2)] [RED("sounEventName")] 		public CString SounEventName { get; set;}

		[Ordinal(3)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(4)] [RED("manageIgnoreSignsEvents")] 		public CBool ManageIgnoreSignsEvents { get; set;}

		[Ordinal(5)] [RED("angleToIgnoreSigns")] 		public CFloat AngleToIgnoreSigns { get; set;}

		[Ordinal(6)] [RED("chanceToUseAdditive")] 		public CFloat ChanceToUseAdditive { get; set;}

		[Ordinal(7)] [RED("increaseHitCounterOnlyOnMeleeDmg")] 		public CBool IncreaseHitCounterOnlyOnMeleeDmg { get; set;}

		[Ordinal(8)] [RED("processCounter")] 		public CBool ProcessCounter { get; set;}

		[Ordinal(9)] [RED("damageIsMelee")] 		public CBool DamageIsMelee { get; set;}

		[Ordinal(10)] [RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[Ordinal(11)] [RED("hitsToRaiseGuard")] 		public CFloat HitsToRaiseGuard { get; set;}

		[Ordinal(12)] [RED("raiseGuardChance")] 		public CFloat RaiseGuardChance { get; set;}

		[Ordinal(13)] [RED("hitsToCounter")] 		public CFloat HitsToCounter { get; set;}

		[Ordinal(14)] [RED("counterChance")] 		public CFloat CounterChance { get; set;}

		[Ordinal(15)] [RED("counterStaminaCost")] 		public CFloat CounterStaminaCost { get; set;}

		public BTTaskAdditiveHitListener(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskAdditiveHitListener(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskAdditiveHitListener : IBehTreeTask
	{
		[Ordinal(0)] [RED("playHitSound")] 		public CBool PlayHitSound { get; set;}

		[Ordinal(0)] [RED("sounEventName")] 		public CString SounEventName { get; set;}

		[Ordinal(0)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(0)] [RED("manageIgnoreSignsEvents")] 		public CBool ManageIgnoreSignsEvents { get; set;}

		[Ordinal(0)] [RED("angleToIgnoreSigns")] 		public CFloat AngleToIgnoreSigns { get; set;}

		[Ordinal(0)] [RED("chanceToUseAdditive")] 		public CFloat ChanceToUseAdditive { get; set;}

		[Ordinal(0)] [RED("increaseHitCounterOnlyOnMeleeDmg")] 		public CBool IncreaseHitCounterOnlyOnMeleeDmg { get; set;}

		[Ordinal(0)] [RED("processCounter")] 		public CBool ProcessCounter { get; set;}

		[Ordinal(0)] [RED("damageIsMelee")] 		public CBool DamageIsMelee { get; set;}

		[Ordinal(0)] [RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[Ordinal(0)] [RED("hitsToRaiseGuard")] 		public CFloat HitsToRaiseGuard { get; set;}

		[Ordinal(0)] [RED("raiseGuardChance")] 		public CFloat RaiseGuardChance { get; set;}

		[Ordinal(0)] [RED("hitsToCounter")] 		public CFloat HitsToCounter { get; set;}

		[Ordinal(0)] [RED("counterChance")] 		public CFloat CounterChance { get; set;}

		[Ordinal(0)] [RED("counterStaminaCost")] 		public CFloat CounterStaminaCost { get; set;}

		public BTTaskAdditiveHitListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskAdditiveHitListener(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
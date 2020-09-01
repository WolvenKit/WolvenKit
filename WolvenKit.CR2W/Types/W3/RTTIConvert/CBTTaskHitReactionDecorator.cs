using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskHitReactionDecorator : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(0)] [RED("("createHitReactionEvent")] 		public CName CreateHitReactionEvent { get; set;}

		[Ordinal(0)] [RED("("increaseHitCounterOnlyOnMeleeDmg")] 		public CBool IncreaseHitCounterOnlyOnMeleeDmg { get; set;}

		[Ordinal(0)] [RED("("hitsToRaiseGuard")] 		public CInt32 HitsToRaiseGuard { get; set;}

		[Ordinal(0)] [RED("("raiseGuardChance")] 		public CInt32 RaiseGuardChance { get; set;}

		[Ordinal(0)] [RED("("hitsToCounter")] 		public CInt32 HitsToCounter { get; set;}

		[Ordinal(0)] [RED("("counterChance")] 		public CInt32 CounterChance { get; set;}

		[Ordinal(0)] [RED("("counterStaminaCost")] 		public CFloat CounterStaminaCost { get; set;}

		[Ordinal(0)] [RED("("damageData")] 		public CHandle<CDamageData> DamageData { get; set;}

		[Ordinal(0)] [RED("("damageIsMelee")] 		public CBool DamageIsMelee { get; set;}

		[Ordinal(0)] [RED("("rotateNode")] 		public CHandle<CNode> RotateNode { get; set;}

		[Ordinal(0)] [RED("("lastAttacker")] 		public CHandle<CGameplayEntity> LastAttacker { get; set;}

		[Ordinal(0)] [RED("("reactionDataStorage")] 		public CHandle<CAIStorageReactionData> ReactionDataStorage { get; set;}

		public CBTTaskHitReactionDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskHitReactionDecorator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
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
		[RED("createHitReactionEvent")] 		public CName CreateHitReactionEvent { get; set;}

		[RED("increaseHitCounterOnlyOnMeleeDmg")] 		public CBool IncreaseHitCounterOnlyOnMeleeDmg { get; set;}

		[RED("hitsToRaiseGuard")] 		public CInt32 HitsToRaiseGuard { get; set;}

		[RED("raiseGuardChance")] 		public CInt32 RaiseGuardChance { get; set;}

		[RED("hitsToCounter")] 		public CInt32 HitsToCounter { get; set;}

		[RED("counterChance")] 		public CInt32 CounterChance { get; set;}

		[RED("counterStaminaCost")] 		public CFloat CounterStaminaCost { get; set;}

		[RED("damageData")] 		public CHandle<CDamageData> DamageData { get; set;}

		[RED("damageIsMelee")] 		public CBool DamageIsMelee { get; set;}

		[RED("rotateNode")] 		public CHandle<CNode> RotateNode { get; set;}

		[RED("lastAttacker")] 		public CHandle<CGameplayEntity> LastAttacker { get; set;}

		[RED("reactionDataStorage")] 		public CHandle<CAIStorageReactionData> ReactionDataStorage { get; set;}

		public CBTTaskHitReactionDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskHitReactionDecorator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
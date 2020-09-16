using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDodge : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(1)] [RED("dodgeChanceAttackLight")] 		public CInt32 DodgeChanceAttackLight { get; set;}

		[Ordinal(2)] [RED("dodgeChanceAttackHeavy")] 		public CInt32 DodgeChanceAttackHeavy { get; set;}

		[Ordinal(3)] [RED("dodgeChanceAard")] 		public CInt32 DodgeChanceAard { get; set;}

		[Ordinal(4)] [RED("dodgeChanceIgni")] 		public CInt32 DodgeChanceIgni { get; set;}

		[Ordinal(5)] [RED("dodgeChanceBomb")] 		public CInt32 DodgeChanceBomb { get; set;}

		[Ordinal(6)] [RED("dodgeChanceProjectile")] 		public CInt32 DodgeChanceProjectile { get; set;}

		[Ordinal(7)] [RED("dodgeChanceFear")] 		public CInt32 DodgeChanceFear { get; set;}

		[Ordinal(8)] [RED("counterChance")] 		public CFloat CounterChance { get; set;}

		[Ordinal(9)] [RED("counterMultiplier")] 		public CFloat CounterMultiplier { get; set;}

		[Ordinal(10)] [RED("hitsToCounter")] 		public CInt32 HitsToCounter { get; set;}

		[Ordinal(11)] [RED("Time2Dodge")] 		public CBool Time2Dodge { get; set;}

		[Ordinal(12)] [RED("dodgeType")] 		public CEnum<EDodgeType> DodgeType { get; set;}

		[Ordinal(13)] [RED("dodgeDirection")] 		public CEnum<EDodgeDirection> DodgeDirection { get; set;}

		[Ordinal(14)] [RED("dodgeTime")] 		public CFloat DodgeTime { get; set;}

		[Ordinal(15)] [RED("dodgeEventTime")] 		public CFloat DodgeEventTime { get; set;}

		[Ordinal(16)] [RED("nextDodgeTime")] 		public CFloat NextDodgeTime { get; set;}

		[Ordinal(17)] [RED("performDodgeDelay")] 		public CFloat PerformDodgeDelay { get; set;}

		[Ordinal(18)] [RED("ownerPosition")] 		public Vector OwnerPosition { get; set;}

		[Ordinal(19)] [RED("swingType")] 		public CInt32 SwingType { get; set;}

		[Ordinal(20)] [RED("swingDir")] 		public CInt32 SwingDir { get; set;}

		[Ordinal(21)] [RED("navmeshCheckDist")] 		public CFloat NavmeshCheckDist { get; set;}

		[Ordinal(22)] [RED("minDelayBetweenDodges")] 		public CFloat MinDelayBetweenDodges { get; set;}

		[Ordinal(23)] [RED("maxDistanceFromTarget")] 		public CFloat MaxDistanceFromTarget { get; set;}

		[Ordinal(24)] [RED("movementAdjustorSlideDistance")] 		public CFloat MovementAdjustorSlideDistance { get; set;}

		[Ordinal(25)] [RED("disableIsDodgingFlagAfter")] 		public CFloat DisableIsDodgingFlagAfter { get; set;}

		[Ordinal(26)] [RED("allowDodgeWhileAttacking")] 		public CBool AllowDodgeWhileAttacking { get; set;}

		[Ordinal(27)] [RED("signalGameplayEventWhileInHitAnim")] 		public CBool SignalGameplayEventWhileInHitAnim { get; set;}

		[Ordinal(28)] [RED("alwaysAvailableOnDodgeType")] 		public CEnum<EDodgeType> AlwaysAvailableOnDodgeType { get; set;}

		[Ordinal(29)] [RED("allowDodgeOverlap")] 		public CBool AllowDodgeOverlap { get; set;}

		[Ordinal(30)] [RED("earlyDodgeActivation")] 		public CBool EarlyDodgeActivation { get; set;}

		[Ordinal(31)] [RED("interruptTaskToExecuteCounter")] 		public CBool InterruptTaskToExecuteCounter { get; set;}

		[Ordinal(32)] [RED("ignoreDodgeChanceStats")] 		public CBool IgnoreDodgeChanceStats { get; set;}

		[Ordinal(33)] [RED("delayDodgeHeavyAttack")] 		public CFloat DelayDodgeHeavyAttack { get; set;}

		public CBTTaskDodge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDodge(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
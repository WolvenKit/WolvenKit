using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDodge : CBTTaskPlayAnimationEventDecorator
	{
		[RED("dodgeChanceAttackLight")] 		public CInt32 DodgeChanceAttackLight { get; set;}

		[RED("dodgeChanceAttackHeavy")] 		public CInt32 DodgeChanceAttackHeavy { get; set;}

		[RED("dodgeChanceAard")] 		public CInt32 DodgeChanceAard { get; set;}

		[RED("dodgeChanceIgni")] 		public CInt32 DodgeChanceIgni { get; set;}

		[RED("dodgeChanceBomb")] 		public CInt32 DodgeChanceBomb { get; set;}

		[RED("dodgeChanceProjectile")] 		public CInt32 DodgeChanceProjectile { get; set;}

		[RED("dodgeChanceFear")] 		public CInt32 DodgeChanceFear { get; set;}

		[RED("counterChance")] 		public CFloat CounterChance { get; set;}

		[RED("counterMultiplier")] 		public CFloat CounterMultiplier { get; set;}

		[RED("hitsToCounter")] 		public CInt32 HitsToCounter { get; set;}

		[RED("Time2Dodge")] 		public CBool Time2Dodge { get; set;}

		[RED("dodgeType")] 		public CEnum<EDodgeType> DodgeType { get; set;}

		[RED("dodgeDirection")] 		public CEnum<EDodgeDirection> DodgeDirection { get; set;}

		[RED("dodgeTime")] 		public CFloat DodgeTime { get; set;}

		[RED("dodgeEventTime")] 		public CFloat DodgeEventTime { get; set;}

		[RED("nextDodgeTime")] 		public CFloat NextDodgeTime { get; set;}

		[RED("performDodgeDelay")] 		public CFloat PerformDodgeDelay { get; set;}

		[RED("ownerPosition")] 		public Vector OwnerPosition { get; set;}

		[RED("swingType")] 		public CInt32 SwingType { get; set;}

		[RED("swingDir")] 		public CInt32 SwingDir { get; set;}

		[RED("navmeshCheckDist")] 		public CFloat NavmeshCheckDist { get; set;}

		[RED("minDelayBetweenDodges")] 		public CFloat MinDelayBetweenDodges { get; set;}

		[RED("maxDistanceFromTarget")] 		public CFloat MaxDistanceFromTarget { get; set;}

		[RED("movementAdjustorSlideDistance")] 		public CFloat MovementAdjustorSlideDistance { get; set;}

		[RED("disableIsDodgingFlagAfter")] 		public CFloat DisableIsDodgingFlagAfter { get; set;}

		[RED("allowDodgeWhileAttacking")] 		public CBool AllowDodgeWhileAttacking { get; set;}

		[RED("signalGameplayEventWhileInHitAnim")] 		public CBool SignalGameplayEventWhileInHitAnim { get; set;}

		[RED("alwaysAvailableOnDodgeType")] 		public CEnum<EDodgeType> AlwaysAvailableOnDodgeType { get; set;}

		[RED("allowDodgeOverlap")] 		public CBool AllowDodgeOverlap { get; set;}

		[RED("earlyDodgeActivation")] 		public CBool EarlyDodgeActivation { get; set;}

		[RED("interruptTaskToExecuteCounter")] 		public CBool InterruptTaskToExecuteCounter { get; set;}

		[RED("ignoreDodgeChanceStats")] 		public CBool IgnoreDodgeChanceStats { get; set;}

		[RED("delayDodgeHeavyAttack")] 		public CFloat DelayDodgeHeavyAttack { get; set;}

		public CBTTaskDodge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDodge(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
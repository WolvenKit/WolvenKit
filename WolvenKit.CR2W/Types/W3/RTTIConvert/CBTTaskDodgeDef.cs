using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDodgeDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[RED("navmeshCheckDist")] 		public CFloat NavmeshCheckDist { get; set;}

		[RED("minDelayBetweenDodges")] 		public CFloat MinDelayBetweenDodges { get; set;}

		[RED("maxDistanceFromTarget")] 		public CFloat MaxDistanceFromTarget { get; set;}

		[RED("movementAdjustorSlideDistance")] 		public CFloat MovementAdjustorSlideDistance { get; set;}

		[RED("disableIsDodgingFlagAfter")] 		public CFloat DisableIsDodgingFlagAfter { get; set;}

		[RED("allowDodgeWhileAttacking")] 		public CBool AllowDodgeWhileAttacking { get; set;}

		[RED("signalGameplayEventWhileInHitAnim")] 		public CBool SignalGameplayEventWhileInHitAnim { get; set;}

		[RED("alwaysAvailableOnDodgeType")] 		public EDodgeType AlwaysAvailableOnDodgeType { get; set;}

		[RED("allowDodgeOverlap")] 		public CBool AllowDodgeOverlap { get; set;}

		[RED("earlyDodgeActivation")] 		public CBool EarlyDodgeActivation { get; set;}

		[RED("interruptTaskToExecuteCounter")] 		public CBool InterruptTaskToExecuteCounter { get; set;}

		[RED("ignoreDodgeChanceStats")] 		public CBool IgnoreDodgeChanceStats { get; set;}

		[RED("delayDodgeHeavyAttack")] 		public CFloat DelayDodgeHeavyAttack { get; set;}

		public CBTTaskDodgeDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskDodgeDef(cr2w);

	}
}
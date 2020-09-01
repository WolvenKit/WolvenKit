using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDodgeDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(0)] [RED("navmeshCheckDist")] 		public CFloat NavmeshCheckDist { get; set;}

		[Ordinal(0)] [RED("minDelayBetweenDodges")] 		public CFloat MinDelayBetweenDodges { get; set;}

		[Ordinal(0)] [RED("maxDistanceFromTarget")] 		public CFloat MaxDistanceFromTarget { get; set;}

		[Ordinal(0)] [RED("movementAdjustorSlideDistance")] 		public CFloat MovementAdjustorSlideDistance { get; set;}

		[Ordinal(0)] [RED("disableIsDodgingFlagAfter")] 		public CFloat DisableIsDodgingFlagAfter { get; set;}

		[Ordinal(0)] [RED("allowDodgeWhileAttacking")] 		public CBool AllowDodgeWhileAttacking { get; set;}

		[Ordinal(0)] [RED("signalGameplayEventWhileInHitAnim")] 		public CBool SignalGameplayEventWhileInHitAnim { get; set;}

		[Ordinal(0)] [RED("alwaysAvailableOnDodgeType")] 		public CEnum<EDodgeType> AlwaysAvailableOnDodgeType { get; set;}

		[Ordinal(0)] [RED("allowDodgeOverlap")] 		public CBool AllowDodgeOverlap { get; set;}

		[Ordinal(0)] [RED("earlyDodgeActivation")] 		public CBool EarlyDodgeActivation { get; set;}

		[Ordinal(0)] [RED("interruptTaskToExecuteCounter")] 		public CBool InterruptTaskToExecuteCounter { get; set;}

		[Ordinal(0)] [RED("ignoreDodgeChanceStats")] 		public CBool IgnoreDodgeChanceStats { get; set;}

		[Ordinal(0)] [RED("delayDodgeHeavyAttack")] 		public CFloat DelayDodgeHeavyAttack { get; set;}

		public CBTTaskDodgeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDodgeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
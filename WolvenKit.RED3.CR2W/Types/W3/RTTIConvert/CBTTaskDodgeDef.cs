using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDodgeDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(1)] [RED("navmeshCheckDist")] 		public CFloat NavmeshCheckDist { get; set;}

		[Ordinal(2)] [RED("minDelayBetweenDodges")] 		public CFloat MinDelayBetweenDodges { get; set;}

		[Ordinal(3)] [RED("maxDistanceFromTarget")] 		public CFloat MaxDistanceFromTarget { get; set;}

		[Ordinal(4)] [RED("movementAdjustorSlideDistance")] 		public CFloat MovementAdjustorSlideDistance { get; set;}

		[Ordinal(5)] [RED("disableIsDodgingFlagAfter")] 		public CFloat DisableIsDodgingFlagAfter { get; set;}

		[Ordinal(6)] [RED("allowDodgeWhileAttacking")] 		public CBool AllowDodgeWhileAttacking { get; set;}

		[Ordinal(7)] [RED("signalGameplayEventWhileInHitAnim")] 		public CBool SignalGameplayEventWhileInHitAnim { get; set;}

		[Ordinal(8)] [RED("alwaysAvailableOnDodgeType")] 		public CEnum<EDodgeType> AlwaysAvailableOnDodgeType { get; set;}

		[Ordinal(9)] [RED("allowDodgeOverlap")] 		public CBool AllowDodgeOverlap { get; set;}

		[Ordinal(10)] [RED("earlyDodgeActivation")] 		public CBool EarlyDodgeActivation { get; set;}

		[Ordinal(11)] [RED("interruptTaskToExecuteCounter")] 		public CBool InterruptTaskToExecuteCounter { get; set;}

		[Ordinal(12)] [RED("ignoreDodgeChanceStats")] 		public CBool IgnoreDodgeChanceStats { get; set;}

		[Ordinal(13)] [RED("delayDodgeHeavyAttack")] 		public CFloat DelayDodgeHeavyAttack { get; set;}

		public CBTTaskDodgeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDodgeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
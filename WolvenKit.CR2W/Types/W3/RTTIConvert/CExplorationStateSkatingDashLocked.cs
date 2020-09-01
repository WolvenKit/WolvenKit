using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingDashLocked : CExplorationInterceptorStateAbstract
	{
		[Ordinal(0)] [RED("("skateGlobal")] 		public CHandle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

		[Ordinal(0)] [RED("("target")] 		public CHandle<CEntity> Target { get; set;}

		[Ordinal(0)] [RED("("isInFlow")] 		public CBool IsInFlow { get; set;}

		[Ordinal(0)] [RED("("targetMaxAngle")] 		public CFloat TargetMaxAngle { get; set;}

		[Ordinal(0)] [RED("("targetMaxAngleFlow")] 		public CFloat TargetMaxAngleFlow { get; set;}

		[Ordinal(0)] [RED("("reachSideDistance")] 		public CFloat ReachSideDistance { get; set;}

		[Ordinal(0)] [RED("("targetSideDistance")] 		public CFloat TargetSideDistance { get; set;}

		[Ordinal(0)] [RED("("inputAngleInfluence")] 		public CFloat InputAngleInfluence { get; set;}

		[Ordinal(0)] [RED("("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(0)] [RED("("speedMinMax")] 		public CFloat SpeedMinMax { get; set;}

		[Ordinal(0)] [RED("("impulseMax")] 		public CFloat ImpulseMax { get; set;}

		[Ordinal(0)] [RED("("impulseMaxFlow")] 		public CFloat ImpulseMaxFlow { get; set;}

		[Ordinal(0)] [RED("("aimSpeed")] 		public CFloat AimSpeed { get; set;}

		[Ordinal(0)] [RED("("adjustorTicket")] 		public SMovementAdjustmentRequestTicket AdjustorTicket { get; set;}

		[Ordinal(0)] [RED("("attackDistGap")] 		public CFloat AttackDistGap { get; set;}

		[Ordinal(0)] [RED("("attackDistGapPerfect")] 		public CFloat AttackDistGapPerfect { get; set;}

		[Ordinal(0)] [RED("("toTargetDistanceInit")] 		public CFloat ToTargetDistanceInit { get; set;}

		[Ordinal(0)] [RED("("toTargetDistance")] 		public CFloat ToTargetDistance { get; set;}

		[Ordinal(0)] [RED("("targetDirLast")] 		public Vector TargetDirLast { get; set;}

		[Ordinal(0)] [RED("("attacked")] 		public CBool Attacked { get; set;}

		[Ordinal(0)] [RED("("timeTotalMax")] 		public CFloat TimeTotalMax { get; set;}

		[Ordinal(0)] [RED("("timeTotalMaxFlow")] 		public CFloat TimeTotalMaxFlow { get; set;}

		[Ordinal(0)] [RED("("timeToChainMin")] 		public CFloat TimeToChainMin { get; set;}

		[Ordinal(0)] [RED("("useTimeScale")] 		public CBool UseTimeScale { get; set;}

		[Ordinal(0)] [RED("("timeScaleSpeed")] 		public CFloat TimeScaleSpeed { get; set;}

		[Ordinal(0)] [RED("("timeScaled")] 		public CBool TimeScaled { get; set;}

		[Ordinal(0)] [RED("("afterAttackTime")] 		public CFloat AfterAttackTime { get; set;}

		[Ordinal(0)] [RED("("timeToEndCur")] 		public CFloat TimeToEndCur { get; set;}

		[Ordinal(0)] [RED("("behParamAttackName")] 		public CName BehParamAttackName { get; set;}

		[Ordinal(0)] [RED("("afterAttackImpulse")] 		public CFloat AfterAttackImpulse { get; set;}

		[Ordinal(0)] [RED("("isEnabled")] 		public CBool IsEnabled { get; set;}

		public CExplorationStateSkatingDashLocked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkatingDashLocked(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
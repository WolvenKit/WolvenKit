using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveFollowSplineTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _useKinematic;
		private CHandle<AIArgumentMapping> _needDriver;
		private CHandle<AIArgumentMapping> _spline;
		private CHandle<AIArgumentMapping> _secureTimeOut;
		private CHandle<AIArgumentMapping> _backwards;
		private CHandle<AIArgumentMapping> _reverse;
		private CHandle<AIArgumentMapping> _closest;
		private CHandle<AIArgumentMapping> _forcedStartSpeed;
		private CHandle<AIArgumentMapping> _stopAtPathEnd;
		private CHandle<AIArgumentMapping> _keepDistanceParamBool;
		private CHandle<AIArgumentMapping> _keepDistanceParamCompanion;
		private CHandle<AIArgumentMapping> _keepDistanceParamDistance;
		private CHandle<AIArgumentMapping> _rubberBandingBool;
		private CHandle<AIArgumentMapping> _rubberBandingTargetRef;
		private CHandle<AIArgumentMapping> _rubberBandingMinDistance;
		private CHandle<AIArgumentMapping> _rubberBandingMaxDistance;
		private CHandle<AIArgumentMapping> _rubberBandingStopAndWait;
		private CHandle<AIArgumentMapping> _rubberBandingTeleportToCatchUp;

		[Ordinal(1)] 
		[RED("useKinematic")] 
		public CHandle<AIArgumentMapping> UseKinematic
		{
			get => GetProperty(ref _useKinematic);
			set => SetProperty(ref _useKinematic, value);
		}

		[Ordinal(2)] 
		[RED("needDriver")] 
		public CHandle<AIArgumentMapping> NeedDriver
		{
			get => GetProperty(ref _needDriver);
			set => SetProperty(ref _needDriver, value);
		}

		[Ordinal(3)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get => GetProperty(ref _spline);
			set => SetProperty(ref _spline, value);
		}

		[Ordinal(4)] 
		[RED("secureTimeOut")] 
		public CHandle<AIArgumentMapping> SecureTimeOut
		{
			get => GetProperty(ref _secureTimeOut);
			set => SetProperty(ref _secureTimeOut, value);
		}

		[Ordinal(5)] 
		[RED("backwards")] 
		public CHandle<AIArgumentMapping> Backwards
		{
			get => GetProperty(ref _backwards);
			set => SetProperty(ref _backwards, value);
		}

		[Ordinal(6)] 
		[RED("reverse")] 
		public CHandle<AIArgumentMapping> Reverse
		{
			get => GetProperty(ref _reverse);
			set => SetProperty(ref _reverse, value);
		}

		[Ordinal(7)] 
		[RED("closest")] 
		public CHandle<AIArgumentMapping> Closest
		{
			get => GetProperty(ref _closest);
			set => SetProperty(ref _closest, value);
		}

		[Ordinal(8)] 
		[RED("forcedStartSpeed")] 
		public CHandle<AIArgumentMapping> ForcedStartSpeed
		{
			get => GetProperty(ref _forcedStartSpeed);
			set => SetProperty(ref _forcedStartSpeed, value);
		}

		[Ordinal(9)] 
		[RED("stopAtPathEnd")] 
		public CHandle<AIArgumentMapping> StopAtPathEnd
		{
			get => GetProperty(ref _stopAtPathEnd);
			set => SetProperty(ref _stopAtPathEnd, value);
		}

		[Ordinal(10)] 
		[RED("keepDistanceParamBool")] 
		public CHandle<AIArgumentMapping> KeepDistanceParamBool
		{
			get => GetProperty(ref _keepDistanceParamBool);
			set => SetProperty(ref _keepDistanceParamBool, value);
		}

		[Ordinal(11)] 
		[RED("keepDistanceParamCompanion")] 
		public CHandle<AIArgumentMapping> KeepDistanceParamCompanion
		{
			get => GetProperty(ref _keepDistanceParamCompanion);
			set => SetProperty(ref _keepDistanceParamCompanion, value);
		}

		[Ordinal(12)] 
		[RED("keepDistanceParamDistance")] 
		public CHandle<AIArgumentMapping> KeepDistanceParamDistance
		{
			get => GetProperty(ref _keepDistanceParamDistance);
			set => SetProperty(ref _keepDistanceParamDistance, value);
		}

		[Ordinal(13)] 
		[RED("rubberBandingBool")] 
		public CHandle<AIArgumentMapping> RubberBandingBool
		{
			get => GetProperty(ref _rubberBandingBool);
			set => SetProperty(ref _rubberBandingBool, value);
		}

		[Ordinal(14)] 
		[RED("rubberBandingTargetRef")] 
		public CHandle<AIArgumentMapping> RubberBandingTargetRef
		{
			get => GetProperty(ref _rubberBandingTargetRef);
			set => SetProperty(ref _rubberBandingTargetRef, value);
		}

		[Ordinal(15)] 
		[RED("rubberBandingMinDistance")] 
		public CHandle<AIArgumentMapping> RubberBandingMinDistance
		{
			get => GetProperty(ref _rubberBandingMinDistance);
			set => SetProperty(ref _rubberBandingMinDistance, value);
		}

		[Ordinal(16)] 
		[RED("rubberBandingMaxDistance")] 
		public CHandle<AIArgumentMapping> RubberBandingMaxDistance
		{
			get => GetProperty(ref _rubberBandingMaxDistance);
			set => SetProperty(ref _rubberBandingMaxDistance, value);
		}

		[Ordinal(17)] 
		[RED("rubberBandingStopAndWait")] 
		public CHandle<AIArgumentMapping> RubberBandingStopAndWait
		{
			get => GetProperty(ref _rubberBandingStopAndWait);
			set => SetProperty(ref _rubberBandingStopAndWait, value);
		}

		[Ordinal(18)] 
		[RED("rubberBandingTeleportToCatchUp")] 
		public CHandle<AIArgumentMapping> RubberBandingTeleportToCatchUp
		{
			get => GetProperty(ref _rubberBandingTeleportToCatchUp);
			set => SetProperty(ref _rubberBandingTeleportToCatchUp, value);
		}

		public AIbehaviorDriveFollowSplineTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

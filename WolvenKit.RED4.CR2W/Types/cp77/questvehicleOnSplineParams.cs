using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questvehicleOnSplineParams : questVehicleSpecificCommandParams
	{
		private NodeRef _splineRef;
		private CBool _reverseSpline;
		private CBool _backwards;
		private CBool _closest;
		private CFloat _forcedStartSpeed;
		private CBool _stopAtEnd;
		private CBool _keepDistance;
		private CHandle<questParamKeepDistance> _keepDistanceParam;
		private CBool _rubberBanding;
		private CHandle<questParamRubberbanding> _rubberBandingParam;

		[Ordinal(3)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetProperty(ref _splineRef);
			set => SetProperty(ref _splineRef, value);
		}

		[Ordinal(4)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get => GetProperty(ref _reverseSpline);
			set => SetProperty(ref _reverseSpline, value);
		}

		[Ordinal(5)] 
		[RED("backwards")] 
		public CBool Backwards
		{
			get => GetProperty(ref _backwards);
			set => SetProperty(ref _backwards, value);
		}

		[Ordinal(6)] 
		[RED("closest")] 
		public CBool Closest
		{
			get => GetProperty(ref _closest);
			set => SetProperty(ref _closest, value);
		}

		[Ordinal(7)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get => GetProperty(ref _forcedStartSpeed);
			set => SetProperty(ref _forcedStartSpeed, value);
		}

		[Ordinal(8)] 
		[RED("stopAtEnd")] 
		public CBool StopAtEnd
		{
			get => GetProperty(ref _stopAtEnd);
			set => SetProperty(ref _stopAtEnd, value);
		}

		[Ordinal(9)] 
		[RED("keepDistance")] 
		public CBool KeepDistance
		{
			get => GetProperty(ref _keepDistance);
			set => SetProperty(ref _keepDistance, value);
		}

		[Ordinal(10)] 
		[RED("keepDistanceParam")] 
		public CHandle<questParamKeepDistance> KeepDistanceParam
		{
			get => GetProperty(ref _keepDistanceParam);
			set => SetProperty(ref _keepDistanceParam, value);
		}

		[Ordinal(11)] 
		[RED("rubberBanding")] 
		public CBool RubberBanding
		{
			get => GetProperty(ref _rubberBanding);
			set => SetProperty(ref _rubberBanding, value);
		}

		[Ordinal(12)] 
		[RED("rubberBandingParam")] 
		public CHandle<questParamRubberbanding> RubberBandingParam
		{
			get => GetProperty(ref _rubberBandingParam);
			set => SetProperty(ref _rubberBandingParam, value);
		}

		public questvehicleOnSplineParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

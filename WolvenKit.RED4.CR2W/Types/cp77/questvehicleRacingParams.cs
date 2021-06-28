using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questvehicleRacingParams : questVehicleSpecificCommandParams
	{
		private NodeRef _splineRef;
		private CFloat _preciseLevel;
		private CBool _reverseSpline;
		private CBool _backwards;
		private CBool _closest;
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
		[RED("preciseLevel")] 
		public CFloat PreciseLevel
		{
			get => GetProperty(ref _preciseLevel);
			set => SetProperty(ref _preciseLevel, value);
		}

		[Ordinal(5)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get => GetProperty(ref _reverseSpline);
			set => SetProperty(ref _reverseSpline, value);
		}

		[Ordinal(6)] 
		[RED("backwards")] 
		public CBool Backwards
		{
			get => GetProperty(ref _backwards);
			set => SetProperty(ref _backwards, value);
		}

		[Ordinal(7)] 
		[RED("closest")] 
		public CBool Closest
		{
			get => GetProperty(ref _closest);
			set => SetProperty(ref _closest, value);
		}

		[Ordinal(8)] 
		[RED("rubberBanding")] 
		public CBool RubberBanding
		{
			get => GetProperty(ref _rubberBanding);
			set => SetProperty(ref _rubberBanding, value);
		}

		[Ordinal(9)] 
		[RED("rubberBandingParam")] 
		public CHandle<questParamRubberbanding> RubberBandingParam
		{
			get => GetProperty(ref _rubberBandingParam);
			set => SetProperty(ref _rubberBandingParam, value);
		}

		public questvehicleRacingParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

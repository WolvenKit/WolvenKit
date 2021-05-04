using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartsDependency_ : CVariable
	{
		private CName _masterPart;
		private CName _slavePart;
		private CFloat _angle;
		private CFloat _speedToTargetFactor;
		private curveData<CFloat> _speedToTargetByAngleCurve;
		private CFloat _verticalPullSpeedFactor;
		private curveData<CFloat> _verticalPullSpeedByAngleCurve;
		private CFloat _horizontalPullSpeedFactor;
		private curveData<CFloat> _horizontalPullSpeedByAngleCurve;
		private CFloat _pullScaleBySquareSizeFactor;
		private curveData<CFloat> _pullScaleBySquareSizeCurve;
		private CFloat _innerSquareScale;

		[Ordinal(0)] 
		[RED("masterPart")] 
		public CName MasterPart
		{
			get => GetProperty(ref _masterPart);
			set => SetProperty(ref _masterPart, value);
		}

		[Ordinal(1)] 
		[RED("slavePart")] 
		public CName SlavePart
		{
			get => GetProperty(ref _slavePart);
			set => SetProperty(ref _slavePart, value);
		}

		[Ordinal(2)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}

		[Ordinal(3)] 
		[RED("speedToTargetFactor")] 
		public CFloat SpeedToTargetFactor
		{
			get => GetProperty(ref _speedToTargetFactor);
			set => SetProperty(ref _speedToTargetFactor, value);
		}

		[Ordinal(4)] 
		[RED("speedToTargetByAngleCurve")] 
		public curveData<CFloat> SpeedToTargetByAngleCurve
		{
			get => GetProperty(ref _speedToTargetByAngleCurve);
			set => SetProperty(ref _speedToTargetByAngleCurve, value);
		}

		[Ordinal(5)] 
		[RED("verticalPullSpeedFactor")] 
		public CFloat VerticalPullSpeedFactor
		{
			get => GetProperty(ref _verticalPullSpeedFactor);
			set => SetProperty(ref _verticalPullSpeedFactor, value);
		}

		[Ordinal(6)] 
		[RED("verticalPullSpeedByAngleCurve")] 
		public curveData<CFloat> VerticalPullSpeedByAngleCurve
		{
			get => GetProperty(ref _verticalPullSpeedByAngleCurve);
			set => SetProperty(ref _verticalPullSpeedByAngleCurve, value);
		}

		[Ordinal(7)] 
		[RED("horizontalPullSpeedFactor")] 
		public CFloat HorizontalPullSpeedFactor
		{
			get => GetProperty(ref _horizontalPullSpeedFactor);
			set => SetProperty(ref _horizontalPullSpeedFactor, value);
		}

		[Ordinal(8)] 
		[RED("horizontalPullSpeedByAngleCurve")] 
		public curveData<CFloat> HorizontalPullSpeedByAngleCurve
		{
			get => GetProperty(ref _horizontalPullSpeedByAngleCurve);
			set => SetProperty(ref _horizontalPullSpeedByAngleCurve, value);
		}

		[Ordinal(9)] 
		[RED("pullScaleBySquareSizeFactor")] 
		public CFloat PullScaleBySquareSizeFactor
		{
			get => GetProperty(ref _pullScaleBySquareSizeFactor);
			set => SetProperty(ref _pullScaleBySquareSizeFactor, value);
		}

		[Ordinal(10)] 
		[RED("pullScaleBySquareSizeCurve")] 
		public curveData<CFloat> PullScaleBySquareSizeCurve
		{
			get => GetProperty(ref _pullScaleBySquareSizeCurve);
			set => SetProperty(ref _pullScaleBySquareSizeCurve, value);
		}

		[Ordinal(11)] 
		[RED("innerSquareScale")] 
		public CFloat InnerSquareScale
		{
			get => GetProperty(ref _innerSquareScale);
			set => SetProperty(ref _innerSquareScale, value);
		}

		public animLookAtPartsDependency_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

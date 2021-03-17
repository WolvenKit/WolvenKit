using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimeDilationProgressWithInputEvents : TimeDilationEventsTransitions
	{
		private CFloat _targetTimeScale;
		private CFloat _lerpMultiplier;
		private CFloat _duration;
		private CFloat _previousTimeStamp;
		private CName _easeInCurve;
		private CName _easeOutCurve;

		[Ordinal(0)] 
		[RED("targetTimeScale")] 
		public CFloat TargetTimeScale
		{
			get => GetProperty(ref _targetTimeScale);
			set => SetProperty(ref _targetTimeScale, value);
		}

		[Ordinal(1)] 
		[RED("lerpMultiplier")] 
		public CFloat LerpMultiplier
		{
			get => GetProperty(ref _lerpMultiplier);
			set => SetProperty(ref _lerpMultiplier, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("previousTimeStamp")] 
		public CFloat PreviousTimeStamp
		{
			get => GetProperty(ref _previousTimeStamp);
			set => SetProperty(ref _previousTimeStamp, value);
		}

		[Ordinal(4)] 
		[RED("easeInCurve")] 
		public CName EaseInCurve
		{
			get => GetProperty(ref _easeInCurve);
			set => SetProperty(ref _easeInCurve, value);
		}

		[Ordinal(5)] 
		[RED("easeOutCurve")] 
		public CName EaseOutCurve
		{
			get => GetProperty(ref _easeOutCurve);
			set => SetProperty(ref _easeOutCurve, value);
		}

		public TimeDilationProgressWithInputEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

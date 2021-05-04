using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimInterpolator : IScriptable
	{
		private CEnum<inkanimInterpolationMode> _interpolationMode;
		private CEnum<inkanimInterpolationType> _interpolationType;
		private CEnum<inkanimInterpolationDirection> _interpolationDirection;
		private CFloat _duration;
		private CFloat _startDelay;
		private CBool _useRelativeDuration;
		private CBool _isAdditive;

		[Ordinal(0)] 
		[RED("interpolationMode")] 
		public CEnum<inkanimInterpolationMode> InterpolationMode
		{
			get => GetProperty(ref _interpolationMode);
			set => SetProperty(ref _interpolationMode, value);
		}

		[Ordinal(1)] 
		[RED("interpolationType")] 
		public CEnum<inkanimInterpolationType> InterpolationType
		{
			get => GetProperty(ref _interpolationType);
			set => SetProperty(ref _interpolationType, value);
		}

		[Ordinal(2)] 
		[RED("interpolationDirection")] 
		public CEnum<inkanimInterpolationDirection> InterpolationDirection
		{
			get => GetProperty(ref _interpolationDirection);
			set => SetProperty(ref _interpolationDirection, value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("startDelay")] 
		public CFloat StartDelay
		{
			get => GetProperty(ref _startDelay);
			set => SetProperty(ref _startDelay, value);
		}

		[Ordinal(5)] 
		[RED("useRelativeDuration")] 
		public CBool UseRelativeDuration
		{
			get => GetProperty(ref _useRelativeDuration);
			set => SetProperty(ref _useRelativeDuration, value);
		}

		[Ordinal(6)] 
		[RED("isAdditive")] 
		public CBool IsAdditive
		{
			get => GetProperty(ref _isAdditive);
			set => SetProperty(ref _isAdditive, value);
		}

		public inkanimInterpolator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

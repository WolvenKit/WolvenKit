using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextAnimationController : inkWidgetLogicController
	{
		private CBool _playOnInitialize;
		private CName _animationName;
		private CBool _useDefaultAnimation;
		private CFloat _duration;
		private CFloat _startDelay;
		private CFloat _startValue;
		private CFloat _endValue;

		[Ordinal(1)] 
		[RED("playOnInitialize")] 
		public CBool PlayOnInitialize
		{
			get => GetProperty(ref _playOnInitialize);
			set => SetProperty(ref _playOnInitialize, value);
		}

		[Ordinal(2)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(3)] 
		[RED("useDefaultAnimation")] 
		public CBool UseDefaultAnimation
		{
			get => GetProperty(ref _useDefaultAnimation);
			set => SetProperty(ref _useDefaultAnimation, value);
		}

		[Ordinal(4)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(5)] 
		[RED("startDelay")] 
		public CFloat StartDelay
		{
			get => GetProperty(ref _startDelay);
			set => SetProperty(ref _startDelay, value);
		}

		[Ordinal(6)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get => GetProperty(ref _startValue);
			set => SetProperty(ref _startValue, value);
		}

		[Ordinal(7)] 
		[RED("endValue")] 
		public CFloat EndValue
		{
			get => GetProperty(ref _endValue);
			set => SetProperty(ref _endValue, value);
		}

		public inkTextAnimationController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

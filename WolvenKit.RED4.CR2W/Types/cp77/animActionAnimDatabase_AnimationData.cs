using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animActionAnimDatabase_AnimationData : CVariable
	{
		private CName _animationName;
		private CName _fallbackAnimationName;
		private CFloat _inTransitionDuration;
		private CBool _inCanRequestInertialization;
		private CFloat _outTransitionDuration;
		private CBool _outCanRequestInertialization;
		private CName _streamingContext;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(1)] 
		[RED("fallbackAnimationName")] 
		public CName FallbackAnimationName
		{
			get => GetProperty(ref _fallbackAnimationName);
			set => SetProperty(ref _fallbackAnimationName, value);
		}

		[Ordinal(2)] 
		[RED("inTransitionDuration")] 
		public CFloat InTransitionDuration
		{
			get => GetProperty(ref _inTransitionDuration);
			set => SetProperty(ref _inTransitionDuration, value);
		}

		[Ordinal(3)] 
		[RED("inCanRequestInertialization")] 
		public CBool InCanRequestInertialization
		{
			get => GetProperty(ref _inCanRequestInertialization);
			set => SetProperty(ref _inCanRequestInertialization, value);
		}

		[Ordinal(4)] 
		[RED("outTransitionDuration")] 
		public CFloat OutTransitionDuration
		{
			get => GetProperty(ref _outTransitionDuration);
			set => SetProperty(ref _outTransitionDuration, value);
		}

		[Ordinal(5)] 
		[RED("outCanRequestInertialization")] 
		public CBool OutCanRequestInertialization
		{
			get => GetProperty(ref _outCanRequestInertialization);
			set => SetProperty(ref _outCanRequestInertialization, value);
		}

		[Ordinal(6)] 
		[RED("streamingContext")] 
		public CName StreamingContext
		{
			get => GetProperty(ref _streamingContext);
			set => SetProperty(ref _streamingContext, value);
		}

		public animActionAnimDatabase_AnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

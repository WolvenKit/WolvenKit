using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animGenericAnimDatabase_AnimationData : RedBaseClass
	{
		private CName _animationName;
		private CName _fallbackAnimationName;
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
		[RED("streamingContext")] 
		public CName StreamingContext
		{
			get => GetProperty(ref _streamingContext);
			set => SetProperty(ref _streamingContext, value);
		}
	}
}

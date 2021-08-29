using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_Container : animAnimFeature
	{
		private CBool _opened;
		private CFloat _transitionDuration;

		[Ordinal(0)] 
		[RED("opened")] 
		public CBool Opened
		{
			get => GetProperty(ref _opened);
			set => SetProperty(ref _opened, value);
		}

		[Ordinal(1)] 
		[RED("transitionDuration")] 
		public CFloat TransitionDuration
		{
			get => GetProperty(ref _transitionDuration);
			set => SetProperty(ref _transitionDuration, value);
		}
	}
}

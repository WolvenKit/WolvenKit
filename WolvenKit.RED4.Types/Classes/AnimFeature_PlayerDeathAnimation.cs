using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_PlayerDeathAnimation : animAnimFeature
	{
		private CInt32 _animation;

		[Ordinal(0)] 
		[RED("animation")] 
		public CInt32 Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_LeftHandAnimation : animAnimFeature
	{
		private CBool _lockLeftHandAnimation;

		[Ordinal(0)] 
		[RED("lockLeftHandAnimation")] 
		public CBool LockLeftHandAnimation
		{
			get => GetProperty(ref _lockLeftHandAnimation);
			set => SetProperty(ref _lockLeftHandAnimation, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRoachRacePlayerController : gameuiSideScrollerMiniGamePlayerController
	{
		private CName _runAnimation;
		private CName _jumpAnimation;
		private CHandle<inkanimProxy> _currentAnimation;

		[Ordinal(1)] 
		[RED("runAnimation")] 
		public CName RunAnimation
		{
			get => GetProperty(ref _runAnimation);
			set => SetProperty(ref _runAnimation, value);
		}

		[Ordinal(2)] 
		[RED("jumpAnimation")] 
		public CName JumpAnimation
		{
			get => GetProperty(ref _jumpAnimation);
			set => SetProperty(ref _jumpAnimation, value);
		}

		[Ordinal(3)] 
		[RED("currentAnimation")] 
		public CHandle<inkanimProxy> CurrentAnimation
		{
			get => GetProperty(ref _currentAnimation);
			set => SetProperty(ref _currentAnimation, value);
		}
	}
}

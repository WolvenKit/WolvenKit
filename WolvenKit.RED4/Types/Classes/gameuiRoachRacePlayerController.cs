using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRoachRacePlayerController : gameuiSideScrollerMiniGamePlayerController
	{
		[Ordinal(1)] 
		[RED("runAnimation")] 
		public CName RunAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("jumpAnimation")] 
		public CName JumpAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("currentAnimation")] 
		public CHandle<inkanimProxy> CurrentAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public gameuiRoachRacePlayerController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

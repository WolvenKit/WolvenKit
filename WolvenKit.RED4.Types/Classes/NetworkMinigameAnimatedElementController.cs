using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkMinigameAnimatedElementController : NetworkMinigameElementController
	{
		[Ordinal(12)] 
		[RED("onConsumeAnimation")] 
		public CName OnConsumeAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("onSetContentAnimation")] 
		public CName OnSetContentAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("onHighlightOnAnimation")] 
		public CName OnHighlightOnAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("onHighlightOffAnimation")] 
		public CName OnHighlightOffAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public NetworkMinigameAnimatedElementController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

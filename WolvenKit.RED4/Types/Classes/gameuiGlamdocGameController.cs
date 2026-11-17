using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGlamdocGameController : gameuiBaseMenuGameController
	{
		[Ordinal(3)] 
		[RED("previewSceneName")] 
		public CName PreviewSceneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("timeToWaitToRevealPreview")] 
		public CFloat TimeToWaitToRevealPreview
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiGlamdocGameController()
		{
			PreviewSceneName = "inventory";
			TimeToWaitToRevealPreview = 4.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

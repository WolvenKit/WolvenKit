using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingNotification : GenericNotificationController
	{
		[Ordinal(15)] 
		[RED("introAnimation")] 
		public CHandle<inkanimProxy> IntroAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public CraftingNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

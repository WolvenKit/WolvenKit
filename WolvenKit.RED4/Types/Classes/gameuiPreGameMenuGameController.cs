using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPreGameMenuGameController : gameuiBaseMenuGameController
	{
		[Ordinal(3)] 
		[RED("saveMessageToken")] 
		public CHandle<inkGameNotificationToken> SaveMessageToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		public gameuiPreGameMenuGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

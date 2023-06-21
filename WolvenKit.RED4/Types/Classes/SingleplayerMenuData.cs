using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SingleplayerMenuData : inkUserData
	{
		[Ordinal(0)] 
		[RED("mainMenuShownFirstTime")] 
		public CBool MainMenuShownFirstTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SingleplayerMenuData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

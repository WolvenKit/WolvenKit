using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LanguageDropdownButtonController : DropdownButtonController
	{
		[Ordinal(5)] 
		[RED("ownerWidget")] 
		public CWeakHandle<ModDetailsItem> OwnerWidget
		{
			get => GetPropertyValue<CWeakHandle<ModDetailsItem>>();
			set => SetPropertyValue<CWeakHandle<ModDetailsItem>>(value);
		}

		[Ordinal(6)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(7)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		public LanguageDropdownButtonController()
		{
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModPaginationArrowController : PaginationArrowController
	{
		[Ordinal(2)] 
		[RED("bIsLeftArrow")] 
		public CBool BIsLeftArrow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		public ModPaginationArrowController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

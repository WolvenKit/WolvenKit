using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewGameMenuGameController : PreGameSubMenuGameController
	{
		[Ordinal(3)] 
		[RED("categories")] 
		public CWeakHandle<inkSelectorController> Categories
		{
			get => GetPropertyValue<CWeakHandle<inkSelectorController>>();
			set => SetPropertyValue<CWeakHandle<inkSelectorController>>(value);
		}

		[Ordinal(4)] 
		[RED("gameDefinitions")] 
		public CWeakHandle<inkSelectorController> GameDefinitions
		{
			get => GetPropertyValue<CWeakHandle<inkSelectorController>>();
			set => SetPropertyValue<CWeakHandle<inkSelectorController>>(value);
		}

		[Ordinal(5)] 
		[RED("genders")] 
		public CWeakHandle<inkSelectorController> Genders
		{
			get => GetPropertyValue<CWeakHandle<inkSelectorController>>();
			set => SetPropertyValue<CWeakHandle<inkSelectorController>>(value);
		}

		public NewGameMenuGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

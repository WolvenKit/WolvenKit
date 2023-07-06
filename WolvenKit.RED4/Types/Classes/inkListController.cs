using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkListController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("itemLibraryID")] 
		public CName ItemLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("cycledNavigation")] 
		public CBool CycledNavigation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("beginToggled")] 
		public CBool BeginToggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("ItemSelected")] 
		public inkListControllerCallback ItemSelected
		{
			get => GetPropertyValue<inkListControllerCallback>();
			set => SetPropertyValue<inkListControllerCallback>(value);
		}

		[Ordinal(5)] 
		[RED("ItemActivated")] 
		public inkListControllerCallback ItemActivated
		{
			get => GetPropertyValue<inkListControllerCallback>();
			set => SetPropertyValue<inkListControllerCallback>(value);
		}

		public inkListController()
		{
			ItemSelected = new inkListControllerCallback();
			ItemActivated = new inkListControllerCallback();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

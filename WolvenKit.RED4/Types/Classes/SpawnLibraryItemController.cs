using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpawnLibraryItemController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SpawnLibraryItemController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

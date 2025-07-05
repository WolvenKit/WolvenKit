using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeArcadeSpawnerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("objectLibraryID")] 
		public CName ObjectLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("initialObjectsCount")] 
		public CUInt32 InitialObjectsCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiarcadeArcadeSpawnerController()
		{
			ObjectLibraryID = "DefaultObject";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

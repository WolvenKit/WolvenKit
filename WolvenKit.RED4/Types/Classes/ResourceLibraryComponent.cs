using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ResourceLibraryComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("resources")] 
		public CArray<FxResourceMapData> Resources
		{
			get => GetPropertyValue<CArray<FxResourceMapData>>();
			set => SetPropertyValue<CArray<FxResourceMapData>>(value);
		}

		public ResourceLibraryComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

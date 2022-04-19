using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkGameNotificationsLayerDefinition : inkLayerDefinition
	{
		[Ordinal(8)] 
		[RED("cursorResource")] 
		public CResourceReference<inkWidgetLibraryResource> CursorResource
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		public inkGameNotificationsLayerDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

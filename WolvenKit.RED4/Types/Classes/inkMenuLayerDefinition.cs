using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkMenuLayerDefinition : inkLayerDefinition
	{
		[Ordinal(8)] 
		[RED("menuResource")] 
		public CResourceReference<inkMenuResource> MenuResource
		{
			get => GetPropertyValue<CResourceReference<inkMenuResource>>();
			set => SetPropertyValue<CResourceReference<inkMenuResource>>(value);
		}

		[Ordinal(9)] 
		[RED("cursorResource")] 
		public CResourceReference<inkWidgetLibraryResource> CursorResource
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		public inkMenuLayerDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

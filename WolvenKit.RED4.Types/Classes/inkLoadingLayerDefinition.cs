using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLoadingLayerDefinition : inkLayerDefinition
	{
		[Ordinal(8)] 
		[RED("splashLoadingScreenResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> SplashLoadingScreenResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(9)] 
		[RED("initialLoadingScreenResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> InitialLoadingScreenResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(10)] 
		[RED("fastTravelLoadingScreenResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> FastTravelLoadingScreenResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(11)] 
		[RED("fallbackLoadingScreenResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> FallbackLoadingScreenResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		public inkLoadingLayerDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

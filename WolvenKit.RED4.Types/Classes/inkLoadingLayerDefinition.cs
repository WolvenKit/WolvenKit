using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLoadingLayerDefinition : inkLayerDefinition
	{
		private CResourceAsyncReference<inkWidgetLibraryResource> _splashLoadingScreenResource;
		private CResourceAsyncReference<inkWidgetLibraryResource> _initialLoadingScreenResource;
		private CResourceAsyncReference<inkWidgetLibraryResource> _fastTravelLoadingScreenResource;
		private CResourceAsyncReference<inkWidgetLibraryResource> _fallbackLoadingScreenResource;

		[Ordinal(8)] 
		[RED("splashLoadingScreenResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> SplashLoadingScreenResource
		{
			get => GetProperty(ref _splashLoadingScreenResource);
			set => SetProperty(ref _splashLoadingScreenResource, value);
		}

		[Ordinal(9)] 
		[RED("initialLoadingScreenResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> InitialLoadingScreenResource
		{
			get => GetProperty(ref _initialLoadingScreenResource);
			set => SetProperty(ref _initialLoadingScreenResource, value);
		}

		[Ordinal(10)] 
		[RED("fastTravelLoadingScreenResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> FastTravelLoadingScreenResource
		{
			get => GetProperty(ref _fastTravelLoadingScreenResource);
			set => SetProperty(ref _fastTravelLoadingScreenResource, value);
		}

		[Ordinal(11)] 
		[RED("fallbackLoadingScreenResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> FallbackLoadingScreenResource
		{
			get => GetProperty(ref _fallbackLoadingScreenResource);
			set => SetProperty(ref _fallbackLoadingScreenResource, value);
		}
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLoadingLayerDefinition : inkLayerDefinition
	{
		private raRef<inkWidgetLibraryResource> _splashLoadingScreenResource;
		private raRef<inkWidgetLibraryResource> _initialLoadingScreenResource;
		private raRef<inkWidgetLibraryResource> _fastTravelLoadingScreenResource;
		private raRef<inkWidgetLibraryResource> _fallbackLoadingScreenResource;

		[Ordinal(8)] 
		[RED("splashLoadingScreenResource")] 
		public raRef<inkWidgetLibraryResource> SplashLoadingScreenResource
		{
			get => GetProperty(ref _splashLoadingScreenResource);
			set => SetProperty(ref _splashLoadingScreenResource, value);
		}

		[Ordinal(9)] 
		[RED("initialLoadingScreenResource")] 
		public raRef<inkWidgetLibraryResource> InitialLoadingScreenResource
		{
			get => GetProperty(ref _initialLoadingScreenResource);
			set => SetProperty(ref _initialLoadingScreenResource, value);
		}

		[Ordinal(10)] 
		[RED("fastTravelLoadingScreenResource")] 
		public raRef<inkWidgetLibraryResource> FastTravelLoadingScreenResource
		{
			get => GetProperty(ref _fastTravelLoadingScreenResource);
			set => SetProperty(ref _fastTravelLoadingScreenResource, value);
		}

		[Ordinal(11)] 
		[RED("fallbackLoadingScreenResource")] 
		public raRef<inkWidgetLibraryResource> FallbackLoadingScreenResource
		{
			get => GetProperty(ref _fallbackLoadingScreenResource);
			set => SetProperty(ref _fallbackLoadingScreenResource, value);
		}

		public inkLoadingLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

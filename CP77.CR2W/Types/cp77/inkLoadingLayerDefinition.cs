using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkLoadingLayerDefinition : inkLayerDefinition
	{
		[Ordinal(8)] [RED("splashLoadingScreenResource")] public raRef<inkWidgetLibraryResource> SplashLoadingScreenResource { get; set; }
		[Ordinal(9)] [RED("initialLoadingScreenResource")] public raRef<inkWidgetLibraryResource> InitialLoadingScreenResource { get; set; }
		[Ordinal(10)] [RED("fastTravelLoadingScreenResource")] public raRef<inkWidgetLibraryResource> FastTravelLoadingScreenResource { get; set; }
		[Ordinal(11)] [RED("fallbackLoadingScreenResource")] public raRef<inkWidgetLibraryResource> FallbackLoadingScreenResource { get; set; }

		public inkLoadingLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

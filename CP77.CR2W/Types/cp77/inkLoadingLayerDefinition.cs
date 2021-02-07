using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkLoadingLayerDefinition : inkLayerDefinition
	{
		[Ordinal(0)]  [RED("splashLoadingScreenResource")] public raRef<inkWidgetLibraryResource> SplashLoadingScreenResource { get; set; }
		[Ordinal(1)]  [RED("initialLoadingScreenResource")] public raRef<inkWidgetLibraryResource> InitialLoadingScreenResource { get; set; }
		[Ordinal(2)]  [RED("fastTravelLoadingScreenResource")] public raRef<inkWidgetLibraryResource> FastTravelLoadingScreenResource { get; set; }
		[Ordinal(3)]  [RED("fallbackLoadingScreenResource")] public raRef<inkWidgetLibraryResource> FallbackLoadingScreenResource { get; set; }

		public inkLoadingLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

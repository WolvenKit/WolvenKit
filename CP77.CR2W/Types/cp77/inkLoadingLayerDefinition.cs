using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkLoadingLayerDefinition : inkLayerDefinition
	{
		[Ordinal(0)]  [RED("fallbackLoadingScreenResource")] public raRef<inkWidgetLibraryResource> FallbackLoadingScreenResource { get; set; }
		[Ordinal(1)]  [RED("fastTravelLoadingScreenResource")] public raRef<inkWidgetLibraryResource> FastTravelLoadingScreenResource { get; set; }
		[Ordinal(2)]  [RED("initialLoadingScreenResource")] public raRef<inkWidgetLibraryResource> InitialLoadingScreenResource { get; set; }
		[Ordinal(3)]  [RED("splashLoadingScreenResource")] public raRef<inkWidgetLibraryResource> SplashLoadingScreenResource { get; set; }

		public inkLoadingLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

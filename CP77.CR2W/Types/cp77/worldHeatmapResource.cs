using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldHeatmapResource : CResource
	{
		[Ordinal(1)] [RED("setup")] public worldHeatmapSetup Setup { get; set; }
		[Ordinal(2)] [RED("name")] public CString Name { get; set; }
		[Ordinal(3)] [RED("layerNames")] public CArray<CString> LayerNames { get; set; }
		[Ordinal(4)] [RED("layers")] public CArray<raRef<worldHeatmapLayer>> Layers { get; set; }

		public worldHeatmapResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

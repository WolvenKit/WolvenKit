using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldHeatmapLayer : CResource
	{
		[Ordinal(0)]  [RED("invert")] public CBool Invert { get; set; }
		[Ordinal(1)]  [RED("maxValue")] public CUInt32 MaxValue { get; set; }
		[Ordinal(2)]  [RED("minValue")] public CUInt32 MinValue { get; set; }
		[Ordinal(3)]  [RED("name")] public CString Name { get; set; }
		[Ordinal(4)]  [RED("units")] public CString Units { get; set; }

		public worldHeatmapLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

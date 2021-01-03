using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_InteriorExterior : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("exteriorColor")] public CColor ExteriorColor { get; set; }
		[Ordinal(1)]  [RED("interiorColor")] public CColor InteriorColor { get; set; }
		[Ordinal(2)]  [RED("openInteriorColor")] public CColor OpenInteriorColor { get; set; }

		public worldDebugColoring_InteriorExterior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

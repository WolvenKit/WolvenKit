using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_StreamingCullingFlag : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("cullableColor")] public CColor CullableColor { get; set; }
		[Ordinal(1)]  [RED("defaultColor")] public CColor DefaultColor { get; set; }
		[Ordinal(2)]  [RED("forceCulledAlwaysColor")] public CColor ForceCulledAlwaysColor { get; set; }
		[Ordinal(3)]  [RED("forceCulledPeripheralColor")] public CColor ForceCulledPeripheralColor { get; set; }

		public worldDebugColoring_StreamingCullingFlag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

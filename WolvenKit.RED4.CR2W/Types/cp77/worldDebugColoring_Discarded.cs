using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_Discarded : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] [RED("color")] public CColor Color { get; set; }

		public worldDebugColoring_Discarded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

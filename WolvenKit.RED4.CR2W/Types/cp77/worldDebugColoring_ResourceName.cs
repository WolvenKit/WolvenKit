using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_ResourceName : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] [RED("names")] public CArray<worldNameColorPair> Names { get; set; }
		[Ordinal(1)] [RED("defaultColor")] public CColor DefaultColor { get; set; }

		public worldDebugColoring_ResourceName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

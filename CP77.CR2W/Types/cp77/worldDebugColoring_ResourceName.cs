using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_ResourceName : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("defaultColor")] public CColor DefaultColor { get; set; }
		[Ordinal(1)]  [RED("names")] public CArray<worldNameColorPair> Names { get; set; }

		public worldDebugColoring_ResourceName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

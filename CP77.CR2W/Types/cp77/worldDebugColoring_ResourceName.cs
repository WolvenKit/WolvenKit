using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_ResourceName : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("defaultColor")] public CColor DefaultColor { get; set; }
		[Ordinal(1)]  [RED("names")] public CArray<worldNameColorPair> Names { get; set; }

		public worldDebugColoring_ResourceName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_NavigationImpact : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] [RED("walkable")] public CColor Walkable { get; set; }
		[Ordinal(1)] [RED("ignored")] public CColor Ignored { get; set; }
		[Ordinal(2)] [RED("blocking")] public CColor Blocking { get; set; }
		[Ordinal(3)] [RED("road")] public CColor Road { get; set; }
		[Ordinal(4)] [RED("crowd walkable")] public CColor Crowd_walkable { get; set; }
		[Ordinal(5)] [RED("staris walkable")] public CColor Staris_walkable { get; set; }
		[Ordinal(6)] [RED("drones")] public CColor Drones { get; set; }
		[Ordinal(7)] [RED("everythign else")] public CColor Everythign_else { get; set; }

		public worldDebugColoring_NavigationImpact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

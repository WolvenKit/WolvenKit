using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_ProxyMeshDependency : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] [RED("autoColor")] public CColor AutoColor { get; set; }
		[Ordinal(1)] [RED("discardColor")] public CColor DiscardColor { get; set; }

		public worldDebugColoring_ProxyMeshDependency(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

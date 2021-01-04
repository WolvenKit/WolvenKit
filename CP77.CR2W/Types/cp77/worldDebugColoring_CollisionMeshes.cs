using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_CollisionMeshes : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("collisionMeshColor")] public CColor CollisionMeshColor { get; set; }
		[Ordinal(1)]  [RED("defaultColor")] public CColor DefaultColor { get; set; }
		[Ordinal(2)]  [RED("prefabColor")] public CColor PrefabColor { get; set; }

		public worldDebugColoring_CollisionMeshes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

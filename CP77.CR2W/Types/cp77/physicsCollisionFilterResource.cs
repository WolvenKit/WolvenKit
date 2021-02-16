using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionFilterResource : ISerializable
	{
		[Ordinal(0)] [RED("presetJson")] public rRef<JsonResource> PresetJson { get; set; }
		[Ordinal(1)] [RED("overridesJson")] public rRef<JsonResource> OverridesJson { get; set; }
		[Ordinal(2)] [RED("collisionGroups", 64)] public CStatic<CName> CollisionGroups { get; set; }
		[Ordinal(3)] [RED("queryGroups", 64)] public CStatic<CName> QueryGroups { get; set; }

		public physicsCollisionFilterResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

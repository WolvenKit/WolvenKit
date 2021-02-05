using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionPreset : ISerializable
	{
		[Ordinal(0)]  [RED("Name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("ForceEnableCollisionCallbacks")] public CBool ForceEnableCollisionCallbacks { get; set; }
		[Ordinal(2)]  [RED("CollisionType")] public CArray<CName> CollisionType { get; set; }
		[Ordinal(3)]  [RED("CollisionMask")] public CArray<CName> CollisionMask { get; set; }
		[Ordinal(4)]  [RED("QueryDetect")] public CArray<CName> QueryDetect { get; set; }

		public physicsCollisionPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

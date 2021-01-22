using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsSystemBody : physicsISystemObject
	{
		[Ordinal(0)]  [RED("collisionShapes")] public CArray<CHandle<physicsICollider>> CollisionShapes { get; set; }
		[Ordinal(1)]  [RED("isQueryBodyOnly")] public CBool IsQueryBodyOnly { get; set; }
		[Ordinal(2)]  [RED("localToModel")] public Transform LocalToModel { get; set; }
		[Ordinal(3)]  [RED("mappedBoneName")] public CName MappedBoneName { get; set; }
		[Ordinal(4)]  [RED("mappedBoneToBody")] public Transform MappedBoneToBody { get; set; }
		[Ordinal(5)]  [RED("params")] public physicsSystemBodyParams Params { get; set; }

		public physicsSystemBody(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

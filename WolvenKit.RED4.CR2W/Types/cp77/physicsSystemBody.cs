using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSystemBody : physicsISystemObject
	{
		[Ordinal(1)] [RED("params")] public physicsSystemBodyParams Params { get; set; }
		[Ordinal(2)] [RED("localToModel")] public Transform LocalToModel { get; set; }
		[Ordinal(3)] [RED("collisionShapes")] public CArray<CHandle<physicsICollider>> CollisionShapes { get; set; }
		[Ordinal(4)] [RED("mappedBoneName")] public CName MappedBoneName { get; set; }
		[Ordinal(5)] [RED("mappedBoneToBody")] public Transform MappedBoneToBody { get; set; }
		[Ordinal(6)] [RED("isQueryBodyOnly")] public CBool IsQueryBodyOnly { get; set; }

		public physicsSystemBody(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldNode : ISerializable
	{
		[Ordinal(0)]  [RED("isVisibleInGame")] public CBool IsVisibleInGame { get; set; }
		[Ordinal(1)]  [RED("isHostOnly")] public CBool IsHostOnly { get; set; }

        [Ordinal(995)] [RED("proxyScale")] public Vector3 proxyScale { get; set; }
        [Ordinal(996)] [RED("tagExt")] public CEnum<worldObjectTagExt> tagExt { get; set; }
        [Ordinal(997)] [RED("tag")] public CEnum<worldObjectTag> tag { get; set; }
        [Ordinal(998)] [RED("sourcePrefabHash")] public CUInt64 sourcePrefabHash { get; set; }
        [Ordinal(999)] [RED("debugName")] public CName debugName { get; set; }

		public worldNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

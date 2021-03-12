using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class worldNode : worldNode_
    {
        [Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
        [Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }

        [Ordinal(997)] [RED("proxyScale")] public Vector3 ProxyScale_995 { get; set; }
        [Ordinal(998)] [RED("tag")] public CEnum<worldObjectTag> Tag { get; set; }
        [Ordinal(999)] [RED("tagExt")] public CEnum<worldObjectTagExt> TagExt { get; set; }

        public worldNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

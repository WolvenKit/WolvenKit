using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    public class animAnimNode_AddSnapToTerrainIkRequest : animAnimNode_AddSnapToTerrainIkRequest_
    {
        [Ordinal(12)] [RED("debug")] public CBool Debug { get; set; }

        public animAnimNode_AddSnapToTerrainIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

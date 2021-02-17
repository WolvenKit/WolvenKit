using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animAnimGraph : animAnimGraph_
    {
        [Ordinal(999)] [RED("jsonFilesDirectory")] public CString JsonFilesDirectory { get; set; }

        public animAnimGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animLookAtPartInfo : animLookAtPartInfo_
    {
        //[Ordinal(999)] [RED("debugDrawingEnabled")] public CBool DebugDrawingEnabled { get; set; }

        public animLookAtPartInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animLookAtRequest : animLookAtRequest_
    {
        [Ordinal(999)] [RED("debugInfo")] public CString DebugInfo { get; set; }

        public animLookAtRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

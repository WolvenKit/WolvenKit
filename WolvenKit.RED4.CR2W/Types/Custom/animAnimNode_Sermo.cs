using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_Sermo : animAnimNode_Sermo_
    {
        [Ordinal(999)] [RED("testController")] public animSermoTestController TestController { get; set; }

        public animAnimNode_Sermo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_Sermo : animAnimNode_Sermo_
    {
        private animSermoTestController _testController;

        [Ordinal(999)]
        [RED("testController")]
        public animSermoTestController TestController
        {
            get => GetProperty(ref _testController);
            set => SetProperty(ref _testController, value);
        }

        public animAnimNode_Sermo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

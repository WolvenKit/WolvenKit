using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animLookAtRequest : animLookAtRequest_
    {
        private CString _debugInfo;

        [Ordinal(999)]
        [RED("debugInfo")]
        public CString DebugInfo
        {
            get => GetProperty(ref _debugInfo);
            set => SetProperty(ref _debugInfo, value);
        }

        public animLookAtRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

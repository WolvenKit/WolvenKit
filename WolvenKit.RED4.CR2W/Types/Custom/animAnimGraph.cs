using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimGraph : animAnimGraph_
    {
        private CString _jsonFilesDirectory;

        [Ordinal(999)]
        [RED("jsonFilesDirectory")]
        public CString JsonFilesDirectory
        {
            get => GetProperty(ref _jsonFilesDirectory);
            set => SetProperty(ref _jsonFilesDirectory, value);
        }

        public animAnimGraph(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

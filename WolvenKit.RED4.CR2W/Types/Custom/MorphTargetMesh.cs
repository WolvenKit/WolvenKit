using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class MorphTargetMesh : MorphTargetMesh_
    {
        private CUInt8 _resourceVersion;

        [Ordinal(999)]
        [RED("resourceVersion")]
        public CUInt8 ResourceVersion
        {
            get => GetProperty(ref _resourceVersion);
            set => SetProperty(ref _resourceVersion, value);
        }

        public MorphTargetMesh(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

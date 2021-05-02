using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    public class animLipsyncMapping : animLipsyncMapping_
    {
        private CArray<CUInt64> _scenePreviewPaths;

        [Ordinal(3)]
        [RED("scenePreviewPaths")]
        public CArray<CUInt64> ScenePreviewPaths
        {
            get => GetProperty(ref _scenePreviewPaths);
            set => SetProperty(ref _scenePreviewPaths, value);
        }

        public animLipsyncMapping(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

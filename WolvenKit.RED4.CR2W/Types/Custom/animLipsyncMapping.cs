using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    public class animLipsyncMapping : animLipsyncMapping_
    {
        [Ordinal(3)] [RED("scenePreviewPaths")] public CArray<CUInt64> ScenePreviewPaths { get; set; }

        public animLipsyncMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

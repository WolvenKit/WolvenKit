using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    public class STextureGroupSetup : STextureGroupSetup_
    {
        [Ordinal(6)] [RED("alphaToCoverageThreshold")] public CUInt8 AlphaToCoverageThreshold { get; set; }

        public STextureGroupSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

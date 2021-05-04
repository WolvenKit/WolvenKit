using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    public class STextureGroupSetup : STextureGroupSetup_
    {
        private CUInt8 _alphaToCoverageThreshold;

        [Ordinal(6)]
        [RED("alphaToCoverageThreshold")]
        public CUInt8 AlphaToCoverageThreshold
        {
            get => GetProperty(ref _alphaToCoverageThreshold);
            set => SetProperty(ref _alphaToCoverageThreshold, value);
        }

        public STextureGroupSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

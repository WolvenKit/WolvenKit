using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
	public class worldTrafficLanesSpotsResource : worldTrafficLanesSpotsResource_
    {
        private CUInt32 _unk1;

        [Ordinal(1000)]
        [REDBuffer]
        public CUInt32 Unk1
        {
            get => GetProperty(ref _unk1);
            set => SetProperty(ref _unk1, value);
        }

        public worldTrafficLanesSpotsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

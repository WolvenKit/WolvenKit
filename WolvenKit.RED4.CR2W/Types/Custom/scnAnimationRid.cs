using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class scnAnimationRid : scnAnimationRid_
    {
        private CHandle<IBackendData> _backendData;

        [Ordinal(999)]
        [RED("backendData")]
        public CHandle<IBackendData> BackendData
        {
            get => GetProperty(ref _backendData);
            set => SetProperty(ref _backendData, value);
        }

        public scnAnimationRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

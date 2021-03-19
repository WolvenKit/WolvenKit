using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class CMesh : CMesh_
    {
        private CUInt8 _resourceVersion;
        private CUInt8 _consoleBias;
        private CDateTime _saveDateTime;
        private CUInt64 _geometryHash;

        [Ordinal(1)]
        [RED("resourceVersion")]
        public CUInt8 ResourceVersion
        {
            get => GetProperty(ref _resourceVersion);
            set => SetProperty(ref _resourceVersion, value);
        }

        [Ordinal(5)]
        [RED("consoleBias")]
        public CUInt8 ConsoleBias
        {
            get => GetProperty(ref _consoleBias);
            set => SetProperty(ref _consoleBias, value);
        }

        [Ordinal(21)]
        [RED("saveDateTime")]
        public CDateTime SaveDateTime
        {
            get => GetProperty(ref _saveDateTime);
            set => SetProperty(ref _saveDateTime, value);
        }

        [Ordinal(997)]
        [RED("geometryHash")]
        public CUInt64 GeometryHash
        {
            get => GetProperty(ref _geometryHash);
            set => SetProperty(ref _geometryHash, value);
        }

        public CMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

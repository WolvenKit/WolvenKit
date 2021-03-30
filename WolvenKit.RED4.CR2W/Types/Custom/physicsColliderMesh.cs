using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
	public class physicsColliderMesh : physicsColliderMesh_
    {
        private CArrayVLQInt32<physicsColliderMeshData> _unk1;
        private CArrayVLQInt32<physicsColliderMeshData> _unk2;
        private CArrayVLQInt32<physicsColliderMeshData> _unk3;

        [Ordinal(1000)]
        [REDBuffer]
        public CArrayVLQInt32<physicsColliderMeshData> Unk1
        {
            get => GetProperty(ref _unk1);
            set => SetProperty(ref _unk1, value);
        }

        [Ordinal(1001)]
        [REDBuffer]
        public CArrayVLQInt32<physicsColliderMeshData> Unk2
        {
            get => GetProperty(ref _unk2);
            set => SetProperty(ref _unk2, value);
        }

        [Ordinal(1002)]
        [REDBuffer]
        public CArrayVLQInt32<physicsColliderMeshData> Unk3
        {
            get => GetProperty(ref _unk3);
            set => SetProperty(ref _unk3, value);
        }

        public physicsColliderMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta(EREDMetaInfo.REDStruct)]
    public class physicsColliderMeshData : CVariable
    {
        private CUInt16 _unk1;

        [Ordinal(0)]
        [REDBuffer]
        public CUInt16 Unk1
        {
            get => GetProperty(ref _unk1);
            set => SetProperty(ref _unk1, value);
        }

        public physicsColliderMeshData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}

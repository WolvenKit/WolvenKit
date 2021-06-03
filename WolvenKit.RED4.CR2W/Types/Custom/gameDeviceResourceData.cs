using System.IO;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using WolvenKit.Core.Extensions;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
	public class gameDeviceResourceData : gameDeviceResourceData_
    {
        private CArray<gameCookedDeviceDataCompressed> _cookedDeviceData;

        [Ordinal(1000)]
        [REDBuffer(true)]
        public CArray<gameCookedDeviceDataCompressed> CookedDeviceData
        {
            get => GetProperty(ref _cookedDeviceData);
            set => SetProperty(ref _cookedDeviceData, value);
        }

        public gameDeviceResourceData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            CookedDeviceData = CR2WTypeManager.Create("array:gameCookedDeviceDataCompressed",
                nameof(CookedDeviceData), cr2w, this) as CArray<gameCookedDeviceDataCompressed>;
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var buffersize = file.ReadUInt32();

            CookedDeviceData.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);
            CookedDeviceData.Write(bw);

            file.Write((uint)ms.Position + 4);
            file.Write(ms.ToByteArray());
        }
    }

    [REDMeta(EREDMetaInfo.REDStruct)]
    public class gameCookedDeviceDataCompressed : CVariable
    {
        private CUInt64 _hash;
        private CName _className;
        private CArrayCompressed<CUInt64> _parents;
        private CArrayCompressed<CUInt64> _children;
        private Vector3 _nodePosition;

        [Ordinal(0)]
        [RED("Hash")]
        public CUInt64 Hash
        {
            get => GetProperty(ref _hash);
            set => SetProperty(ref _hash, value);
        }

        [Ordinal(1)]
        [RED("className")]
        public CName ClassName
        {
            get => GetProperty(ref _className);
            set => SetProperty(ref _className, value);
        }

        [Ordinal(2)]
        [REDBuffer(true)]
        public CArrayCompressed<CUInt64> Parents
        {
            get => GetProperty(ref _parents);
            set => SetProperty(ref _parents, value);
        }

        [Ordinal(3)]
        [REDBuffer(true)]
        public CArrayCompressed<CUInt64> Children
        {
            get => GetProperty(ref _children);
            set => SetProperty(ref _children, value);
        }

        [Ordinal(4)]
        [REDBuffer(true)]
        public Vector3 NodePosition
        {
            get => GetProperty(ref _nodePosition);
            set => SetProperty(ref _nodePosition, value);
        }

        public gameCookedDeviceDataCompressed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Parents = new CArrayCompressed<CUInt64>(cr2w, this, nameof(Parents)) { IsSerialized = true };
            Children = new CArrayCompressed<CUInt64>(cr2w, this, nameof(Children)) { IsSerialized = true };
            NodePosition = new Vector3(cr2w, this, nameof(NodePosition)) { IsSerialized = true };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var childrencount = file.ReadVLQInt32();
            var parentcount = file.ReadVLQInt32();

            Children.Read(file, 8, childrencount);
            Parents.Read(file, 8, parentcount);

            NodePosition.ReadAsFixedSize(file, 12);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            file.WriteVLQInt32(Children.Count);
            file.WriteVLQInt32(Parents.Count);

            Children.Write(file);
            Parents.Write(file);

            NodePosition.WriteAsFixedSize(file);
        }
    }
}

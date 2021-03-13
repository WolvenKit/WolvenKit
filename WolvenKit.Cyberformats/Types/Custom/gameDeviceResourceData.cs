using System.IO;
using Catel.IO;
using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
	public class gameDeviceResourceData : gameDeviceResourceData_
    {
        [Ordinal(1000)] [REDBuffer(true)] public CArray<gameCookedDeviceDataCompressed> CookedDeviceData { get; set; }

        public gameDeviceResourceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
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
        [Ordinal(0)] [RED("Hash")] public CUInt64 Hash { get; set; }
        [Ordinal(1)] [RED("className")] public CName ClassName { get; set; }
        [Ordinal(2)] [REDBuffer(true)] public CArrayCompressed<CUInt64> Parents { get; set; }
        [Ordinal(3)] [REDBuffer(true)] public CArrayCompressed<CUInt64> Children { get; set; }
        [Ordinal(4)] [REDBuffer(true)] public Vector3 NodePosition { get; set; }

        public gameCookedDeviceDataCompressed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
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

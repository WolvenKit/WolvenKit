using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SVector3D : CVariable
    {
        [RED] public CFloat X { get; set; }
        [RED] public CFloat Y { get; set; }
        [RED] public CFloat Z { get; set; }

        public SVector3D(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            X = new CFloat(cr2w, this, nameof(X));
            Y = new CFloat(cr2w, this, nameof(Y));
            Z = new CFloat(cr2w, this, nameof(Z));
        }

        public void Read(BinaryReader file, int compression)
        {
            if (compression == 0)
            {
                X.val = file.ReadSingle();
                Y.val = file.ReadSingle();
                Z.val = file.ReadSingle();
            }
            else if (compression == 1) //24 bit single
            {
                var bitsx = ReadFloat24(file);
                var bitsy = ReadFloat24(file);
                var bitsz = ReadFloat24(file);
                X.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsx), 0);
                Y.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsy), 0);
                Z.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsz), 0);
            }
            else if (compression == 2)
            {
                var bitsx = file.ReadUInt16() << 16;
                var bitsy = file.ReadUInt16() << 16;
                var bitsz = file.ReadUInt16() << 16;
                X.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsx), 0);
                Y.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsy), 0);
                Z.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsz), 0);
            }
        }

        private uint ReadFloat24(BinaryReader file)
        {
            var pad = 0;
            var b1 = file.ReadByte();
            var b2 = file.ReadByte();
            var b3 = file.ReadByte();
            return
                ((uint)b3 << 24) |((uint)b2 << 16) | ((uint)b1 << 8) |((uint)pad);
        }

        public override void Read(BinaryReader file, uint size)
        {
            X.Read(file, size);
            Y.Read(file, size);
            Z.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            X.Write(file);
            Y.Write(file);
            Z.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            if (val is SVector3D v)
            {
                this.X = v.X;
                this.Y = v.Y;
                this.Z = v.Z;
            }

            return this;
        }

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SVector3D(cr2w, parent, name);
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "V3[{0:0.00}, {1:0.00}, {2:0.00}]", X.val, Y.val, Z.val);
        }
    }
}
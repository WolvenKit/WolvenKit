using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class EngineTransform : CVariable
    {
        public byte flags;
        public string type;

        [Ordinal(1)] [RED] public CFloat Pitch { get; set; }
        [Ordinal(2)] [RED] public CFloat Yaw { get; set; }
        [Ordinal(3)] [RED] public CFloat Roll { get; set; }
        [Ordinal(4)] [RED] public CFloat Scale_x { get; set; }
        [Ordinal(5)] [RED] public CFloat Scale_y { get; set; }
        [Ordinal(6)] [RED] public CFloat Scale_z { get; set; }
        [Ordinal(7)] [RED] public CFloat X { get; set; }
        [Ordinal(8)] [RED] public CFloat Y { get; set; }
        [Ordinal(9)] [RED] public CFloat Z { get; set; }

        public EngineTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            X = new CFloat(cr2w, this, nameof(X));
            Y = new CFloat(cr2w, this, nameof(Y));
            Z = new CFloat(cr2w, this, nameof(Z));
            Pitch = new CFloat(cr2w, this, nameof(Pitch));
            Yaw = new CFloat(cr2w, this, nameof(Yaw));
            Roll = new CFloat(cr2w, this, nameof(Roll));
            Scale_x = new CFloat(cr2w, this, nameof(Scale_x));
            Scale_y = new CFloat(cr2w, this, nameof(Scale_y));
            Scale_z = new CFloat(cr2w, this, nameof(Scale_z));
        }

        public override void Read(BinaryReader file, uint size)
        {
            flags = file.ReadByte();

            if ((flags & 1) == 1)
            {
                X.Read(file, 4);
                Y.Read(file, 4);
                Z.Read(file, 4);
            }


            if ((flags & 2) == 2)
            {
                Pitch.Read(file, 4);
                Yaw.Read(file, 4);
                Roll.Read(file, 4);
            }

            if ((flags & 4) == 4)
            {
                Scale_x.Read(file, 4);
                Scale_y.Read(file, 4);
                Scale_z.Read(file, 4);
            }
        }

        public override void Write(BinaryWriter file)
        {
            flags = 0;
            if (X.val != 0 || Y.val != 0 || Z.val != 0)
                flags |= 1;
            if (Pitch.val != 0 || Yaw.val != 0 || Roll.val != 0)
                flags |= 2;
            if (Scale_x.val != 0 || Scale_y.val != 0 || Scale_z.val != 0)
                flags |= 4;

            file.Write(flags);

            if ((flags & 1) == 1)
            {
                X.Write(file);
                Y.Write(file);
                Z.Write(file);
            }


            if ((flags & 2) == 2)
            {
                Pitch.Write(file);
                Yaw.Write(file);
                Roll.Write(file);
            }

            if ((flags & 4) == 4)
            {
                Scale_x.Write(file);
                Scale_y.Write(file);
                Scale_z.Write(file);
            }
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EngineTransform(cr2w, parent, name);
    }
}
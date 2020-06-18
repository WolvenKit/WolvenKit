using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class EngineQsTransform : CVariable
    {
        public byte flags;
        public string type;

        [RED] public CFloat Pitch { get; set; }
        [RED] public CFloat Yaw { get; set; }
        [RED] public CFloat Roll { get; set; }
        [RED] public CFloat W { get; set; }
        [RED] public CFloat Scale_x { get; set; }
        [RED] public CFloat Scale_y { get; set; }
        [RED] public CFloat Scale_z { get; set; }
        [RED] public CFloat X { get; set; }
        [RED] public CFloat Y { get; set; }
        [RED] public CFloat Z { get; set; }

        public EngineQsTransform(CR2WFile cr2w)
            : base(cr2w)
        {
            X = new CFloat(null);
            Y = new CFloat(null);
            Z = new CFloat(null);
            Pitch = new CFloat(null);
            Yaw = new CFloat(null);
            Roll = new CFloat(null);
            W = new CFloat(null);
            Scale_x = new CFloat(null);
            Scale_y = new CFloat(null);
            Scale_z = new CFloat(null);

            W.val = 1;
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
                W.Read(file, 4);
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
            if (Pitch.val != 0 || Yaw.val != 0 || Roll.val != 0 || W.val != 1)
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
                W.Write(file);
            }

            if ((flags & 4) == 4)
            {
                Scale_x.Write(file);
                Scale_y.Write(file);
                Scale_z.Write(file);
            }
        }

        public override CVariable Create(CR2WFile cr2w) => new EngineQsTransform(cr2w);
    }
}
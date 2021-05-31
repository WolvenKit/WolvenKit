using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta()]
    public class CGUID : CVariable, IREDPrimitive
    {
        public byte[] guid;

        public CGUID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            guid = new byte[16];
        }

        [DataMember]
        public string GuidString
        {
            get => ToString();
            set
            {
                Guid g;
                if (Guid.TryParse(value, out g))
                {
                    guid = g.ToByteArray();
                }
            }
        }



        public override void Read(BinaryReader file, uint size) => guid = file.ReadBytes(16);

        public override void Write(BinaryWriter file) => file.Write(guid);

        public override CVariable SetValue(object val)
        {
            switch (val)
            {
                case byte[] o:
                    guid = o;
                    break;
                case CGUID cvar:
                    this.guid = cvar.guid;
                    break;
            }

            return this;
        }

        public object GetValue() => guid;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CGUID) base.Copy(context);
            var.guid = guid;
            return var;
        }

        public override string ToString()
        {
            if (guid != null && guid.Length > 0)
                return new Guid(guid).ToString();
            else
            {
                guid = new byte[16];
                return ToString();
            }
        }
    }
}

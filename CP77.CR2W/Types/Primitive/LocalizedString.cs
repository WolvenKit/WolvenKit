using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class LocalizedString : CVariable
    {
        public LocalizedString(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            if (cr2w != null)
            {
                cr2w.LocalizedStrings.Add(this);
            }
        }

        public uint val { get; set; }


        [DataMember]
        public string Text
        {
            get
            {
                var text = cr2w.GetLocalizedString(val);
                if (text != null)
                    return text;
                return val.ToString();
            }
            private set { }     //vl: dummy setter for serialization; in xml it's always number bc LocalizedSource is not avail
        }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadUInt32();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is uint)
            {
                this.val = (uint)val;
            }
            else if (val is int)
            {
                this.val = (uint)(int)val;
            }
            else if (val is LocalizedString cvar)
            {
                this.val = cvar.val;
            }

            return this;
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (LocalizedString) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
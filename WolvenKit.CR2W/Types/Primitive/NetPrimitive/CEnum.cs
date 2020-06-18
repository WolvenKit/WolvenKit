using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta()]
    public class CEnum : CName
    {
        public Enum Enum { get; set; }

        public override string Type => Enum.GetType().Name;

        public CEnum(CR2WFile cr2w) : base(cr2w) { }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            //handle EnumValues with Spaces in them. facepalm
            string finalvalue = base.Value.Replace(" ", string.Empty);

            try
            {
                var e = (Enum)Enum.Parse(Enum.GetType(), finalvalue);
            }
            catch (Exception)
            {
                Debug.WriteLine($"{base.Value} not found in {Enum.GetType().Name}");
                throw;
            }


            Enum = (Enum)Enum.Parse(Enum.GetType(), finalvalue);
        }

        public override void Write(BinaryWriter file) => base.Write(file);

        public override Control GetEditor() =>  base.GetEditor();    
    }
}
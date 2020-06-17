using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types.Utils
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract(Namespace = "")]
    public class SEntityBufferType2 : CVariable
    {
        public CName componentName { get; set; }
        public CUInt32 sizeofdata { get; set; }
        public CBufferUInt32<CVariableWrapper> variables { get; set; }


        public SEntityBufferType2(CR2WFile cr2w) : base(cr2w)
        {
            componentName = new CName(cr2w)
            {
                Name = "Name",
            };
            sizeofdata = new CUInt32(cr2w)
            {
                Name = "Size",
            };
            variables = new CBufferUInt32<CVariableWrapper>(cr2w, _ => new CVariableWrapper(_));

        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SEntityBufferType2(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            sizeofdata.Read(file, 4);
            componentName.Read(file, 2);
            variables.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {

            sizeofdata.val =  4; // 4 for the uint32 varsize
            byte[] buffer;

            // use a temporary stream to write the variables and get the overall length of the component
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                componentName.Write(bw);
                variables.Write(bw);

                sizeofdata.val += (UInt32)ms.Length;
                buffer = ms.ToArray();
            }

            sizeofdata.Write(file);
            file.Write(buffer);
        }

        public override string ToString()
        {
            return componentName.Value;
        }

    }
}

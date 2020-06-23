using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    /// <summary>
    /// 
    /// </summary>
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SEntityBufferType2 : CVariable
    {
        [RED] public CName componentName { get; set; }
        [RED] public CUInt32 sizeofdata { get; set; }
        [RED] public CBufferUInt32<CVariantSizeTypeName> variables { get; set; }


        public SEntityBufferType2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            componentName = new CName(cr2w, this, nameof(componentName));
            sizeofdata = new CUInt32(cr2w, this, nameof(sizeofdata));
            variables = new CBufferUInt32<CVariantSizeTypeName>(cr2w, this, nameof(variables));

        }

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SEntityBufferType2(cr2w, parent, name);
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

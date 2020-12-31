using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CCompressedBuffer<T> : CBufferBase<T> where T : CVariable
    {

        public CCompressedBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCompressedBuffer<T>(cr2w, parent, name);

        public new void Read(BinaryReader file, uint size, int count)
        {
            

            base.Read(file, size, count);

            
        }

        /// <summary>
        /// This should not be called for CCompressedBuffers. Call Read(BinaryReader file, uint size, int count) instead.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="size"></param>
        public override void Read(BinaryReader file, uint size)
        {
            throw new NotImplementedException();
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
        }

    }
}
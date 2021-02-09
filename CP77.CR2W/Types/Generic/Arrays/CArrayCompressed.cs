using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
    [REDMeta()]
    public class CArrayCompressed<T> : CArrayBase<T> where T : CVariable
    {
        public CArrayCompressed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Elementtype = REDReflection.GetREDTypeString(typeof(T));
        }

        public new void Read(BinaryReader file, uint size, int count) => base.Read(file, size, count);

        /// <summary>
        /// This should not be called. Call Read(BinaryReader file, uint size, int count) instead.
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
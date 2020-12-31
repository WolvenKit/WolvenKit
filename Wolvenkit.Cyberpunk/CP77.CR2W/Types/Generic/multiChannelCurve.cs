using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta]
    public class multiChannelCurve<T> : CVariable where T : CVariable
    {
       

        public multiChannelCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        #region Properties


        #endregion

        #region Methods


        /// <summary>
        /// Reads an int from the stream and stores a reference to a chunk.
        /// A value of 0 means a null reference, all other chunk indeces are shifted by 1.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="size"></param>
        public override void Read(BinaryReader file, uint size)
        {
            throw new NotImplementedException();
        }

        private void SetValueInternal(int val)
        {
            
        }

        public override void Write(BinaryWriter file)
        {
            
        }

        public override CVariable SetValue(object val)
        {
            throw new NotImplementedException();
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            throw new NotImplementedException();
        }


        public override string REDLeanValue()
        {
            throw new NotImplementedException();
        }


        #endregion
    }


}

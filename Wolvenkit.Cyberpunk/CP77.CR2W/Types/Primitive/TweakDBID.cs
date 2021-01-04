using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
    [REDMeta()]
    public class TweakDBID : CVariable, IREDPrimitive
    {
        

        public TweakDBID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        #region Properties

        #endregion


        #region Methods
        public override void Read(BinaryReader file, uint size)
        {
        }
        
        public override void Write(BinaryWriter file)
        {
            
        }

        
        #endregion

    }
}
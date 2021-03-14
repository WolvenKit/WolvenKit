using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED3.CR2W.Types
{
    

    public interface IPtrAccessor : IChunkPtrAccessor
    {

    }

   

    public interface ISoftAccessor
    {
        string DepotPath { get; set; }
        string ClassName { get; set; }
        ushort Flags { get; set; }

        string REDName { get; }
        string REDType { get; }
    }

    

    
}

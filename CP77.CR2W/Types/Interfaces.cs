using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model.Cr2w;

namespace CP77.CR2W.Types
{
    

    
   

    public interface ISoftAccessor
    {
        string DepotPath { get; set; }
        //string ClassName { get; set; }
        EImportFlags Flags { get; set; }

        string REDName { get; }
        string REDType { get; }
    }

  
    

    public interface ICurveDataAccessor
    {
        string Elementtype { get; set; }
    }

    public interface IDataBufferAccessor
    {

    }
}

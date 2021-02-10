using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Model.Cr2w
{
    public interface ICR2WCopyAction
    {
        //public IWolvenkitFile SourceFile { get; set; }
        //public IWolvenkitFile DestinationFile { get; set; }
        public IEditableVariable Parent { get; set; }

        public ICR2WExport TryLookupReference(ICR2WExport oldExportWrapper, IEditableVariable targetVariable = null);
    }
}

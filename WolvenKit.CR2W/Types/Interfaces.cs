using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.CR2W.Types
{
    public interface IChunkPtrAccessor : IEditableVariable
    {
        CR2WExportWrapper Reference { get; set; }
        string ReferenceType { get; }
    }

    public interface IPtrAccessor : IChunkPtrAccessor
    {

    }

    public interface IHandleAccessor : IChunkPtrAccessor
    {
        bool ChunkHandle { get; set; }
        string DepotPath { get; set; }
        string ClassName { get; set; }
        ushort Flags { get; set; }
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

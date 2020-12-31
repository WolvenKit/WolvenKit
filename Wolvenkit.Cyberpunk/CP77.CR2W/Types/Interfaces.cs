using System;
using System.Collections;
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

        void ChangeHandleType();
    }

    public interface ISoftAccessor
    {
        string DepotPath { get; set; }
        string ClassName { get; set; }
        ushort Flags { get; set; }

        string REDName { get; }
        string REDType { get; }
    }

    public interface IVariantAccessor
    {
        CVariable Variant { get; set; }
    }

    public interface IBufferVariantAccessor : IVariantAccessor
    {
    }

    public interface IREDPrimitive
    {

    }

    public interface IArrayAccessor : IEditableVariable, IList
    {
        //List<int> Flags { get; set; }

        string Elementtype { get; set; }
        Type InnerType { get; }

        //int Count { get; }


    }

    public interface IArrayAccessor<T> : IArrayAccessor
    {
        List<T> Elements { get; set; }
    }

    public interface IBufferAccessor : IArrayAccessor
    {

    }
}

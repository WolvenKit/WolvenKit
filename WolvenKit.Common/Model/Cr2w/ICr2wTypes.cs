using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using WolvenKit.Common.Services;

namespace WolvenKit.Common.Model.Cr2w
{
    #region cr2w

    public interface ICR2WBuffer
    {
        #region Properties

        public uint Crc32 { get; set; }
        public uint DiskSize { get; set; }
        public uint Flags { get; }
        public uint Index { get; }
        public uint MemSize { get; set; }
        public uint Offset { get; set; }

        #endregion Properties

        #region Methods

        public void ReadData(BinaryReader file);

        public void SetOffset(uint offset);

        public void WriteData(BinaryWriter file);

        #endregion Methods
    }

    public interface ICR2WEmbedded
    {
    }

    public interface ICR2WExport
    {
        #region Properties

        public List<IChunkPtrAccessor> AbReferences { get; }
        public List<IChunkPtrAccessor> AdReferences { get; }
        public List<ICR2WExport> ChildrenChunks { get; }
        public int ChunkIndex { get; }
        public IEditableVariable data { get; }
        public ICR2WExport ParentChunk { get; set; }
        public string REDName { get; }
        public string REDType { get; }
        public IEditableVariable unknownBytes { get; }
        public List<string> UnknownTypes { get; }
        public List<ICR2WExport> VirtualChildrenChunks { get; }
        public ICR2WExport VirtualParentChunk { get; set; }

        #endregion Properties

        #region Methods

        public void CreateDefaultData(IEditableVariable cvar = null);

        public string GetFullChunkTypeDependencyString();

        public void MountChunkVirtually(int virtualparentchunkindex, bool force = false);

        public void MountChunkVirtually(ICR2WExport virtualparentchunk, bool force = false);

        public void ReadData(BinaryReader file);

        public void WriteData(BinaryWriter file);

        #endregion Methods
    }

    #endregion

    #region REDtypes

    #region editor interfaces

    public interface IEditorBindable { }
    public interface IEditorBindable<T> : IEditorBindable
    {
        public T Value { get; set; } // ???
    }

    #endregion

    #region red primitives

    public interface IREDPrimitive : IEditableVariable { }

    public interface IREDIntegerType : IREDPrimitive { }
    public interface IREDStringType : IREDPrimitive { }
    public interface IREDBool : IREDPrimitive, IEditorBindable<bool> { }

    public interface IEnumAccessor : IEditorBindable
    {
        List<string> EnumValueList { get; set; }
        bool IsFlag { get; }

        string GetAttributeVal();
    }

    public interface IEnumAccessor<T> : IEditorBindable<T>, IEnumAccessor where T : Enum
    {
        string EnumToString();
        IEditableVariable SetValue(object val);
        Type GetEnumType();
    }

    #endregion

    public interface IArrayAccessor : IEditableVariable, IList
    {
        #region Properties

        string Elementtype { get; set; }
        List<int> Flags { get; set; }
        Type InnerType { get; }
    }

    public interface IArrayAccessor<T> : IArrayAccessor
    {
        #region Properties

        List<T> Elements { get; set; }

        #endregion Properties
    }

    public interface IBufferAccessor : IArrayAccessor { }

    public interface IVariantAccessor
    {
        IEditableVariable Variant { get; set; }
    }

    public interface IBufferVariantAccessor : IVariantAccessor { }

    public interface IChunkPtrAccessor : IEditableVariable
    {
        ICR2WExport Reference { get; set; }
        string ReferenceType { get; }
    }

    public interface IHandleAccessor : IChunkPtrAccessor
    {
        #region Properties

        bool ChunkHandle { get; set; }
        string ClassName { get; set; }
        string DepotPath { get; set; }
        ushort Flags { get; set; }

        #endregion Properties

        #region Methods

        void ChangeHandleType();

        #endregion Methods
    }

    public interface IREDBool
    {
        #region Properties

        public bool Value { get; set; }

        #endregion Properties
    }

    public interface IREDIntegerType
    {
        #region Properties

        public double Value { get; set; }

        #endregion Properties
    }

    public interface IREDPrimitive
    {
    }

    #endregion

    #endregion REDtypes
}

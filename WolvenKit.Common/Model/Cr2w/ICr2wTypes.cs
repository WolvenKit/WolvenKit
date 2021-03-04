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

    public interface ICR2WImport
    {
        #region Properties

        public ushort ClassName { get; }
        public string ClassNameStr { get; }
        public uint DepotPath { get; }
        public string DepotPathStr { get; }
        public ushort Flags { get; }

        #endregion Properties
    }

    #endregion cr2w

    #region REDtypes

    [Editor(typeof(ICollectionEditor), typeof(IPropertyEditorBase))]
    public interface IArrayAccessor : IEditableVariable, IList
    {
        #region Properties

        string Elementtype { get; set; }
        List<int> Flags { get; set; }
        Type InnerType { get; }

        #endregion Properties

        //int Count { get; }
    }

    public interface IArrayAccessor<T> : IArrayAccessor
    {
        #region Properties

        List<T> Elements { get; set; }

        #endregion Properties
    }

    public interface IBufferAccessor : IArrayAccessor
    {
    }

    public interface IBufferVariantAccessor : IVariantAccessor
    {
    }

    public interface IChunkPtrAccessor : IEditableVariable
    {
        #region Properties

        ICR2WExport Reference { get; set; }
        string ReferenceType { get; }

        #endregion Properties
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

    public interface IVariantAccessor
    {
        #region Properties

        IEditableVariable Variant { get; set; }

        #endregion Properties
    }

    #endregion REDtypes
}

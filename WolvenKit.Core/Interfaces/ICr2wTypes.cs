using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json.Serialization;


namespace WolvenKit.Common.Model.Cr2w
{
    #region cr2w

    public interface ICR2WName
    {
        public string Str { get; }

        public uint hash { get; }
    }

    public interface ICR2WImport
    {
        public uint DepotPath { get; }
        public ushort ClassName { get; }
        public ushort Flags { get; }

        public string DepotPathStr { get; }
        public string ClassNameStr { get; }
    }
    public interface ICR2WBuffer
    {
        public uint Flags { get; }
        public uint Index { get; }
        [JsonIgnore] public uint Offset { get; set; }
        [JsonIgnore] public uint DiskSize { get; set; }
        [JsonIgnore] public uint MemSize { get; set; }
        [JsonIgnore] public uint Crc32 { get; set; }


        public void ReadData(BinaryReader file);
        public void WriteData(BinaryWriter file);
        public void SetOffset(uint offset);
    }
    public interface ICR2WEmbedded
    {

    }
    public interface ICR2WExport
    {
        public string REDType { get; }

        public int ParentChunkIndex { get; }

        public IEditableVariable Data { get; }

        [JsonIgnore] public string REDName { get; }
        [JsonIgnore] public int ChunkIndex { get; }

        [JsonIgnore] public IEditableVariable UnknownBytes { get; }

        [JsonIgnore] public ICR2WExport ParentChunk { get; set; }
        [JsonIgnore] public ICR2WExport VirtualParentChunk { get; set; }
        [JsonIgnore] public List<ICR2WExport> ChildrenChunks { get; }
        [JsonIgnore] public List<ICR2WExport> VirtualChildrenChunks { get; }
        [JsonIgnore] public List<IChunkPtrAccessor> AdReferences { get; }
        [JsonIgnore] public List<IChunkPtrAccessor> AbReferences { get; }
        [JsonIgnore] public List<string> UnknownTypes { get; }



        public void CreateDefaultData(IEditableVariable cvar = null);
        public string GetFullChunkTypeDependencyString();
        public void MountChunkVirtually(int virtualparentchunkindex, bool force = false);
        public void MountChunkVirtually(ICR2WExport virtualparentchunk, bool force = false);

        public void ReadData(BinaryReader file);
        public void WriteData(BinaryWriter file);
    }

    #endregion

    #region REDtypes

    #region editor interfaces

    public interface IEditorBindable
    {

    }
    public interface IEditorBindable<T> : IEditorBindable
    {
        public T Value { get; set; } // ???
    }

    #endregion

    #region red primitives

    public interface IREDPrimitive : IEditableVariable { }

    public interface IREDColor : IEditorBindable<Color> { }

    public interface IREDIntegerType : IREDPrimitive { }
    public interface IREDIntegerType<T> : IREDIntegerType, IEditorBindable<T> { }
    public interface IREDString : IREDPrimitive, IEditorBindable<string> { }
    public interface IREDBool : IREDPrimitive, IEditorBindable<bool> { }

    public interface IEnumAccessor : IEditorBindable, IEditableVariable
    {
        List<string> EnumValueList { get; set; }
        bool IsFlag { get; }

        string GetAttributeVal();
    }
    public interface IEnumAccessor<T> : IEditorBindable<T>, IEnumAccessor where T : Enum
    {
        string EnumToString();

        Type GetEnumType();
    }

    #endregion

    public interface IArrayAccessor : IEditableVariable, IList
    {
        List<int> Flags { get; set; }

        string Elementtype { get; set; }
        Type InnerType { get; }
    }
    public interface IArrayAccessor<T> : IArrayAccessor
    {
        List<T> Elements { get; set; }
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
        bool ChunkHandle { get; set; }
        string DepotPath { get; set; }
        string ClassName { get; set; }
        ushort Flags { get; set; }

        void ChangeHandleType();
        public IEnumerable<ICR2WExport> GetReferenceChunks();
    }

    public interface IRedRef
    {
        string DepotPath { get; set; }
        EImportFlags Flags { get; set; }

        string REDName { get; }
        string REDType { get; }
    }




    public interface ICurveDataAccessor
    {
        string Elementtype { get; }
    }

    public interface IDataBufferAccessor
    {

    }

    public interface ILocalizedString
    {

    }

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

    #endregion

}

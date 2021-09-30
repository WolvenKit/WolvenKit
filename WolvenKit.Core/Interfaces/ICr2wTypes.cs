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
        [JsonIgnore] public List<IREDChunkPtr> AdReferences { get; }
        [JsonIgnore] public List<IREDChunkPtr> AbReferences { get; }
        [JsonIgnore] public List<string> UnknownTypes { get; }



        public void CreateDefaultData(IEditableVariable cvar = null);
        public string GetFullChunkTypeDependencyString();
        public void MountChunkVirtually(int virtualparentchunkindex, bool force = false);
        public void MountChunkVirtually(ICR2WExport virtualparentchunk, bool force = false);

        public void ReadData(BinaryReader file);
        public void WriteData(BinaryWriter file);

        public uint GetOffset();
    }

    #endregion

    #region REDtypes

    #region red primitives

    // UI template not used
    public interface IREDPrimitive : IEditableVariable
    {
        public object GetValue();
    }
    public interface IREDPrimitive<T> : IREDPrimitive
    {
        public T Value { get; set; }
    }

    // UI template TODO
    public interface IREDColor : IREDPrimitive<Color> { }

    // UI template done
    public interface IREDIntegerType : IREDPrimitive { }
    public interface IREDIntegerType<T> : IREDIntegerType, IREDPrimitive<T> { }

    // UI template done
    public interface IREDString : IREDPrimitive<string> { }

    // UI template done
    public interface IREDBool : IREDPrimitive<bool> { }

    // UI template done
    public interface IREDEnum : IREDPrimitive
    {
        List<string> EnumValueList { get; set; }
        bool IsFlag { get; }

        string GetAttributeVal();
    }
    public interface IREDEnum<T> : IREDPrimitive<T>, IREDEnum where T : Enum
    {
        string EnumToString();

        Type GetEnumType();
    }

    #endregion

    #region arrays

    // UI template done
    public interface IREDArray : IEditableVariable, IList
    {
        List<int> Flags { get; set; }

        string Elementtype { get; set; }

        Type InnerType { get; }

        public IEditableVariable GetElementInstance(string varName);

        public bool IsByteArray();

        public byte[] GetBytes();
    }
    public interface IREDArray<T> : IREDArray
    {
        List<T> Elements { get; set; }
    }
    public interface IREDBuffer : IREDArray { }

    #endregion

    // UI template done
    public interface IREDVariant : IEditableVariable
    {
        IEditableVariable Variant { get; set; }
        public void SetVariant(IEditableVariable variant);
    }
    public interface IREDBufferVariant : IREDVariant { }


    // UI template done
    public interface IREDChunkPtr : IREDPrimitive
    {
        public int ChunkIndex { get; }
        void SetReference(ICR2WExport value);
        ICR2WExport GetReference();
        string ReferenceType { get; }
    }


    /// <summary>
    /// RED3
    /// Handles are Int32 that store
    /// if larger than 0 a reference to a chunk inside the cr2w file (aka Soft)
    /// if less than 0 a reference to a string in the imports table (aka Pointer)
    /// </summary>
    public interface IREDHandle : IREDChunkPtr
    {
        bool ChunkHandle { get; set; }
        string DepotPath { get; set; }
        string ClassName { get; set; }
        ushort Flags { get; set; }

        void ChangeHandleType();
        public IEnumerable<ICR2WExport> GetReferenceChunks();
    }

    /// <summary>
    /// RED3+4
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    public interface IREDPtr : IREDChunkPtr
    {

    }

    /// <summary>
    /// RED3
    /// CSofts are Uint16 references to the imports table of a cr2w file
    /// Imports are paths to a file in the tw3 filesystem
    /// and can be set manually by DepotPath and Classname
    /// Imports have flags which are set on write
    /// </summary>
    public interface IREDSoft : IREDPrimitive
    {
        string DepotPath { get; set; }
        string ClassName { get; set; }
        ushort Flags { get; set; }
    }

    // UI template TODO
    public interface IREDRef : IREDPrimitive
    {
        string DepotPath { get; set; }
        EImportFlags Flags { get; set; }
    }




    public interface ICurveDataAccessor : IEditableVariable
    {
        string Elementtype { get; }

        public IEditableVariable GetElementInstance(string varName);

        public IEnumerable<IREDCurvePoint> GetCurvePoints();

        public void SetCurvePoints(IEnumerable<Tuple<double,object>> points);

        public ESegmentsLinkType GetLinkType();

        public void SetLinkType(ESegmentsLinkType type);

        public EInterpolationType GetInterpolationType();

        public void SetInterpolationType(EInterpolationType type);
    }

    public interface IREDCurvePoint : IREDPrimitive
    {
        public float GetTime();
    }

    public interface IMultiChannelCurve : IEditableVariable
    {

    }

    public interface IDataBufferAccessor : IEditableVariable
    {
    }

    public interface ILocalizedString : IEditableVariable
    {
    }







    #endregion

}

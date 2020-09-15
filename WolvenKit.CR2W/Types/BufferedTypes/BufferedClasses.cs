using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{

    // missing in RTTI
    /// <summary>
    /// this class is special \o/
    /// see CVariable.cs.Read
    /// </summary>
    public partial class CClipMapCookedData : ISerializable
    {
        [Ordinal(1000)] [REDBuffer] public CBytes Data { get; set; }

        public CClipMapCookedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Data = new CBytes(cr2w, this, nameof(Data));
        }


        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
        }
    }

    // buffered classes

    public partial class CCameraCompressedPose : CDefaultCompressedPose2
    {
        [Ordinal(1000)] [REDBuffer] public CBytes Bytes1 { get; set; }
        [Ordinal(1001)] [REDBuffer] public CFloat Float1 { get; set; }
        [Ordinal(1002)] [REDBuffer] public CFloat Float2 { get; set; }
        [Ordinal(1003)] [REDBuffer] public CBytes Bytes2 { get; set; }
    }

    public partial class CClipMap : CObject
    {
        [Ordinal(1000)] [REDBuffer] public CArray<CHandle<CTerrainTile>> TerrainTiles { get; set; }
    }

    public partial class CCookedExplorations : CResource
    {
        [Ordinal(1000)] [REDBuffer] public CByteArray Explfile { get; set; }
    }

    public partial class CCurve : CObject
    {
        [Ordinal(1000)] [REDBuffer] public CBufferUInt32<SCurveBufferData> CurveData { get; set; }
    }

    public partial class CAnimPointCloudLookAtParam : ISkeletalAnimationSetEntryParam
    {
        [Ordinal(1000)] [REDBuffer] public CBufferVLQInt32<SAnimPointCloudLookAtParamData> Buffer { get; set; }
    }

    public partial class CAreaComponent : CBoundedComponent
    {
        [Ordinal(1000)] [REDBuffer] public CByteArray2 Bufferdata { get; set; }
    }
    public partial class CBehaviorGraph : CResource
    {
        [Ordinal(1000)] [REDBuffer] public CHandle<CBehaviorVariable> Toplevelnode { get; set; }
        [Ordinal(1001)] [REDBuffer] public CUInt32 Unk2 { get; set; }
        [Ordinal(1002)] [REDBuffer] public CArray<IdHandle> Variables1 { get; set; }
        [Ordinal(1003)] [REDBuffer] public CUInt32 Unk3 { get; set; }
        [Ordinal(1004)] [REDBuffer] public CBufferVLQInt32<CHandle<CBehaviorVariable>> Descriptions { get; set; } //FIXME
        [Ordinal(1005)] [REDBuffer] public CUInt32 Unk4 { get; set; }
        [Ordinal(1006)] [REDBuffer] public CArray<IdHandle> Vectorvariables1 { get; set; }
        [Ordinal(1007)] [REDBuffer] public CUInt32 Unk5 { get; set; }
        [Ordinal(1008)] [REDBuffer] public CArray<IdHandle> Variables2 { get; set; }
        [Ordinal(1009)] [REDBuffer] public CUInt32 Unk6 { get; set; }
        [Ordinal(1010)] [REDBuffer] public CArray<IdHandle> Vectorvariables2 { get; set; }

    }
    public partial class CBehaviorGraphBlendMultipleNode : CBehaviorGraphNode
    {
        [Ordinal(1000)] [REDBuffer] public CBufferVLQInt32<ShBlendMultipleNodeData> Bufferinputvalues { get; set; }

    }
    public partial class CBehaviorGraphContainerNode : CBehaviorGraphNode
    {
        [Ordinal(1000)] [REDBuffer] public CBufferVLQInt32<CHandle<CBehaviorVariable>> Inputnodes { get; set; }
        [Ordinal(1001)] [REDBuffer] public CBufferVLQInt32<CName> Unk1 { get; set; }
        [Ordinal(1002)] [REDBuffer] public CBufferVLQInt32<CName> Unk2 { get; set; }
        //[Ordinal(1003)] [REDBuffer] public CHandle<CBehaviorVariable> Outputnode { get; set; }
    }
    public partial class CBehaviorGraphStateMachineNode : CBehaviorGraphContainerNode
    {
        [Ordinal(1000)] [REDBuffer] public CBufferVLQInt32<CHandle<CBehaviorVariable>> Unk3 { get; set; }
        [Ordinal(1001)] [REDBuffer] public CBufferVLQInt32<CHandle<CBehaviorVariable>> Unk4 { get; set; }
        [Ordinal(1002)] [REDBuffer] public CHandle<CBehaviorVariable> Handle1 { get; set; }
        [Ordinal(1003)] [REDBuffer] public CHandle<CBehaviorVariable> Outputnode { get; set; }
    }

    public partial class CBehaviorGraphStateNode : CBehaviorGraphContainerNode
    {
        [Ordinal(1000)] [REDBuffer] public CHandle<CBehaviorVariable> Outputnode { get; set; }
    }
    public partial class CBehaviorGraphTopLevelNode : CBehaviorGraphContainerNode
    {
        [Ordinal(1000)] [REDBuffer] public CHandle<CBehaviorVariable> Outputnode { get; set; }
    }
    public partial class CBehaviorGraphStageNode : CBehaviorGraphContainerNode
    {
        [Ordinal(1000)] [REDBuffer] public CHandle<CBehaviorVariable> Outputnode { get; set; }
    }

    

    public partial class CEntityTemplate : CResource
    {
        [Ordinal(1000)] [REDBuffer] public CUInt32 Unk1 { get; set; }
    }
    public partial class CEnvProbeComponent : CComponent
    {
        [Ordinal(1000)] [REDBuffer] public CBufferUInt32<SVector4D> Unk1 { get; set; }
    }

    public partial class CEvaluatorFloatCurve : IEvaluatorFloat
    {
        [Ordinal(1000)] [REDBuffer] public CurveInfo CurveInfo { get; set; }
    }
    public partial class CFoliageResource : CResource
    {
        [Ordinal(1000)] [REDBuffer] public CBufferVLQInt32<SFoliageResourceData> Trees { get; set; }
        [Ordinal(1001)] [REDBuffer] public CBufferVLQInt32<SFoliageResourceData> Grasses { get; set; }
    }
    public partial class CGameWorld : CWorld
    {
        [Ordinal(1000)] [REDBuffer] public CHandle<CLayerGroup> Firstlayer { get; set; }
    }

    public partial class CLayerGroup : ISerializable
    {
        [Ordinal(1000)] [REDBuffer] public CHandle<CGameWorld> Worldhandle { get; set; }
        [Ordinal(1001)] [REDBuffer] public CHandle<CLayerGroup> Layergrouphandle { get; set; }
        [Ordinal(1002)] [REDBuffer] public CBufferVLQInt32<CHandle<CLayerGroup>> ChildrenGroups { get; set; }
        [Ordinal(1003)] [REDBuffer] public CBufferVLQInt32<CHandle<CLayerInfo>> ChildrenInfos { get; set; }
    }

    public partial class CMaterialGraph : IMaterialDefinition
    {
        [Ordinal(1000)] [REDBuffer] public CBufferVLQInt32<SMaterialGraphParameter> PixelParameters { get; set; }
        [Ordinal(1001)] [REDBuffer] public CBufferVLQInt32<SMaterialGraphParameter> VertexParameters { get; set; }
        [Ordinal(1002)] [REDBuffer] public CUInt32 Unk1 { get; set; }
    }

    public partial class CMaterialInstance : IMaterial
    {
        [Ordinal(1000)] [REDBuffer] public CArray<CVariantSizeNameType> InstanceParameters { get; set; }
    }

    public partial class CMesh : CMeshTypeResource
    {
        // ATTENTION: don't read and write like a normal VLQ array
        // this one is padded by 4 bytes after each inner list
        [Ordinal(1000)] [REDBuffer] public CBufferVLQInt32<CPaddedBuffer<CUInt16>> ChunkgroupIndeces { get; set; }

        [Ordinal(1001)] [REDBuffer] public CBufferVLQInt32<CName> BoneNames { get; set; }
        [Ordinal(1002)] [REDBuffer] public CBufferVLQInt32<CMatrix4x4> Bonematrices { get; set; }
        [Ordinal(1003)] [REDBuffer] public CBufferVLQInt32<CFloat> Block3 { get; set; }
        [Ordinal(1004)] [REDBuffer] public CBufferVLQInt32<CUInt32> BoneIndecesMappingBoneIndex { get; set; }
    }

    public partial class CNode : CObject
    {
        [Ordinal(1000)] [REDBuffer] public CArray<CHandle<IAttachment>> AttachmentsReference { get; set; }
        [Ordinal(1001)] [REDBuffer] public CArray<CHandle<IAttachment>> AttachmentsChild { get; set; }
    }

    public partial class CParticleEmitter : IParticleModule
    {
        [Ordinal(1000)] [REDBuffer] public SParticleEmitterModuleData ModuleData { get; set; }
    }
    public partial class CPhysicsDestructionResource : CMesh
    {
        [Ordinal(1000)] [REDBuffer] public CArray<SMeshBlock5> Block5 { get; set; }
    }

    public partial class CRagdoll : CResource
    {
        [Ordinal(1000)] [REDBuffer] public CXml Ragdolldata { get; set; }

        public override CVariable SetValue(object val)
        {
            if (val is CXml)
            {
                Ragdolldata = (CXml)val;
            }

            return this;
        }
    }

    /// <summary>
    /// CExtAnimEventsFile are weird, if they are used as resource they get an additional 4 bytes
    /// but if used in w2ls or as chunk they don't
    /// so, uhm... make a stupid check if classname == 1?
    /// </summary>
    public partial class CExtAnimEventsFile : CResource
    {
        [Ordinal(1000)] [REDBuffer(true)] public CUInt32 Unk1 { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            // lazy check if Cvariable is first chunk (= resource)
            if (ParentVar != null || this is CStorySceneDialogset)
                return;
            Unk1 = new CUInt32(cr2w, this, nameof(Unk1)) {IsSerialized = true};
            Unk1.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            if (ParentVar != null || this is CStorySceneDialogset)
                return;
            Unk1.Write(file);
        }
    }
    public partial class CSkeletalAnimationSet : CExtAnimEventsFile
    {
        //[Ordinal(1000)] [REDBuffer] public CUInt32 Unk1 { get; set; }
    }
    public partial class CCutsceneTemplate : CSkeletalAnimationSet
    {
        [Ordinal(1000)] [REDBuffer] public CUInt32 Unk11 { get; set; }
        [Ordinal(1001)] [REDBuffer] public CBufferUInt32<CVariantSizeType> Animevents { get; set; }
    }

    public partial class CSkeletalAnimation: ISerializable
    {
        [Ordinal(1000)] [REDBuffer] public CUInt32 Unk1 { get; set; }
    }

    public partial class CSkeletalAnimationSetEntry : ISerializable
    {
        [Ordinal(1000)] [REDBuffer] public CArray<CVariantSizeType> Entries { get; set; }
    }

    public partial class CStorySceneSection : CStorySceneControlPart
    {
        [Ordinal(1000)] [REDBuffer] public CArray<CVariantSizeType> sceneEventElements { get; set; }
    }

    public partial class CSwarmCellMap : CResource
    {
        [Ordinal(1000)] [REDBuffer()] public CFloat CellSize1 { get; set; }
        [Ordinal(1001)] [REDBuffer()] public CInt32 DataSizeBits1 { get; set; }
        [Ordinal(1002)] [REDBuffer()] public CUInt16 DataSize1 { get; set; }
        [Ordinal(1003)] [REDBuffer(true)] public CBytes Data { get; set; }
        [Ordinal(1004)] [REDBuffer(true)] public CFloat CornerPositionX { get; set; }
        [Ordinal(1005)] [REDBuffer(true)] public CFloat CornerPositionY { get; set; }
        [Ordinal(1006)] [REDBuffer(true)] public CFloat CornerPositionZ { get; set; }
        [Ordinal(1007)] [REDBuffer(true)] public CInt32 DataSizeX { get; set; }
        [Ordinal(1008)] [REDBuffer(true)] public CInt32 DataSizeY { get; set; }
        [Ordinal(1009)] [REDBuffer(true)] public CInt32 DataSizeZ { get; set; }
        [Ordinal(1010)] [REDBuffer(true)] public CInt32 DataSizeBits { get; set; }
        [Ordinal(1011)] [REDBuffer(true)] public CFloat SizeInKbytes { get; set; }

        public CSwarmCellMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Data = new CBytes(cr2w, this, nameof(Data)) {IsSerialized = true};
            CornerPositionX = new CFloat(cr2w, this, nameof(CornerPositionX)) { IsSerialized = true };
            CornerPositionY = new CFloat(cr2w, this, nameof(CornerPositionY)) { IsSerialized = true };
            CornerPositionZ = new CFloat(cr2w, this, nameof(CornerPositionZ)) { IsSerialized = true };
            DataSizeX = new CInt32(cr2w, this, nameof(DataSizeX)) { IsSerialized = true };
            DataSizeY = new CInt32(cr2w, this, nameof(DataSizeY)) { IsSerialized = true };
            DataSizeZ = new CInt32(cr2w, this, nameof(DataSizeZ)) { IsSerialized = true };
            DataSizeBits = new CInt32(cr2w, this, nameof(DataSizeBits)) { IsSerialized = true };
            SizeInKbytes = new CFloat(cr2w, this, nameof(SizeInKbytes)) { IsSerialized = true };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            Data.Read(file, (uint)((file.BaseStream.Length - 32) - file.BaseStream.Position));
            CornerPositionX.Read(file, size);
            CornerPositionY.Read(file, size);
            CornerPositionZ.Read(file, size);
            DataSizeX.Read(file, size);
            DataSizeY.Read(file, size);
            DataSizeZ.Read(file, size);
            DataSizeBits.Read(file, size);
            SizeInKbytes.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Data.Write(file);
            CornerPositionX.Write(file);
            CornerPositionY.Write(file);
            CornerPositionZ.Write(file);
            DataSizeX.Write(file);
            DataSizeY.Write(file);
            DataSizeZ.Write(file);
            DataSizeBits.Write(file);
            SizeInKbytes.Write(file);

        }
    }

    public partial class CSwfResource : CResource
    {
        [Ordinal(1000)] [REDBuffer] public CByteArray SwfResource { get; set; }
        [Ordinal(1001)] [REDBuffer] public CUInt32 Unk1 { get; set; }
    }

    public partial class CUmbraScene : CResource
    {
        [Ordinal(1000)] [REDBuffer] public CUInt32 Unk1 { get; set; }
        [Ordinal(1001)] [REDBuffer] public CFloat Unk2 { get; set; }
        [Ordinal(1002)] [REDBuffer] public CBufferUInt32<SUmbraSceneData> Tiles { get; set; }
    }

    public partial class CWayPointsCollectionsSet : CResource
    {
        [Ordinal(1000)] [REDBuffer] public CBufferUInt32<SWayPointsCollectionsSetData> Waypointcollections { get; set; }
    }
    public partial class CUmbraTile : CResource
    {

        [Ordinal(1000)] [REDBuffer] public CBufferUInt32<SUmbraTileData> Tiles { get; set; }


    }
}
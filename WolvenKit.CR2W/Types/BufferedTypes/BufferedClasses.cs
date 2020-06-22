using System.IO;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{

    // missing in RTTI

    public partial class CClipMapCookedData : ISerializable
    {
        [REDBuffer] public CBytes Data { get; set; }

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
        [REDBuffer] public CBytes Bytes1 { get; set; }
        [REDBuffer] public CFloat Float1 { get; set; }
        [REDBuffer] public CFloat Float2 { get; set; }
        [REDBuffer] public CBytes Bytes2 { get; set; }
    }

    public partial class CClipMap : CObject
    {
        [REDBuffer] public CArray<CHandle<CTerrainTile>> TerrainTiles { get; set; }
    }

    public partial class CCookedExplorations : CResource
    {
        [REDBuffer] public CByteArray Explfile { get; set; }
    }

    public partial class CCurve : CObject
    {
        [REDBuffer] public CBufferUInt32<SCurveData> CurveData { get; set; }
    }

    public partial class CAnimPointCloudLookAtParam : ISkeletalAnimationSetEntryParam
    {
        [REDBuffer] public CBufferVLQ<SAnimPointCloudLookAtParamData> Buffer { get; set; }
    }

    public partial class CAreaComponent : CBoundedComponent
    {
        [REDBuffer] public CByteArray2 Bufferdata { get; set; }
    }
    public partial class CBehaviorGraph : CResource
    {
        [REDBuffer] public CHandle<CBehaviorVariable> Toplevelnode { get; set; }
        [REDBuffer] public CUInt32 Unk2 { get; set; }
        [REDBuffer] public CArray<IdHandle> Variables1 { get; set; }
        [REDBuffer] public CUInt32 Unk3 { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> Descriptions { get; set; } //FIXME
        [REDBuffer] public CUInt32 Unk4 { get; set; }
        [REDBuffer] public CArray<IdHandle> Vectorvariables1 { get; set; }
        [REDBuffer] public CUInt32 Unk5 { get; set; }
        [REDBuffer] public CArray<IdHandle> Variables2 { get; set; }
        [REDBuffer] public CUInt32 Unk6 { get; set; }
        [REDBuffer] public CArray<IdHandle> Vectorvariables2 { get; set; }

    }
    public partial class CBehaviorGraphBlendMultipleNode : CBehaviorGraphNode
    {
        [REDBuffer] public CBufferVLQ<ShBlendMultipleNodeData> Bufferinputvalues { get; set; }

    }
    public partial class CBehaviorGraphContainerNode : CBehaviorGraphNode
    {
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> Inputnodes { get; set; }
        [REDBuffer] public CBufferVLQ<CName> Unk1 { get; set; }
        [REDBuffer] public CBufferVLQ<CName> Unk2 { get; set; }
        [REDBuffer] public CHandle<CBehaviorVariable> Outputnode { get; set; }
    }
    public partial class CBehaviorGraphStateMachineNode : CBehaviorGraphContainerNode
    {
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> _inputnodes { get; set; } //FIXME
        [REDBuffer] public CBufferVLQ<CName> _unk1 { get; set; }
        [REDBuffer] public CBufferVLQ<CName> _unk2 { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> unk3 { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> unk4 { get; set; }
        [REDBuffer] public CHandle<CBehaviorVariable> handle1 { get; set; }
        [REDBuffer] public CHandle<CBehaviorVariable> _outputnode { get; set; }
    }

    public partial class CCutsceneTemplate : CSkeletalAnimationSet
    {
        [REDBuffer] public CUInt32 Unk11 { get; set; }
        [REDBuffer] public CBufferUInt32<CVariantSizeType> Animevents { get; set; }
    }
    public partial class CEntityTemplate : CResource
    {
        [REDBuffer] public CUInt32 unk1 { get; set; }
    }
    public partial class CEnvProbeComponent : CComponent
    {
        [REDBuffer] public CBufferUInt32<Vector> unk1 { get; set; }
    }

    public partial class CEvaluatorFloatCurve : IEvaluatorFloat
    {
        [REDBuffer] public CurveInfo curveInfo { get; set; }
    }
    public partial class CExtAnimEventsFile : CResource
    {
        [REDBuffer] public CUInt32 unk1 { get; set; }
    }
    public partial class CFoliageResource : CResource
    {
        [REDBuffer] public CBufferVLQInt32<SFoliageResourceData> Trees { get; set; }
        [REDBuffer] public CBufferVLQInt32<SFoliageResourceData> Grasses { get; set; }
    }
    public partial class CGameWorld : CWorld
    {
        [REDBuffer] public CHandle<CLayerGroup> Firstlayer { get; set; }
    }

    public partial class CLayerGroup : ISerializable
    {
        [REDBuffer] public CHandle<CGameWorld> Worldhandle { get; set; }
        [REDBuffer] public CHandle<CLayerGroup> Layergrouphandle { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CLayerGroup>> ChildrenGroups { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CLayerGroup>> ChildrenInfos { get; set; }
    }

    public partial class CMaterialGraph : IMaterialDefinition
    {
        [REDBuffer] public CBufferVLQ<SMaterialGraphParameter> PixelParameters { get; set; }
        [REDBuffer] public CBufferVLQ<SMaterialGraphParameter> VertexParameters { get; set; }
        [REDBuffer] public CUInt32 Unk1 { get; set; }
    }

    public partial class CMaterialInstance : IMaterial
    {
        [REDBuffer] public CArray<CVariantSizeNameType> InstanceParameters { get; set; }
    }

    public partial class CMesh : CMeshTypeResource
    {
        // ATTENTION: don't read and write like a normal VLQ array
        // this one is padded by 4 bytes after each inner list
        [REDBuffer] public CBufferVLQ<CPaddedBuffer<CUInt16>> ChunkgroupIndeces { get; set; }

        [REDBuffer] public CBufferVLQ<CName> BoneNames { get; set; }
        [REDBuffer] public CBufferVLQ<CMatrix4x4> Bonematrices { get; set; }
        [REDBuffer] public CBufferVLQ<CFloat> Block3 { get; set; }
        [REDBuffer] public CBufferVLQ<CUInt32> BoneIndecesMappingBoneIndex { get; set; }
    }

    public partial class CNode : CObject
    {
        [REDBuffer] public CArray<CHandle<IAttachment>> AttachmentsReference { get; set; }
        [REDBuffer] public CArray<CHandle<IAttachment>> AttachmentsChild { get; set; }
    }

    public partial class CParticleEmitter : IParticleModule
    {
        [REDBuffer] public SParticleEmitterModuleData ModuleData { get; set; }
    }
    public partial class CPhysicsDestructionResource : CMesh
    {
        [REDBuffer] public CArray<SMeshBlock5> Block5 { get; set; }
    }

    public partial class CRagdoll : CResource
    {
        [REDBuffer] public CXml Ragdolldata { get; set; }

        public override CVariable SetValue(object val)
        {
            if (val is CXml)
            {
                Ragdolldata = (CXml)val;
            }

            return this;
        }
    }

    public partial class CSkeletalAnimationSetEntry : ISerializable
    {
        [REDBuffer] public CArray<CVariantSizeType> Entries { get; set; }
    }

    public partial class CStorySceneSection : CStorySceneControlPart
    {
        [REDBuffer] public CArray<CVariantSizeType> sceneEventElements { get; set; }
    }

    public partial class CSwarmCellMap : CResource
    {
        [REDBuffer()] public CFloat CellSize1 { get; set; }
        [REDBuffer()] public CInt32 DataSizeBits1 { get; set; }
        [REDBuffer()] public CUInt16 DataSize1 { get; set; }
        [REDBuffer(true)] public CBytes Data { get; set; }
        [REDBuffer(true)] public CFloat CornerPositionX { get; set; }
        [REDBuffer(true)] public CFloat CornerPositionY { get; set; }
        [REDBuffer(true)] public CFloat CornerPositionZ { get; set; }
        [REDBuffer(true)] public CInt32 DataSizeX { get; set; }
        [REDBuffer(true)] public CInt32 DataSizeY { get; set; }
        [REDBuffer(true)] public CInt32 DataSizeZ { get; set; }
        [REDBuffer(true)] public CInt32 DataSizeBits { get; set; }
        [REDBuffer(true)] public CFloat SizeInKbytes { get; set; }

        public CSwarmCellMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Data = new CBytes(cr2w, this, nameof(Data));
            CornerPositionX = new CFloat(cr2w, this, nameof(CornerPositionX));
            CornerPositionY = new CFloat(cr2w, this, nameof(CornerPositionY));
            CornerPositionZ = new CFloat(cr2w, this, nameof(CornerPositionZ));
            DataSizeX = new CInt32(cr2w, this, nameof(DataSizeX));
            DataSizeY = new CInt32(cr2w, this, nameof(DataSizeY));
            DataSizeZ = new CInt32(cr2w, this, nameof(DataSizeZ));
            DataSizeBits = new CInt32(cr2w, this, nameof(DataSizeBits));
            SizeInKbytes = new CFloat(cr2w, this, nameof(SizeInKbytes));
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
        [REDBuffer] public CByteArray SwfResource { get; set; }
        [REDBuffer] public CUInt32 Unk1 { get; set; }
    }

    public partial class CUmbraScene : CResource
    {
        [REDBuffer] public CUInt32 Unk1 { get; set; }
        [REDBuffer] public CFloat Unk2 { get; set; }
        [REDBuffer] public CBufferUInt32<SUmbraSceneData> Tiles { get; set; }
    }

    public partial class CWayPointsCollectionsSet : CResource
    {
        [REDBuffer] public CBufferUInt32<SWayPointsCollectionsSetData> Waypointcollections { get; set; }
    }
    public partial class CUmbraTile : CResource
    {

        //public CBufferUInt32<CHandle<>> tiles;


    }
}
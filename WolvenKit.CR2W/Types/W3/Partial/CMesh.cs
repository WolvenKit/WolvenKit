using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CMesh : CMeshTypeResource
	{
		[RED("collisionMesh")] 		public CHandle<CCollisionMesh> CollisionMesh { get; set;}

		[RED("useExtraStreams")] 		public CBool UseExtraStreams { get; set;}

		[RED("generalizedMeshRadius")] 		public CFloat GeneralizedMeshRadius { get; set;}

		[RED("mergeInGlobalShadowMesh")] 		public CBool MergeInGlobalShadowMesh { get; set;}

		[RED("isOccluder")] 		public CBool IsOccluder { get; set;}

		[RED("smallestHoleOverride")] 		public CFloat SmallestHoleOverride { get; set;}

		[RED("chunks", 2,0)] 		public CArray<SMeshChunkPacked> Chunks { get; set;}

		[RED("rawVertices")] 		public DeferredDataBuffer RawVertices { get; set;}

		[RED("rawIndices")] 		public DeferredDataBuffer RawIndices { get; set;}

		[RED("isStatic")] 		public CBool IsStatic { get; set;}

		[RED("entityProxy")] 		public CBool EntityProxy { get; set;}

		[RED("cookedData")] 		public SMeshCookedData CookedData { get; set;}

		[RED("soundInfo")] 		public CPtr<SMeshSoundInfo> SoundInfo { get; set;}

		[RED("internalVersion")] 		public CUInt8 InternalVersion { get; set;}

		[RED("chunksBuffer")] 		public DeferredDataBuffer ChunksBuffer { get; set;}

		public CMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMesh(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
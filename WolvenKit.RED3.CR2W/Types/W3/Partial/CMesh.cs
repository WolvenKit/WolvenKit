using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CMesh : CMeshTypeResource
	{
		[Ordinal(1)] [RED("baseResourceFilePath")] 		public CString BaseResourceFilePath { get; set;}

		[Ordinal(2)] [RED("navigationObstacle")] 		public CNavigationObstacle NavigationObstacle { get; set;}

		[Ordinal(3)] [RED("collisionMesh")] 		public CHandle<CCollisionMesh> CollisionMesh { get; set;}

		[Ordinal(4)] [RED("useExtraStreams")] 		public CBool UseExtraStreams { get; set;}

		[Ordinal(5)] [RED("generalizedMeshRadius")] 		public CFloat GeneralizedMeshRadius { get; set;}

		[Ordinal(6)] [RED("mergeInGlobalShadowMesh")] 		public CBool MergeInGlobalShadowMesh { get; set;}

		[Ordinal(7)] [RED("isOccluder")] 		public CBool IsOccluder { get; set;}

		[Ordinal(8)] [RED("smallestHoleOverride")] 		public CFloat SmallestHoleOverride { get; set;}

		[Ordinal(9)] [RED("chunks", 2,0)] 		public CArray<SMeshChunkPacked> Chunks { get; set;}

		[Ordinal(10)] [RED("rawVertices")] 		public DeferredDataBuffer RawVertices { get; set;}

		[Ordinal(11)] [RED("rawIndices")] 		public DeferredDataBuffer RawIndices { get; set;}

		[Ordinal(12)] [RED("isStatic")] 		public CBool IsStatic { get; set;}

		[Ordinal(13)] [RED("entityProxy")] 		public CBool EntityProxy { get; set;}

		[Ordinal(14)] [RED("cookedData")] 		public SMeshCookedData CookedData { get; set;}

		[Ordinal(15)] [RED("soundInfo")] 		public CPtr<SMeshSoundInfo> SoundInfo { get; set;}

		[Ordinal(16)] [RED("internalVersion")] 		public CUInt8 InternalVersion { get; set;}

		[Ordinal(17)] [RED("chunksBuffer")] 		public DeferredDataBuffer ChunksBuffer { get; set;}

		public CMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMesh(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
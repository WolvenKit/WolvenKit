using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMeshChunkPacked : CVariable
	{
		[Ordinal(1)] [RED("vertexType")] 		public CEnum<EMeshVertexType> VertexType { get; set;}

		[Ordinal(2)] [RED("materialID")] 		public CUInt32 MaterialID { get; set;}

		[Ordinal(3)] [RED("numBonesPerVertex")] 		public CUInt8 NumBonesPerVertex { get; set;}

		[Ordinal(4)] [RED("numVertices")] 		public CUInt32 NumVertices { get; set;}

		[Ordinal(5)] [RED("numIndices")] 		public CUInt32 NumIndices { get; set;}

		[Ordinal(6)] [RED("firstVertex")] 		public CUInt32 FirstVertex { get; set;}

		[Ordinal(7)] [RED("firstIndex")] 		public CUInt32 FirstIndex { get; set;}

		[Ordinal(8)] [RED("renderMask")] 		public CEnum<EMeshChunkRenderMask> RenderMask { get; set;}

		[Ordinal(9)] [RED("useForShadowmesh")] 		public CBool UseForShadowmesh { get; set;}

		public SMeshChunkPacked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMeshChunkPacked(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
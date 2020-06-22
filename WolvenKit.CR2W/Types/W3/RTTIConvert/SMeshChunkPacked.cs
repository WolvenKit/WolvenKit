using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMeshChunkPacked : CVariable
	{
		[RED("vertexType")] 		public CEnum<EMeshVertexType> VertexType { get; set;}

		[RED("materialID")] 		public CUInt32 MaterialID { get; set;}

		[RED("numBonesPerVertex")] 		public CUInt8 NumBonesPerVertex { get; set;}

		[RED("numVertices")] 		public CUInt32 NumVertices { get; set;}

		[RED("numIndices")] 		public CUInt32 NumIndices { get; set;}

		[RED("firstVertex")] 		public CUInt32 FirstVertex { get; set;}

		[RED("firstIndex")] 		public CUInt32 FirstIndex { get; set;}

		[RED("renderMask")] 		public EMeshChunkRenderMask RenderMask { get; set;}

		[RED("useForShadowmesh")] 		public CBool UseForShadowmesh { get; set;}

		public SMeshChunkPacked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMeshChunkPacked(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
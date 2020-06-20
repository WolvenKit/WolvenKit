using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMeshCookedData : CVariable
	{
		[RED("collisionInitPositionOffset")] 		public Vector CollisionInitPositionOffset { get; set;}

		[RED("dropOffset")] 		public Vector DropOffset { get; set;}

		[RED("bonePositions", 46,0)] 		public CArray<Vector> BonePositions { get; set;}

		[RED("renderLODs", 46,0)] 		public CArray<CFloat> RenderLODs { get; set;}

		[RED("renderChunks", 46,0)] 		public CByteArray RenderChunks { get; set;}

		[RED("renderBuffer")] 		public DeferredDataBuffer RenderBuffer { get; set;}

		[RED("quantizationScale")] 		public Vector QuantizationScale { get; set;}

		[RED("quantizationOffset")] 		public Vector QuantizationOffset { get; set;}

		[RED("vertexBufferSize")] 		public CUInt32 VertexBufferSize { get; set;}

		[RED("indexBufferSize")] 		public CUInt32 IndexBufferSize { get; set;}

		[RED("indexBufferOffset")] 		public CUInt32 IndexBufferOffset { get; set;}

		public SMeshCookedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMeshCookedData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
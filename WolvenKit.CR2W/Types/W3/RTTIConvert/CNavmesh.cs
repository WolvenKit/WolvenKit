using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CNavmesh : CResource
	{
		[RED("vertexCount")] 		public CUInt16 VertexCount { get; set;}

		[RED("triangleCount")] 		public CUInt16 TriangleCount { get; set;}

		[RED("phantomEdgesCount")] 		public CUInt16 PhantomEdgesCount { get; set;}

		[RED("binariesVersion")] 		public CUInt16 BinariesVersion { get; set;}

		[RED("centralPoint")] 		public Vector CentralPoint { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("bbox")] 		public Box Bbox { get; set;}

		public CNavmesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CNavmesh(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
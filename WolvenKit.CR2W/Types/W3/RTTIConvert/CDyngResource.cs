using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDyngResource : CResource
	{
		[RED("name")] 		public CString Name { get; set;}

		[RED("dyngSkeleton")] 		public CHandle<CSkeleton> DyngSkeleton { get; set;}

		[RED("nodeNames", 2,0)] 		public CArray<CString> NodeNames { get; set;}

		[RED("nodeParents", 2,0)] 		public CArray<CString> NodeParents { get; set;}

		[RED("nodeMasses", 2,0)] 		public CArray<CFloat> NodeMasses { get; set;}

		[RED("nodeStifnesses", 2,0)] 		public CArray<CFloat> NodeStifnesses { get; set;}

		[RED("nodeDistances", 2,0)] 		public CArray<CFloat> NodeDistances { get; set;}

		[RED("nodeTransforms", 2,0)] 		public CArray<CMatrix> NodeTransforms { get; set;}

		[RED("linkTypes", 2,0)] 		public CArray<CInt32> LinkTypes { get; set;}

		[RED("linkLengths", 2,0)] 		public CArray<CFloat> LinkLengths { get; set;}

		[RED("linkAs", 2,0)] 		public CArray<CInt32> LinkAs { get; set;}

		[RED("linkBs", 2,0)] 		public CArray<CInt32> LinkBs { get; set;}

		[RED("triangleAs", 2,0)] 		public CArray<CInt32> TriangleAs { get; set;}

		[RED("triangleBs", 2,0)] 		public CArray<CInt32> TriangleBs { get; set;}

		[RED("triangleCs", 2,0)] 		public CArray<CInt32> TriangleCs { get; set;}

		[RED("collisionParents", 2,0)] 		public CArray<CString> CollisionParents { get; set;}

		[RED("collisionRadiuses", 2,0)] 		public CArray<CFloat> CollisionRadiuses { get; set;}

		[RED("collisionHeights", 2,0)] 		public CArray<CFloat> CollisionHeights { get; set;}

		[RED("collisionTransforms", 2,0)] 		public CArray<CMatrix> CollisionTransforms { get; set;}

		public CDyngResource(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CDyngResource(cr2w);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMergedWorldGeometryShadowData : IMergedWorldGeometryData
	{
		[RED("minExtractMeshRadius")] 		public CFloat MinExtractMeshRadius { get; set;}

		[RED("minMergeMeshRadius")] 		public CFloat MinMergeMeshRadius { get; set;}

		[RED("maxMeshTriangles")] 		public CUInt32 MaxMeshTriangles { get; set;}

		[RED("mergeCascade1")] 		public CBool MergeCascade1 { get; set;}

		[RED("mergeCascade2")] 		public CBool MergeCascade2 { get; set;}

		[RED("mergeCascade3")] 		public CBool MergeCascade3 { get; set;}

		[RED("mergeCascade4")] 		public CBool MergeCascade4 { get; set;}

		[RED("excludeProxies")] 		public CBool ExcludeProxies { get; set;}

		[RED("streamingDistance")] 		public CFloat StreamingDistance { get; set;}

		[RED("useInCascade1")] 		public CBool UseInCascade1 { get; set;}

		[RED("useInCascade2")] 		public CBool UseInCascade2 { get; set;}

		[RED("useInCascade3")] 		public CBool UseInCascade3 { get; set;}

		[RED("useInCascade4")] 		public CBool UseInCascade4 { get; set;}

		[RED("killZ")] 		public CFloat KillZ { get; set;}

		[RED("killAngle")] 		public CFloat KillAngle { get; set;}

		public CMergedWorldGeometryShadowData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMergedWorldGeometryShadowData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
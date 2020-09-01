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
		[Ordinal(0)] [RED("minExtractMeshRadius")] 		public CFloat MinExtractMeshRadius { get; set;}

		[Ordinal(0)] [RED("minMergeMeshRadius")] 		public CFloat MinMergeMeshRadius { get; set;}

		[Ordinal(0)] [RED("maxMeshTriangles")] 		public CUInt32 MaxMeshTriangles { get; set;}

		[Ordinal(0)] [RED("mergeCascade1")] 		public CBool MergeCascade1 { get; set;}

		[Ordinal(0)] [RED("mergeCascade2")] 		public CBool MergeCascade2 { get; set;}

		[Ordinal(0)] [RED("mergeCascade3")] 		public CBool MergeCascade3 { get; set;}

		[Ordinal(0)] [RED("mergeCascade4")] 		public CBool MergeCascade4 { get; set;}

		[Ordinal(0)] [RED("excludeProxies")] 		public CBool ExcludeProxies { get; set;}

		[Ordinal(0)] [RED("streamingDistance")] 		public CFloat StreamingDistance { get; set;}

		[Ordinal(0)] [RED("useInCascade1")] 		public CBool UseInCascade1 { get; set;}

		[Ordinal(0)] [RED("useInCascade2")] 		public CBool UseInCascade2 { get; set;}

		[Ordinal(0)] [RED("useInCascade3")] 		public CBool UseInCascade3 { get; set;}

		[Ordinal(0)] [RED("useInCascade4")] 		public CBool UseInCascade4 { get; set;}

		[Ordinal(0)] [RED("killZ")] 		public CFloat KillZ { get; set;}

		[Ordinal(0)] [RED("killAngle")] 		public CFloat KillAngle { get; set;}

		public CMergedWorldGeometryShadowData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMergedWorldGeometryShadowData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
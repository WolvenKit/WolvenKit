using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMergedWorldGeometryEntity : CEntity
	{
		[RED("sourceDataHash")] 		public CUInt64 SourceDataHash { get; set;}

		[RED("worldBounds")] 		public Box WorldBounds { get; set;}

		[RED("gridCoordinates")] 		public CMergedWorldGeometryGridCoordinates GridCoordinates { get; set;}

		[RED("statsDataSize")] 		public CUInt32 StatsDataSize { get; set;}

		[RED("statsNumTriangles")] 		public CUInt32 StatsNumTriangles { get; set;}

		[RED("statsNumVertices")] 		public CUInt32 StatsNumVertices { get; set;}

		public CMergedWorldGeometryEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMergedWorldGeometryEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
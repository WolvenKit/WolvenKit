using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurLevelOfDetail : CVariable
	{
		[RED("enableLOD")] 		public CBool EnableLOD { get; set;}

		[RED("culling")] 		public SFurCulling Culling { get; set;}

		[RED("distanceLOD")] 		public SFurDistanceLOD DistanceLOD { get; set;}

		[RED("detailLOD")] 		public SFurDetailLOD DetailLOD { get; set;}

		[RED("priority")] 		public CUInt32 Priority { get; set;}

		public SFurLevelOfDetail(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFurLevelOfDetail(cr2w);

	}
}
using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurDistanceLOD : CVariable
	{
		[RED("enableDistanceLOD")] 		public CBool EnableDistanceLOD { get; set;}

		[RED("distanceLODStart")] 		public CFloat DistanceLODStart { get; set;}

		[RED("distanceLODEnd")] 		public CFloat DistanceLODEnd { get; set;}

		[RED("distanceLODFadeStart")] 		public CFloat DistanceLODFadeStart { get; set;}

		[RED("distanceLODWidth")] 		public CFloat DistanceLODWidth { get; set;}

		[RED("distanceLODDensity")] 		public CFloat DistanceLODDensity { get; set;}

		public SFurDistanceLOD(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFurDistanceLOD(cr2w);

	}
}
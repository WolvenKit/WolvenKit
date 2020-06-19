using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurDetailLOD : CVariable
	{
		[RED("enableDetailLOD")] 		public CBool EnableDetailLOD { get; set;}

		[RED("detailLODStart")] 		public CFloat DetailLODStart { get; set;}

		[RED("detailLODEnd")] 		public CFloat DetailLODEnd { get; set;}

		[RED("detailLODWidth")] 		public CFloat DetailLODWidth { get; set;}

		[RED("detailLODDensity")] 		public CFloat DetailLODDensity { get; set;}

		public SFurDetailLOD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurDetailLOD(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
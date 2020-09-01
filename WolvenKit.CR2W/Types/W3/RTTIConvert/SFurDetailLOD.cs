using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurDetailLOD : CVariable
	{
		[Ordinal(0)] [RED("("enableDetailLOD")] 		public CBool EnableDetailLOD { get; set;}

		[Ordinal(0)] [RED("("detailLODStart")] 		public CFloat DetailLODStart { get; set;}

		[Ordinal(0)] [RED("("detailLODEnd")] 		public CFloat DetailLODEnd { get; set;}

		[Ordinal(0)] [RED("("detailLODWidth")] 		public CFloat DetailLODWidth { get; set;}

		[Ordinal(0)] [RED("("detailLODDensity")] 		public CFloat DetailLODDensity { get; set;}

		public SFurDetailLOD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurDetailLOD(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CVegetationBrushEntry : CObject
	{
		[RED("resource")] 		public CHandle<CSRTBaseTree> Resource { get; set;}

		[RED("size")] 		public CFloat Size { get; set;}

		[RED("sizeVar")] 		public CFloat SizeVar { get; set;}

		[RED("radiusScale")] 		public CFloat RadiusScale { get; set;}

		[RED("density")] 		public CFloat Density { get; set;}

		public CVegetationBrushEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CVegetationBrushEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
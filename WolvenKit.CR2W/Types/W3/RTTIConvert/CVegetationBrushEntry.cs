using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CVegetationBrushEntry : CObject
	{
		[Ordinal(1)] [RED("resource")] 		public CHandle<CSRTBaseTree> Resource { get; set;}

		[Ordinal(2)] [RED("size")] 		public CFloat Size { get; set;}

		[Ordinal(3)] [RED("sizeVar")] 		public CFloat SizeVar { get; set;}

		[Ordinal(4)] [RED("radiusScale")] 		public CFloat RadiusScale { get; set;}

		[Ordinal(5)] [RED("density")] 		public CFloat Density { get; set;}

		public CVegetationBrushEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CVegetationBrushEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CApexResource : CMeshTypeResource
	{
		[Ordinal(0)] [RED("apexBinaryAsset", 95,0)] 		public CByteArray ApexBinaryAsset { get; set;}

		[Ordinal(0)] [RED("apexMaterialNames", 2,0)] 		public CArray<CString> ApexMaterialNames { get; set;}

		[Ordinal(0)] [RED("shadowDistance")] 		public CFloat ShadowDistance { get; set;}

		public CApexResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CApexResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
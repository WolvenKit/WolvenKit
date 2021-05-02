using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CApexResource : CMeshTypeResource
	{
		[Ordinal(1)] [RED("apexBinaryAsset", 95,0)] 		public CByteArray ApexBinaryAsset { get; set;}

		[Ordinal(2)] [RED("apexMaterialNames", 2,0)] 		public CArray<CString> ApexMaterialNames { get; set;}

		[Ordinal(3)] [RED("shadowDistance")] 		public CFloat ShadowDistance { get; set;}

		public CApexResource(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockSampler : CMaterialBlock
	{
		[Ordinal(1)] [RED("addressU")] 		public CEnum<ETextureAddressing> AddressU { get; set;}

		[Ordinal(2)] [RED("addressV")] 		public CEnum<ETextureAddressing> AddressV { get; set;}

		[Ordinal(3)] [RED("addressW")] 		public CEnum<ETextureAddressing> AddressW { get; set;}

		[Ordinal(4)] [RED("filterMin")] 		public CEnum<ETextureFilteringMin> FilterMin { get; set;}

		[Ordinal(5)] [RED("filterMag")] 		public CEnum<ETextureFilteringMag> FilterMag { get; set;}

		[Ordinal(6)] [RED("filterMip")] 		public CEnum<ETextureFilteringMip> FilterMip { get; set;}

		[Ordinal(7)] [RED("comparisonFunction")] 		public CEnum<ETextureComparisonFunction> ComparisonFunction { get; set;}

		public CMaterialBlockSampler(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
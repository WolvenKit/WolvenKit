using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockSampler : CMaterialBlock
	{
		[RED("addressU")] 		public ETextureAddressing AddressU { get; set;}

		[RED("addressV")] 		public ETextureAddressing AddressV { get; set;}

		[RED("addressW")] 		public ETextureAddressing AddressW { get; set;}

		[RED("filterMin")] 		public ETextureFilteringMin FilterMin { get; set;}

		[RED("filterMag")] 		public ETextureFilteringMag FilterMag { get; set;}

		[RED("filterMip")] 		public ETextureFilteringMip FilterMip { get; set;}

		[RED("comparisonFunction")] 		public ETextureComparisonFunction ComparisonFunction { get; set;}

		public CMaterialBlockSampler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockSampler(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SamplerStateInfo : CVariable
	{
		[Ordinal(0)]  [RED("addressU")] public CEnum<ETextureAddressing> AddressU { get; set; }
		[Ordinal(1)]  [RED("addressV")] public CEnum<ETextureAddressing> AddressV { get; set; }
		[Ordinal(2)]  [RED("addressW")] public CEnum<ETextureAddressing> AddressW { get; set; }
		[Ordinal(3)]  [RED("comparisonFunc")] public CEnum<ETextureComparisonFunction> ComparisonFunc { get; set; }
		[Ordinal(4)]  [RED("filteringMag")] public CEnum<ETextureFilteringMag> FilteringMag { get; set; }
		[Ordinal(5)]  [RED("filteringMin")] public CEnum<ETextureFilteringMin> FilteringMin { get; set; }
		[Ordinal(6)]  [RED("filteringMip")] public CEnum<ETextureFilteringMip> FilteringMip { get; set; }
		[Ordinal(7)]  [RED("register")] public CUInt8 Register { get; set; }

		public SamplerStateInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasicDistractionDevice : InteractiveDevice
	{
		[Ordinal(93)] [RED("animFeatureDataDistractor")] public CHandle<AnimFeature_DistractionState> AnimFeatureDataDistractor { get; set; }
		[Ordinal(94)] [RED("animFeatureDataNameDistractor")] public CName AnimFeatureDataNameDistractor { get; set; }
		[Ordinal(95)] [RED("distractionComponentSwapNamesToON")] public CArray<CName> DistractionComponentSwapNamesToON { get; set; }
		[Ordinal(96)] [RED("distractionComponentSwapNamesToOFF")] public CArray<CName> DistractionComponentSwapNamesToOFF { get; set; }
		[Ordinal(97)] [RED("distractionComponentON")] public CArray<CHandle<entIPlacedComponent>> DistractionComponentON { get; set; }
		[Ordinal(98)] [RED("cdistractionComponentOFF")] public CArray<CHandle<entIPlacedComponent>> CdistractionComponentOFF { get; set; }

		public BasicDistractionDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

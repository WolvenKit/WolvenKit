using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BasicDistractionDevice : InteractiveDevice
	{
		[Ordinal(0)]  [RED("animFeatureDataDistractor")] public CHandle<AnimFeature_DistractionState> AnimFeatureDataDistractor { get; set; }
		[Ordinal(1)]  [RED("animFeatureDataNameDistractor")] public CName AnimFeatureDataNameDistractor { get; set; }
		[Ordinal(2)]  [RED("cdistractionComponentOFF")] public CArray<CHandle<entIPlacedComponent>> CdistractionComponentOFF { get; set; }
		[Ordinal(3)]  [RED("distractionComponentON")] public CArray<CHandle<entIPlacedComponent>> DistractionComponentON { get; set; }
		[Ordinal(4)]  [RED("distractionComponentSwapNamesToOFF")] public CArray<CName> DistractionComponentSwapNamesToOFF { get; set; }
		[Ordinal(5)]  [RED("distractionComponentSwapNamesToON")] public CArray<CName> DistractionComponentSwapNamesToON { get; set; }

		public BasicDistractionDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

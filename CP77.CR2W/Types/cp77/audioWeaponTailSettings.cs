using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioWeaponTailSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("interiorDefault")] public CName InteriorDefault { get; set; }
		[Ordinal(2)] [RED("interiorWide")] public CName InteriorWide { get; set; }
		[Ordinal(3)] [RED("exteriorWide")] public CName ExteriorWide { get; set; }
		[Ordinal(4)] [RED("exteriorUrbanNarrow")] public CName ExteriorUrbanNarrow { get; set; }
		[Ordinal(5)] [RED("exteriorUrbanStreet")] public CName ExteriorUrbanStreet { get; set; }
		[Ordinal(6)] [RED("exteriorUrbanStreetWide")] public CName ExteriorUrbanStreetWide { get; set; }
		[Ordinal(7)] [RED("exteriorUrbanOpen")] public CName ExteriorUrbanOpen { get; set; }
		[Ordinal(8)] [RED("exteriorUrbanEnclosed")] public CName ExteriorUrbanEnclosed { get; set; }
		[Ordinal(9)] [RED("exteriorBadlandsOpen")] public CName ExteriorBadlandsOpen { get; set; }
		[Ordinal(10)] [RED("exteriorBadlandsCanyon")] public CName ExteriorBadlandsCanyon { get; set; }

		public audioWeaponTailSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

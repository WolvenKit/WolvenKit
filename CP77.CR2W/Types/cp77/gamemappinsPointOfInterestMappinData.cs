using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamemappinsPointOfInterestMappinData : gamemappinsIMappinData
	{
		[Ordinal(0)]  [RED("typedVariant")] public CHandle<gamemappinsIPointOfInterestVariant> TypedVariant { get; set; }
		[Ordinal(1)]  [RED("active")] public CBool Active { get; set; }

		public gamemappinsPointOfInterestMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

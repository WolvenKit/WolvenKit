using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTrafficDataPackage : CVariable
	{
		[Ordinal(0)] [RED("crowdEntryOwners")] public gameCrowdCommunityEntryOwnersData CrowdEntryOwners { get; set; }
		[Ordinal(1)] [RED("crowdTrafficData")] public gameCompiledCrowdTrafficData CrowdTrafficData { get; set; }

		public gameCrowdTrafficDataPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

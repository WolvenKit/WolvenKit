using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCrowdCommunityEntryOwnerInfo : CVariable
	{
		[Ordinal(0)]  [RED("communityId")] public gameCommunityID CommunityId { get; set; }
		[Ordinal(1)]  [RED("crowdEntryNames")] public CArray<CName> CrowdEntryNames { get; set; }

		public gameCrowdCommunityEntryOwnerInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

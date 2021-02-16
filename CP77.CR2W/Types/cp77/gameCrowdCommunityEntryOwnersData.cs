using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCrowdCommunityEntryOwnersData : CVariable
	{
		[Ordinal(0)] [RED("communityOwnersData")] public CArray<gameCrowdCommunityEntryOwnerInfo> CommunityOwnersData { get; set; }

		public gameCrowdCommunityEntryOwnersData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

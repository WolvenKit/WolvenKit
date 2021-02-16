using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCommunityRegistryItem : CVariable
	{
		[Ordinal(0)] [RED("entriesInitialState")] public CArray<worldCommunityEntryInitialState> EntriesInitialState { get; set; }
		[Ordinal(1)] [RED("template")] public CHandle<communityCommunityTemplateData> Template { get; set; }
		[Ordinal(2)] [RED("communityId")] public gameCommunityID CommunityId { get; set; }
		[Ordinal(3)] [RED("communityIsBackground")] public CBool CommunityIsBackground { get; set; }

		public worldCommunityRegistryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

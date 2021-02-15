using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class communityArea : ISerializable
	{
		[Ordinal(0)] [RED("entriesData")] public CArray<communityCommunityEntrySpotsData> EntriesData { get; set; }

		public communityArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

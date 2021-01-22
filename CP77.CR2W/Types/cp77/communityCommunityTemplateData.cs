using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class communityCommunityTemplateData : ISerializable
	{
		[Ordinal(0)]  [RED("crowdEntries")] public CArray<gameCrowdTemplateEntry> CrowdEntries { get; set; }
		[Ordinal(1)]  [RED("entries")] public CArray<CHandle<communitySpawnEntry>> Entries { get; set; }
		[Ordinal(2)]  [RED("spawnSetReference")] public CName SpawnSetReference { get; set; }

		public communityCommunityTemplateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

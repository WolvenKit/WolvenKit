using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameCommunitySpawnSetNameToIDEntry : CVariable
	{
		[Ordinal(0)]  [RED("communityId")] public gameCommunityID CommunityId { get; set; }
		[Ordinal(1)]  [RED("nameReference")] public CName NameReference { get; set; }

		public gameCommunitySpawnSetNameToIDEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCommunitySpawnSetNameToIDEntry : CVariable
	{
		[Ordinal(0)] [RED("communityId")] public gameCommunityID CommunityId { get; set; }
		[Ordinal(1)] [RED("nameReference")] public CName NameReference { get; set; }

		public gameCommunitySpawnSetNameToIDEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

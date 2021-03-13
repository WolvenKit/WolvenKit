using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnerReady_ConditionType : questISpawnerConditionType
	{
		[Ordinal(0)] [RED("spawnerReference")] public NodeRef SpawnerReference { get; set; }
		[Ordinal(1)] [RED("communityEntryNames")] public CArray<CName> CommunityEntryNames { get; set; }

		public questSpawnerReady_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

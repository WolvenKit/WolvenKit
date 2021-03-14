using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsQuestMappinManagerReplicatedState : CVariable
	{
		[Ordinal(0)] [RED("dynamicQuestMappinRepInfo")] public CArray<gamemappinsDynamicQuestMappinRepInfo> DynamicQuestMappinRepInfo { get; set; }

		public gamemappinsQuestMappinManagerReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

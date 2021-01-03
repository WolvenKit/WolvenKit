using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamemappinsQuestMappinManagerReplicatedState : CVariable
	{
		[Ordinal(0)]  [RED("dynamicQuestMappinRepInfo")] public CArray<gamemappinsDynamicQuestMappinRepInfo> DynamicQuestMappinRepInfo { get; set; }

		public gamemappinsQuestMappinManagerReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

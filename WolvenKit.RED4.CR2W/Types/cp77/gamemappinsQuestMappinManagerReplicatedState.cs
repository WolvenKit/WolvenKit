using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsQuestMappinManagerReplicatedState : CVariable
	{
		private CArray<gamemappinsDynamicQuestMappinRepInfo> _dynamicQuestMappinRepInfo;

		[Ordinal(0)] 
		[RED("dynamicQuestMappinRepInfo")] 
		public CArray<gamemappinsDynamicQuestMappinRepInfo> DynamicQuestMappinRepInfo
		{
			get => GetProperty(ref _dynamicQuestMappinRepInfo);
			set => SetProperty(ref _dynamicQuestMappinRepInfo, value);
		}

		public gamemappinsQuestMappinManagerReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemappinsQuestMappinManagerReplicatedState : RedBaseClass
	{
		private CArray<gamemappinsDynamicQuestMappinRepInfo> _dynamicQuestMappinRepInfo;

		[Ordinal(0)] 
		[RED("dynamicQuestMappinRepInfo")] 
		public CArray<gamemappinsDynamicQuestMappinRepInfo> DynamicQuestMappinRepInfo
		{
			get => GetProperty(ref _dynamicQuestMappinRepInfo);
			set => SetProperty(ref _dynamicQuestMappinRepInfo, value);
		}
	}
}

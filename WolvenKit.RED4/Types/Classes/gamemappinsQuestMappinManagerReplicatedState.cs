using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsQuestMappinManagerReplicatedState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("dynamicQuestMappinRepInfo")] 
		public CArray<gamemappinsDynamicQuestMappinRepInfo> DynamicQuestMappinRepInfo
		{
			get => GetPropertyValue<CArray<gamemappinsDynamicQuestMappinRepInfo>>();
			set => SetPropertyValue<CArray<gamemappinsDynamicQuestMappinRepInfo>>(value);
		}

		public gamemappinsQuestMappinManagerReplicatedState()
		{
			DynamicQuestMappinRepInfo = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

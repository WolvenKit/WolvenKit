using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsDynamicQuestMappinRepInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("journalPathHash")] 
		public CUInt32 JournalPathHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public gamemappinsDynamicQuestMappinRepInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

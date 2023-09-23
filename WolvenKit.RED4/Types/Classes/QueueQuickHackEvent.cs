using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QueueQuickHackEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<GameplayRoleMappinData> Data
		{
			get => GetPropertyValue<CHandle<GameplayRoleMappinData>>();
			set => SetPropertyValue<CHandle<GameplayRoleMappinData>>(value);
		}

		public QueueQuickHackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

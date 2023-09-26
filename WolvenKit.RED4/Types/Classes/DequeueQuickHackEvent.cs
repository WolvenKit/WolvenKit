using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DequeueQuickHackEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		public DequeueQuickHackEvent()
		{
			MappinID = new gameNewMappinID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

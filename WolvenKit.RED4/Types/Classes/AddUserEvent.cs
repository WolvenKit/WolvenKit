using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddUserEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("userEntry")] 
		public SecuritySystemClearanceEntry UserEntry
		{
			get => GetPropertyValue<SecuritySystemClearanceEntry>();
			set => SetPropertyValue<SecuritySystemClearanceEntry>(value);
		}

		public AddUserEvent()
		{
			UserEntry = new SecuritySystemClearanceEntry { User = new entEntityID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

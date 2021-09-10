using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			UserEntry = new() { User = new() };
		}
	}
}

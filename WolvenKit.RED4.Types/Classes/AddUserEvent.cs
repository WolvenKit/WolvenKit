using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddUserEvent : redEvent
	{
		private SecuritySystemClearanceEntry _userEntry;

		[Ordinal(0)] 
		[RED("userEntry")] 
		public SecuritySystemClearanceEntry UserEntry
		{
			get => GetProperty(ref _userEntry);
			set => SetProperty(ref _userEntry, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questHUDEntryVisibilityEvent : redEvent
	{
		private CArray<questHUDEntryVisibilityData> _dataEntries;

		[Ordinal(0)] 
		[RED("dataEntries")] 
		public CArray<questHUDEntryVisibilityData> DataEntries
		{
			get => GetProperty(ref _dataEntries);
			set => SetProperty(ref _dataEntries, value);
		}
	}
}

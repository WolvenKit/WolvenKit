using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayRecordedSessionMenuGameController : PreGameSubMenuGameController
	{
		private CWeakHandle<inkSelectorController> _recordsSelector;
		private CArray<CString> _records;

		[Ordinal(3)] 
		[RED("recordsSelector")] 
		public CWeakHandle<inkSelectorController> RecordsSelector
		{
			get => GetProperty(ref _recordsSelector);
			set => SetProperty(ref _recordsSelector, value);
		}

		[Ordinal(4)] 
		[RED("records")] 
		public CArray<CString> Records
		{
			get => GetProperty(ref _records);
			set => SetProperty(ref _records, value);
		}
	}
}

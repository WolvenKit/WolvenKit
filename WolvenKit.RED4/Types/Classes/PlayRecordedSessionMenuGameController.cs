using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayRecordedSessionMenuGameController : PreGameSubMenuGameController
	{
		[Ordinal(3)] 
		[RED("recordsSelector")] 
		public CWeakHandle<inkSelectorController> RecordsSelector
		{
			get => GetPropertyValue<CWeakHandle<inkSelectorController>>();
			set => SetPropertyValue<CWeakHandle<inkSelectorController>>(value);
		}

		[Ordinal(4)] 
		[RED("records")] 
		public CArray<CString> Records
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public PlayRecordedSessionMenuGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

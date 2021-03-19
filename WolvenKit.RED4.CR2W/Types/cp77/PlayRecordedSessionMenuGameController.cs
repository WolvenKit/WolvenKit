using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayRecordedSessionMenuGameController : PreGameSubMenuGameController
	{
		private wCHandle<inkSelectorController> _recordsSelector;
		private CArray<CString> _records;

		[Ordinal(3)] 
		[RED("recordsSelector")] 
		public wCHandle<inkSelectorController> RecordsSelector
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

		public PlayRecordedSessionMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

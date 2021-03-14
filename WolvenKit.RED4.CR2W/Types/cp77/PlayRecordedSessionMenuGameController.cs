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
			get
			{
				if (_recordsSelector == null)
				{
					_recordsSelector = (wCHandle<inkSelectorController>) CR2WTypeManager.Create("whandle:inkSelectorController", "recordsSelector", cr2w, this);
				}
				return _recordsSelector;
			}
			set
			{
				if (_recordsSelector == value)
				{
					return;
				}
				_recordsSelector = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("records")] 
		public CArray<CString> Records
		{
			get
			{
				if (_records == null)
				{
					_records = (CArray<CString>) CR2WTypeManager.Create("array:String", "records", cr2w, this);
				}
				return _records;
			}
			set
			{
				if (_records == value)
				{
					return;
				}
				_records = value;
				PropertySet(this);
			}
		}

		public PlayRecordedSessionMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

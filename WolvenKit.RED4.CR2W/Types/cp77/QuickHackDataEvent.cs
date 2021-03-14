using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackDataEvent : redEvent
	{
		private CHandle<QuickhackData> _selectedData;

		[Ordinal(0)] 
		[RED("selectedData")] 
		public CHandle<QuickhackData> SelectedData
		{
			get
			{
				if (_selectedData == null)
				{
					_selectedData = (CHandle<QuickhackData>) CR2WTypeManager.Create("handle:QuickhackData", "selectedData", cr2w, this);
				}
				return _selectedData;
			}
			set
			{
				if (_selectedData == value)
				{
					return;
				}
				_selectedData = value;
				PropertySet(this);
			}
		}

		public QuickHackDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

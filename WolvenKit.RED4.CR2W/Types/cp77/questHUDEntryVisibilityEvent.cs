using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHUDEntryVisibilityEvent : CVariable
	{
		private CArray<questHUDEntryVisibilityData> _dataEntries;

		[Ordinal(0)] 
		[RED("dataEntries")] 
		public CArray<questHUDEntryVisibilityData> DataEntries
		{
			get
			{
				if (_dataEntries == null)
				{
					_dataEntries = (CArray<questHUDEntryVisibilityData>) CR2WTypeManager.Create("array:questHUDEntryVisibilityData", "dataEntries", cr2w, this);
				}
				return _dataEntries;
			}
			set
			{
				if (_dataEntries == value)
				{
					return;
				}
				_dataEntries = value;
				PropertySet(this);
			}
		}

		public questHUDEntryVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

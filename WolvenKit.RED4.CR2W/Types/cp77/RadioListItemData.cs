using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioListItemData : IScriptable
	{
		private wCHandle<gamedataRadioStation_Record> _record;

		[Ordinal(0)] 
		[RED("record")] 
		public wCHandle<gamedataRadioStation_Record> Record
		{
			get
			{
				if (_record == null)
				{
					_record = (wCHandle<gamedataRadioStation_Record>) CR2WTypeManager.Create("whandle:gamedataRadioStation_Record", "record", cr2w, this);
				}
				return _record;
			}
			set
			{
				if (_record == value)
				{
					return;
				}
				_record = value;
				PropertySet(this);
			}
		}

		public RadioListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

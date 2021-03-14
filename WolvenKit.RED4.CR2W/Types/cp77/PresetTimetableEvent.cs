using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PresetTimetableEvent : redEvent
	{
		private CInt32 _arrayPosition;

		[Ordinal(0)] 
		[RED("arrayPosition")] 
		public CInt32 ArrayPosition
		{
			get
			{
				if (_arrayPosition == null)
				{
					_arrayPosition = (CInt32) CR2WTypeManager.Create("Int32", "arrayPosition", cr2w, this);
				}
				return _arrayPosition;
			}
			set
			{
				if (_arrayPosition == value)
				{
					return;
				}
				_arrayPosition = value;
				PropertySet(this);
			}
		}

		public PresetTimetableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

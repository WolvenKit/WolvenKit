using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponeventsChangeTriggerModeEvent : redEvent
	{
		private CEnum<gamedataTriggerMode> _triggerMode;

		[Ordinal(0)] 
		[RED("triggerMode")] 
		public CEnum<gamedataTriggerMode> TriggerMode
		{
			get
			{
				if (_triggerMode == null)
				{
					_triggerMode = (CEnum<gamedataTriggerMode>) CR2WTypeManager.Create("gamedataTriggerMode", "triggerMode", cr2w, this);
				}
				return _triggerMode;
			}
			set
			{
				if (_triggerMode == value)
				{
					return;
				}
				_triggerMode = value;
				PropertySet(this);
			}
		}

		public gameweaponeventsChangeTriggerModeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

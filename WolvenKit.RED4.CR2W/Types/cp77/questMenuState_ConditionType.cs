using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMenuState_ConditionType : questIUIConditionType
	{
		private CEnum<questEUIMenuState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<questEUIMenuState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<questEUIMenuState>) CR2WTypeManager.Create("questEUIMenuState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		public questMenuState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

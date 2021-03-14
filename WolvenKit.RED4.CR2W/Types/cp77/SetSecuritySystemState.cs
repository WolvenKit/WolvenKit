using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetSecuritySystemState : redEvent
	{
		private CEnum<ESecuritySystemState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<ESecuritySystemState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<ESecuritySystemState>) CR2WTypeManager.Create("ESecuritySystemState", "state", cr2w, this);
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

		public SetSecuritySystemState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

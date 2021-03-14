using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StanceStateChangeEvent : redEvent
	{
		private CEnum<gamedataNPCStanceState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gamedataNPCStanceState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gamedataNPCStanceState>) CR2WTypeManager.Create("gamedataNPCStanceState", "state", cr2w, this);
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

		public StanceStateChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

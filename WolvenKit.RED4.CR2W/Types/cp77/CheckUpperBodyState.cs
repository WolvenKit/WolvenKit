using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckUpperBodyState : AINPCUpperBodyStateCheck
	{
		private CEnum<gamedataNPCUpperBodyState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gamedataNPCUpperBodyState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gamedataNPCUpperBodyState>) CR2WTypeManager.Create("gamedataNPCUpperBodyState", "state", cr2w, this);
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

		public CheckUpperBodyState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

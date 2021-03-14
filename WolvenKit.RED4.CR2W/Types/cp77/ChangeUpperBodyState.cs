using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeUpperBodyState : ChangeUpperBodyStateAbstract
	{
		private CEnum<gamedataNPCUpperBodyState> _newState;

		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<gamedataNPCUpperBodyState> NewState
		{
			get
			{
				if (_newState == null)
				{
					_newState = (CEnum<gamedataNPCUpperBodyState>) CR2WTypeManager.Create("gamedataNPCUpperBodyState", "newState", cr2w, this);
				}
				return _newState;
			}
			set
			{
				if (_newState == value)
				{
					return;
				}
				_newState = value;
				PropertySet(this);
			}
		}

		public ChangeUpperBodyState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

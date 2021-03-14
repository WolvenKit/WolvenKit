using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeStanceState : ChangeStanceStateAbstract
	{
		private CEnum<gamedataNPCStanceState> _newState;

		[Ordinal(1)] 
		[RED("newState")] 
		public CEnum<gamedataNPCStanceState> NewState
		{
			get
			{
				if (_newState == null)
				{
					_newState = (CEnum<gamedataNPCStanceState>) CR2WTypeManager.Create("gamedataNPCStanceState", "newState", cr2w, this);
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

		public ChangeStanceState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

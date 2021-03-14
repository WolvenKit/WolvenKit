using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsPlayerMovingPrereqState : PlayerStateMachinePrereqState
	{
		private CBool _bbValue;

		[Ordinal(3)] 
		[RED("bbValue")] 
		public CBool BbValue
		{
			get
			{
				if (_bbValue == null)
				{
					_bbValue = (CBool) CR2WTypeManager.Create("Bool", "bbValue", cr2w, this);
				}
				return _bbValue;
			}
			set
			{
				if (_bbValue == value)
				{
					return;
				}
				_bbValue = value;
				PropertySet(this);
			}
		}

		public IsPlayerMovingPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

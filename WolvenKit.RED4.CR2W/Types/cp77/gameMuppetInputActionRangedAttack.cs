using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionRangedAttack : gameIMuppetInputAction
	{
		private CEnum<gameMuppetInputActionType> _actionType;

		[Ordinal(0)] 
		[RED("actionType")] 
		public CEnum<gameMuppetInputActionType> ActionType
		{
			get
			{
				if (_actionType == null)
				{
					_actionType = (CEnum<gameMuppetInputActionType>) CR2WTypeManager.Create("gameMuppetInputActionType", "actionType", cr2w, this);
				}
				return _actionType;
			}
			set
			{
				if (_actionType == value)
				{
					return;
				}
				_actionType = value;
				PropertySet(this);
			}
		}

		public gameMuppetInputActionRangedAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceEvent : gameinteractionsInteractionEvent
	{
		private gameinteractionsChoice _choice;
		private CEnum<gameinputActionType> _actionType;

		[Ordinal(4)] 
		[RED("choice")] 
		public gameinteractionsChoice Choice
		{
			get
			{
				if (_choice == null)
				{
					_choice = (gameinteractionsChoice) CR2WTypeManager.Create("gameinteractionsChoice", "choice", cr2w, this);
				}
				return _choice;
			}
			set
			{
				if (_choice == value)
				{
					return;
				}
				_choice = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("actionType")] 
		public CEnum<gameinputActionType> ActionType
		{
			get
			{
				if (_actionType == null)
				{
					_actionType = (CEnum<gameinputActionType>) CR2WTypeManager.Create("gameinputActionType", "actionType", cr2w, this);
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

		public gameinteractionsChoiceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

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
			get => GetProperty(ref _choice);
			set => SetProperty(ref _choice, value);
		}

		[Ordinal(5)] 
		[RED("actionType")] 
		public CEnum<gameinputActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		public gameinteractionsChoiceEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

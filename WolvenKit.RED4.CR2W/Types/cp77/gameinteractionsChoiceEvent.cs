using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceEvent : gameinteractionsInteractionEvent
	{
		[Ordinal(4)] [RED("choice")] public gameinteractionsChoice Choice { get; set; }
		[Ordinal(5)] [RED("actionType")] public CEnum<gameinputActionType> ActionType { get; set; }

		public gameinteractionsChoiceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

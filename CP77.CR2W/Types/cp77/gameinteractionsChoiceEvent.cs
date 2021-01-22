using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceEvent : gameinteractionsInteractionEvent
	{
		[Ordinal(0)]  [RED("actionType")] public CEnum<gameinputActionType> ActionType { get; set; }
		[Ordinal(1)]  [RED("choice")] public gameinteractionsChoice Choice { get; set; }

		public gameinteractionsChoiceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

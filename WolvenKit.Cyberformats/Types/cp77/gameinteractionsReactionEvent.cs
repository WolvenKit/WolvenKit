using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsReactionEvent : redEvent
	{
		[Ordinal(0)] [RED("interactionType")] public CName InteractionType { get; set; }
		[Ordinal(1)] [RED("interactionItems")] public CArray<gameEquipParam> InteractionItems { get; set; }
		[Ordinal(2)] [RED("state")] public CEnum<gameinteractionsReactionState> State { get; set; }

		public gameinteractionsReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PuppetSquadInterface : AICombatSquadScriptInterface
	{
		[Ordinal(0)]  [RED("baseSquadRecord")] public wCHandle<gamedataAISquadParams_Record> BaseSquadRecord { get; set; }
		[Ordinal(1)]  [RED("enumValueToNdx")] public gameEnumNameToIndexCache EnumValueToNdx { get; set; }
		[Ordinal(2)]  [RED("sectorsInitialized")] public CBool SectorsInitialized { get; set; }
		[Ordinal(3)]  [RED("ticketHistory")] public CArray<SquadTicketReceipt> TicketHistory { get; set; }

		public PuppetSquadInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

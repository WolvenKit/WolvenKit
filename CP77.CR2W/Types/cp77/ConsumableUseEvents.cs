using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ConsumableUseEvents : ConsumableTransitions
	{
		[Ordinal(0)]  [RED("effectsApplied")] public CBool EffectsApplied { get; set; }
		[Ordinal(1)]  [RED("modelRemoved")] public CBool ModelRemoved { get; set; }
		[Ordinal(2)]  [RED("activeConsumable")] public gameItemID ActiveConsumable { get; set; }

		public ConsumableUseEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

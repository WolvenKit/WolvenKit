using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ConsumableUseEvents : ConsumableTransitions
	{
		[Ordinal(0)]  [RED("activeConsumable")] public gameItemID ActiveConsumable { get; set; }
		[Ordinal(1)]  [RED("effectsApplied")] public CBool EffectsApplied { get; set; }
		[Ordinal(2)]  [RED("modelRemoved")] public CBool ModelRemoved { get; set; }

		public ConsumableUseEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

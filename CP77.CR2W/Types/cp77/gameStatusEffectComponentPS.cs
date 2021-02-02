using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectComponentPS : gameComponentPS
	{
		[Ordinal(0)]  [RED("statusEffectArray")] public CArray<gameStatusEffect> StatusEffectArray { get; set; }
		[Ordinal(1)]  [RED("delayedFunctions")] public CHandle<gameDelayedFunctionsScheduler> DelayedFunctions { get; set; }
		[Ordinal(2)]  [RED("delayedFunctionsNoTd")] public CHandle<gameDelayedFunctionsScheduler> DelayedFunctionsNoTd { get; set; }
		[Ordinal(3)]  [RED("isPlayerControlled")] public CBool IsPlayerControlled { get; set; }
		[Ordinal(4)]  [RED("tickComponent")] public CBool TickComponent { get; set; }

		public gameStatusEffectComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SyncAnimDeathTask : WithoutHitDataDeathTask
	{
		[Ordinal(0)]  [RED("fastForwardAnimation")] public CHandle<AIArgumentMapping> FastForwardAnimation { get; set; }
		[Ordinal(1)]  [RED("hitData")] public CHandle<animAnimFeature_HitReactionsData> HitData { get; set; }
		[Ordinal(2)]  [RED("hitReactionAction")] public CHandle<ActionHitReactionScriptProxy> HitReactionAction { get; set; }

		public SyncAnimDeathTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

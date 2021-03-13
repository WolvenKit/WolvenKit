using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionHitReactionState : gameActionReplicatedState
	{
		[Ordinal(5)] [RED("animFeature")] public CHandle<animAnimFeature_HitReactionsData> AnimFeature { get; set; }

		public gameActionHitReactionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

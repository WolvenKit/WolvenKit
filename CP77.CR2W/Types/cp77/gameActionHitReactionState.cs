using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameActionHitReactionState : gameActionReplicatedState
	{
		[Ordinal(0)]  [RED("animFeature")] public CHandle<animAnimFeature_HitReactionsData> AnimFeature { get; set; }

		public gameActionHitReactionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

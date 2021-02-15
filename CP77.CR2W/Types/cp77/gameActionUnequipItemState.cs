using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionUnequipItemState : gameActionReplicatedState
	{
		[Ordinal(5)] [RED("slotId")] public TweakDBID SlotId { get; set; }
		[Ordinal(6)] [RED("animFeatureNameRight")] public CName AnimFeatureNameRight { get; set; }
		[Ordinal(7)] [RED("animFeatureNameLeft")] public CName AnimFeatureNameLeft { get; set; }
		[Ordinal(8)] [RED("duration")] public CFloat Duration { get; set; }

		public gameActionUnequipItemState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

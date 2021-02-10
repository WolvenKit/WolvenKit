using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceBumpComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("isPlayerControlled")] public CBool IsPlayerControlled { get; set; }
		[Ordinal(1)]  [RED("movementSpreadDistance")] public CFloat MovementSpreadDistance { get; set; }
		[Ordinal(2)]  [RED("movementSpreadRadius")] public CFloat MovementSpreadRadius { get; set; }
		[Ordinal(3)]  [RED("distanceToReactBack")] public CFloat DistanceToReactBack { get; set; }
		[Ordinal(4)]  [RED("distanceToReactFront")] public CFloat DistanceToReactFront { get; set; }
		[Ordinal(5)]  [RED("reactionSettings")] public CArray<gameinfluenceBumpReactionSetting> ReactionSettings { get; set; }
		[Ordinal(6)]  [RED("autoPlayBumpAnimation")] public CBool AutoPlayBumpAnimation { get; set; }
		[Ordinal(7)]  [RED("isBumpable")] public CBool IsBumpable { get; set; }

		public gameinfluenceBumpComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

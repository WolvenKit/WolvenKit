using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceBumpComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("isPlayerControlled")] public CBool IsPlayerControlled { get; set; }
		[Ordinal(6)] [RED("movementSpreadDistance")] public CFloat MovementSpreadDistance { get; set; }
		[Ordinal(7)] [RED("movementSpreadRadius")] public CFloat MovementSpreadRadius { get; set; }
		[Ordinal(8)] [RED("distanceToReactBack")] public CFloat DistanceToReactBack { get; set; }
		[Ordinal(9)] [RED("distanceToReactFront")] public CFloat DistanceToReactFront { get; set; }
		[Ordinal(10)] [RED("reactionSettings")] public CArray<gameinfluenceBumpReactionSetting> ReactionSettings { get; set; }
		[Ordinal(11)] [RED("autoPlayBumpAnimation")] public CBool AutoPlayBumpAnimation { get; set; }
		[Ordinal(12)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(13)] [RED("isBumpable")] public CBool IsBumpable { get; set; }

		public gameinfluenceBumpComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

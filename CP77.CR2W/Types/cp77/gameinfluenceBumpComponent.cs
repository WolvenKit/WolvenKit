using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceBumpComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("autoPlayBumpAnimation")] public CBool AutoPlayBumpAnimation { get; set; }
		[Ordinal(1)]  [RED("distanceToReactBack")] public CFloat DistanceToReactBack { get; set; }
		[Ordinal(2)]  [RED("distanceToReactFront")] public CFloat DistanceToReactFront { get; set; }
		[Ordinal(3)]  [RED("isBumpable")] public CBool IsBumpable { get; set; }
		[Ordinal(4)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(5)]  [RED("isPlayerControlled")] public CBool IsPlayerControlled { get; set; }
		[Ordinal(6)]  [RED("movementSpreadDistance")] public CFloat MovementSpreadDistance { get; set; }
		[Ordinal(7)]  [RED("movementSpreadRadius")] public CFloat MovementSpreadRadius { get; set; }
		[Ordinal(8)]  [RED("reactionSettings")] public CArray<gameinfluenceBumpReactionSetting> ReactionSettings { get; set; }

		public gameinfluenceBumpComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

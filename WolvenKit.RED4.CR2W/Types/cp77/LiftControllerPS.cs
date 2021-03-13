using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("liftSetup")] public LiftSetup LiftSetup { get; set; }
		[Ordinal(105)] [RED("activeFloor")] public CInt32 ActiveFloor { get; set; }
		[Ordinal(106)] [RED("targetFloor")] public CInt32 TargetFloor { get; set; }
		[Ordinal(107)] [RED("movementState")] public CEnum<gamePlatformMovementState> MovementState { get; set; }
		[Ordinal(108)] [RED("floors")] public CArray<ElevatorFloorSetup> Floors { get; set; }
		[Ordinal(109)] [RED("floorIDs")] public CArray<entEntityID> FloorIDs { get; set; }
		[Ordinal(110)] [RED("floorPSIDs")] public CArray<gamePersistentID> FloorPSIDs { get; set; }
		[Ordinal(111)] [RED("floorsAuthorization")] public CArray<CBool> FloorsAuthorization { get; set; }
		[Ordinal(112)] [RED("timeOnPause")] public CFloat TimeOnPause { get; set; }
		[Ordinal(113)] [RED("isPlayerInsideLift")] public CBool IsPlayerInsideLift { get; set; }
		[Ordinal(114)] [RED("isSpeakerDestroyed")] public CBool IsSpeakerDestroyed { get; set; }
		[Ordinal(115)] [RED("hasSpeaker")] public CBool HasSpeaker { get; set; }
		[Ordinal(116)] [RED("stations")] public CArray<RadioStationsMap> Stations { get; set; }
		[Ordinal(117)] [RED("cachedGoToFloorAction")] public CInt32 CachedGoToFloorAction { get; set; }
		[Ordinal(118)] [RED("isAllDoorsClosed")] public CBool IsAllDoorsClosed { get; set; }
		[Ordinal(119)] [RED("isAdsDisabled")] public CBool IsAdsDisabled { get; set; }

		public LiftControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LiftControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("activeFloor")] public CInt32 ActiveFloor { get; set; }
		[Ordinal(1)]  [RED("cachedGoToFloorAction")] public CInt32 CachedGoToFloorAction { get; set; }
		[Ordinal(2)]  [RED("floorIDs")] public CArray<entEntityID> FloorIDs { get; set; }
		[Ordinal(3)]  [RED("floorPSIDs")] public CArray<gamePersistentID> FloorPSIDs { get; set; }
		[Ordinal(4)]  [RED("floors")] public CArray<ElevatorFloorSetup> Floors { get; set; }
		[Ordinal(5)]  [RED("floorsAuthorization")] public CArray<CBool> FloorsAuthorization { get; set; }
		[Ordinal(6)]  [RED("hasSpeaker")] public CBool HasSpeaker { get; set; }
		[Ordinal(7)]  [RED("isAdsDisabled")] public CBool IsAdsDisabled { get; set; }
		[Ordinal(8)]  [RED("isAllDoorsClosed")] public CBool IsAllDoorsClosed { get; set; }
		[Ordinal(9)]  [RED("isPlayerInsideLift")] public CBool IsPlayerInsideLift { get; set; }
		[Ordinal(10)]  [RED("isSpeakerDestroyed")] public CBool IsSpeakerDestroyed { get; set; }
		[Ordinal(11)]  [RED("liftSetup")] public LiftSetup LiftSetup { get; set; }
		[Ordinal(12)]  [RED("movementState")] public CEnum<gamePlatformMovementState> MovementState { get; set; }
		[Ordinal(13)]  [RED("stations")] public CArray<RadioStationsMap> Stations { get; set; }
		[Ordinal(14)]  [RED("targetFloor")] public CInt32 TargetFloor { get; set; }
		[Ordinal(15)]  [RED("timeOnPause")] public CFloat TimeOnPause { get; set; }

		public LiftControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

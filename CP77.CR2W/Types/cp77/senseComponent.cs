using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("enableBeingDetectable")] public CBool EnableBeingDetectable { get; set; }
		[Ordinal(1)]  [RED("visibleObject")] public CHandle<senseVisibleObject> VisibleObject { get; set; }
		[Ordinal(2)]  [RED("sensorObject")] public CHandle<senseSensorObject> SensorObject { get; set; }
		[Ordinal(3)]  [RED("highLevelCb")] public CUInt32 HighLevelCb { get; set; }
		[Ordinal(4)]  [RED("reactionCb")] public CUInt32 ReactionCb { get; set; }
		[Ordinal(5)]  [RED("highLevelState")] public CEnum<gamedataNPCHighLevelState> HighLevelState { get; set; }
		[Ordinal(6)]  [RED("mainPreset")] public TweakDBID MainPreset { get; set; }
		[Ordinal(7)]  [RED("secondaryPreset")] public TweakDBID SecondaryPreset { get; set; }
		[Ordinal(8)]  [RED("puppetBlackboard")] public CHandle<gameIBlackboard> PuppetBlackboard { get; set; }
		[Ordinal(9)]  [RED("playerTakedownStateCallbackID")] public CUInt32 PlayerTakedownStateCallbackID { get; set; }
		[Ordinal(10)]  [RED("playerUpperBodyStateCallbackID")] public CUInt32 PlayerUpperBodyStateCallbackID { get; set; }
		[Ordinal(11)]  [RED("playerCarryingStateCallbackID")] public CUInt32 PlayerCarryingStateCallbackID { get; set; }
		[Ordinal(12)]  [RED("playerInPerception")] public wCHandle<PlayerPuppet> PlayerInPerception { get; set; }

		public senseComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

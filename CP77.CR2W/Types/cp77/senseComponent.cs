using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("enableBeingDetectable")] public CBool EnableBeingDetectable { get; set; }
		[Ordinal(6)] [RED("visibleObject")] public CHandle<senseVisibleObject> VisibleObject { get; set; }
		[Ordinal(7)] [RED("sensorObject")] public CHandle<senseSensorObject> SensorObject { get; set; }
		[Ordinal(8)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(9)] [RED("highLevelCb")] public CUInt32 HighLevelCb { get; set; }
		[Ordinal(10)] [RED("reactionCb")] public CUInt32 ReactionCb { get; set; }
		[Ordinal(11)] [RED("highLevelState")] public CEnum<gamedataNPCHighLevelState> HighLevelState { get; set; }
		[Ordinal(12)] [RED("mainPreset")] public TweakDBID MainPreset { get; set; }
		[Ordinal(13)] [RED("secondaryPreset")] public TweakDBID SecondaryPreset { get; set; }
		[Ordinal(14)] [RED("puppetBlackboard")] public CHandle<gameIBlackboard> PuppetBlackboard { get; set; }
		[Ordinal(15)] [RED("playerTakedownStateCallbackID")] public CUInt32 PlayerTakedownStateCallbackID { get; set; }
		[Ordinal(16)] [RED("playerUpperBodyStateCallbackID")] public CUInt32 PlayerUpperBodyStateCallbackID { get; set; }
		[Ordinal(17)] [RED("playerCarryingStateCallbackID")] public CUInt32 PlayerCarryingStateCallbackID { get; set; }
		[Ordinal(18)] [RED("playerInPerception")] public wCHandle<PlayerPuppet> PlayerInPerception { get; set; }

		public senseComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

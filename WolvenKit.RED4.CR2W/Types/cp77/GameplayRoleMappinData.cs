using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayRoleMappinData : gamemappinsMappinScriptData
	{
		[Ordinal(1)] [RED("mappinVisualState")] public CEnum<EMappinVisualState> MappinVisualState { get; set; }
		[Ordinal(2)] [RED("isTagged")] public CBool IsTagged { get; set; }
		[Ordinal(3)] [RED("isQuest")] public CBool IsQuest { get; set; }
		[Ordinal(4)] [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(5)] [RED("isScanningCluesBlocked")] public CBool IsScanningCluesBlocked { get; set; }
		[Ordinal(6)] [RED("isCurrentTarget")] public CBool IsCurrentTarget { get; set; }
		[Ordinal(7)] [RED("visibleThroughWalls")] public CBool VisibleThroughWalls { get; set; }
		[Ordinal(8)] [RED("hasOffscreenArrow")] public CBool HasOffscreenArrow { get; set; }
		[Ordinal(9)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(10)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(11)] [RED("progressBarType")] public CEnum<EProgressBarType> ProgressBarType { get; set; }
		[Ordinal(12)] [RED("progressBarContext")] public CEnum<EProgressBarContext> ProgressBarContext { get; set; }
		[Ordinal(13)] [RED("gameplayRole")] public CEnum<EGameplayRole> GameplayRole { get; set; }
		[Ordinal(14)] [RED("braindanceLayer")] public CEnum<braindanceVisionMode> BraindanceLayer { get; set; }
		[Ordinal(15)] [RED("quality")] public CEnum<gamedataQuality> Quality { get; set; }
		[Ordinal(16)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(17)] [RED("textureID")] public TweakDBID TextureID { get; set; }

		public GameplayRoleMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

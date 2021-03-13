using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayRoleComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("gameplayRole")] public CEnum<EGameplayRole> GameplayRole { get; set; }
		[Ordinal(6)] [RED("autoDeterminGameplayRole")] public CBool AutoDeterminGameplayRole { get; set; }
		[Ordinal(7)] [RED("mappinsDisplayMode")] public CEnum<EMappinDisplayMode> MappinsDisplayMode { get; set; }
		[Ordinal(8)] [RED("displayAllRolesAsGeneric")] public CBool DisplayAllRolesAsGeneric { get; set; }
		[Ordinal(9)] [RED("alwaysCreateMappinAsDynamic")] public CBool AlwaysCreateMappinAsDynamic { get; set; }
		[Ordinal(10)] [RED("mappins")] public CArray<SDeviceMappinData> Mappins { get; set; }
		[Ordinal(11)] [RED("offsetValue")] public CFloat OffsetValue { get; set; }
		[Ordinal(12)] [RED("isBeingScanned")] public CBool IsBeingScanned { get; set; }
		[Ordinal(13)] [RED("isCurrentTarget")] public CBool IsCurrentTarget { get; set; }
		[Ordinal(14)] [RED("isShowingMappins")] public CBool IsShowingMappins { get; set; }
		[Ordinal(15)] [RED("isHighlightedInFocusMode")] public CBool IsHighlightedInFocusMode { get; set; }
		[Ordinal(16)] [RED("currentGameplayRole")] public CEnum<EGameplayRole> CurrentGameplayRole { get; set; }
		[Ordinal(17)] [RED("isGameplayRoleInitialized")] public CBool IsGameplayRoleInitialized { get; set; }
		[Ordinal(18)] [RED("isForceHidden")] public CBool IsForceHidden { get; set; }
		[Ordinal(19)] [RED("isForcedVisibleThroughWalls")] public CBool IsForcedVisibleThroughWalls { get; set; }

		public GameplayRoleComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

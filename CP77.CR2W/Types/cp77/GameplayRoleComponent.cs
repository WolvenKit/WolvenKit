using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameplayRoleComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("alwaysCreateMappinAsDynamic")] public CBool AlwaysCreateMappinAsDynamic { get; set; }
		[Ordinal(1)]  [RED("autoDeterminGameplayRole")] public CBool AutoDeterminGameplayRole { get; set; }
		[Ordinal(2)]  [RED("currentGameplayRole")] public CEnum<EGameplayRole> CurrentGameplayRole { get; set; }
		[Ordinal(3)]  [RED("displayAllRolesAsGeneric")] public CBool DisplayAllRolesAsGeneric { get; set; }
		[Ordinal(4)]  [RED("gameplayRole")] public CEnum<EGameplayRole> GameplayRole { get; set; }
		[Ordinal(5)]  [RED("isBeingScanned")] public CBool IsBeingScanned { get; set; }
		[Ordinal(6)]  [RED("isCurrentTarget")] public CBool IsCurrentTarget { get; set; }
		[Ordinal(7)]  [RED("isForceHidden")] public CBool IsForceHidden { get; set; }
		[Ordinal(8)]  [RED("isForcedVisibleThroughWalls")] public CBool IsForcedVisibleThroughWalls { get; set; }
		[Ordinal(9)]  [RED("isGameplayRoleInitialized")] public CBool IsGameplayRoleInitialized { get; set; }
		[Ordinal(10)]  [RED("isHighlightedInFocusMode")] public CBool IsHighlightedInFocusMode { get; set; }
		[Ordinal(11)]  [RED("isShowingMappins")] public CBool IsShowingMappins { get; set; }
		[Ordinal(12)]  [RED("mappins")] public CArray<SDeviceMappinData> Mappins { get; set; }
		[Ordinal(13)]  [RED("mappinsDisplayMode")] public CEnum<EMappinDisplayMode> MappinsDisplayMode { get; set; }
		[Ordinal(14)]  [RED("offsetValue")] public CFloat OffsetValue { get; set; }

		public GameplayRoleComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class cursorDeviceGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("bbPlayerTierEventId")] public CUInt32 BbPlayerTierEventId { get; set; }
		[Ordinal(1)]  [RED("bbUIData")] public CHandle<gameIBlackboard> BbUIData { get; set; }
		[Ordinal(2)]  [RED("bbWeaponEventId")] public CUInt32 BbWeaponEventId { get; set; }
		[Ordinal(3)]  [RED("bbWeaponInfo")] public CHandle<gameIBlackboard> BbWeaponInfo { get; set; }
		[Ordinal(4)]  [RED("cursorDevice")] public wCHandle<inkImageWidget> CursorDevice { get; set; }
		[Ordinal(5)]  [RED("fadeInAnimation")] public CHandle<inkanimDefinition> FadeInAnimation { get; set; }
		[Ordinal(6)]  [RED("fadeOutAnimation")] public CHandle<inkanimDefinition> FadeOutAnimation { get; set; }
		[Ordinal(7)]  [RED("interactionBlackboardId")] public CUInt32 InteractionBlackboardId { get; set; }
		[Ordinal(8)]  [RED("interactionDeviceState")] public CBool InteractionDeviceState { get; set; }
		[Ordinal(9)]  [RED("isUnarmed")] public CBool IsUnarmed { get; set; }
		[Ordinal(10)]  [RED("sceneTier")] public CEnum<GameplayTier> SceneTier { get; set; }
		[Ordinal(11)]  [RED("upperBodyState")] public CEnum<gamePSMUpperBodyStates> UpperBodyState { get; set; }
		[Ordinal(12)]  [RED("upperBodyStateBlackboardId")] public CUInt32 UpperBodyStateBlackboardId { get; set; }
		[Ordinal(13)]  [RED("wasLastInteractionWithDevice")] public CBool WasLastInteractionWithDevice { get; set; }

		public cursorDeviceGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

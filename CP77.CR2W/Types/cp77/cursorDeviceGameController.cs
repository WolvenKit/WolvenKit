using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cursorDeviceGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("bbUIData")] public CHandle<gameIBlackboard> BbUIData { get; set; }
		[Ordinal(3)] [RED("bbWeaponInfo")] public wCHandle<gameIBlackboard> BbWeaponInfo { get; set; }
		[Ordinal(4)] [RED("bbWeaponEventId")] public CUInt32 BbWeaponEventId { get; set; }
		[Ordinal(5)] [RED("bbPlayerTierEventId")] public CUInt32 BbPlayerTierEventId { get; set; }
		[Ordinal(6)] [RED("interactionBlackboardId")] public CUInt32 InteractionBlackboardId { get; set; }
		[Ordinal(7)] [RED("upperBodyStateBlackboardId")] public CUInt32 UpperBodyStateBlackboardId { get; set; }
		[Ordinal(8)] [RED("sceneTier")] public CEnum<GameplayTier> SceneTier { get; set; }
		[Ordinal(9)] [RED("upperBodyState")] public CEnum<gamePSMUpperBodyStates> UpperBodyState { get; set; }
		[Ordinal(10)] [RED("isUnarmed")] public CBool IsUnarmed { get; set; }
		[Ordinal(11)] [RED("cursorDevice")] public wCHandle<inkImageWidget> CursorDevice { get; set; }
		[Ordinal(12)] [RED("fadeOutAnimation")] public CHandle<inkanimDefinition> FadeOutAnimation { get; set; }
		[Ordinal(13)] [RED("fadeInAnimation")] public CHandle<inkanimDefinition> FadeInAnimation { get; set; }
		[Ordinal(14)] [RED("wasLastInteractionWithDevice")] public CBool WasLastInteractionWithDevice { get; set; }
		[Ordinal(15)] [RED("interactionDeviceState")] public CBool InteractionDeviceState { get; set; }

		public cursorDeviceGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

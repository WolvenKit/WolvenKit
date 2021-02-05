using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class megatronCrosshairGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("bulletSpreedBlackboardId")] public CUInt32 BulletSpreedBlackboardId { get; set; }
		[Ordinal(1)]  [RED("crosshairStateBlackboardId")] public CUInt32 CrosshairStateBlackboardId { get; set; }
		[Ordinal(2)]  [RED("leftPart")] public wCHandle<inkImageWidget> LeftPart { get; set; }
		[Ordinal(3)]  [RED("rightPart")] public wCHandle<inkImageWidget> RightPart { get; set; }
		[Ordinal(4)]  [RED("nearCenterPart")] public wCHandle<inkImageWidget> NearCenterPart { get; set; }
		[Ordinal(5)]  [RED("farCenterPart")] public wCHandle<inkImageWidget> FarCenterPart { get; set; }
		[Ordinal(6)]  [RED("bufferedSpread")] public Vector2 BufferedSpread { get; set; }
		[Ordinal(7)]  [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }
		[Ordinal(8)]  [RED("orgSideSize")] public Vector2 OrgSideSize { get; set; }
		[Ordinal(9)]  [RED("minSpread")] public CFloat MinSpread { get; set; }
		[Ordinal(10)]  [RED("gameplaySpreadMultiplier")] public CFloat GameplaySpreadMultiplier { get; set; }
		[Ordinal(11)]  [RED("crosshairState")] public CEnum<gamePSMCrosshairStates> CrosshairState { get; set; }

		public megatronCrosshairGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class megatronCrosshairGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("bufferedSpread")] public Vector2 BufferedSpread { get; set; }
		[Ordinal(1)]  [RED("bulletSpreedBlackboardId")] public CUInt32 BulletSpreedBlackboardId { get; set; }
		[Ordinal(2)]  [RED("crosshairState")] public CEnum<gamePSMCrosshairStates> CrosshairState { get; set; }
		[Ordinal(3)]  [RED("crosshairStateBlackboardId")] public CUInt32 CrosshairStateBlackboardId { get; set; }
		[Ordinal(4)]  [RED("farCenterPart")] public wCHandle<inkImageWidget> FarCenterPart { get; set; }
		[Ordinal(5)]  [RED("gameplaySpreadMultiplier")] public CFloat GameplaySpreadMultiplier { get; set; }
		[Ordinal(6)]  [RED("leftPart")] public wCHandle<inkImageWidget> LeftPart { get; set; }
		[Ordinal(7)]  [RED("minSpread")] public CFloat MinSpread { get; set; }
		[Ordinal(8)]  [RED("nearCenterPart")] public wCHandle<inkImageWidget> NearCenterPart { get; set; }
		[Ordinal(9)]  [RED("orgSideSize")] public Vector2 OrgSideSize { get; set; }
		[Ordinal(10)]  [RED("rightPart")] public wCHandle<inkImageWidget> RightPart { get; set; }
		[Ordinal(11)]  [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }

		public megatronCrosshairGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
